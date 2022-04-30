using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookMeCinema
{
    public partial class SeatsReservation : Form
    {
        string MovieName = MoviesList.movieName,
               MovieDate = MoviesList.movieDate,
               MovieTime = MoviesList.movieTime;
        int  clickedbutton = 0, MovieRoom = int.Parse(MoviesList.movieRoom);
        private int counter = 120;

        private Timer dbTimer, refreshTimer;
        public SeatsReservation()
        {
            InitializeComponent();
            
            userLogin_LB.Text = SignIn.loginDisplay;
            movieInfo_LB.Text = MovieName + "   |   Room number: " + MovieRoom + "  |   Date: " + MovieDate;

            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Tag = i;
                button.Name = "BTN_SR_" + i.ToString();
                button.Click += new EventHandler(this.SeatChoose_Click);
            }

            dbTimer = new Timer();
            dbTimer.Interval = 100;//0.1 second
            dbTimer.Tick += new EventHandler(changeColor);
            dbTimer.Start();
            
        }

        private void SeatChoose_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string buttonName = btn.Name.ToString();
            int buttonNumber = int.Parse(buttonName.Substring(7, 1));
            SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;");
            try
            {
                cnn.Open();
                SqlCommand cmdSelect = new SqlCommand($"SELECT s.SeatNumber, s.SeatStatus FROM Project1.dbo.Seats s", cnn);
                SqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    if (buttonName == "BTN_SR_" + dataReader.GetValue(0).ToString() && dataReader.GetValue(1).ToString() == "1")
                    {
                        string commandText = $"UPDATE Project1.dbo.Seats SET UserID = (SELECT UserID FROM Project1.dbo.Users WHERE UserLogin Like '{userLogin_LB.Text}'), SeatStatus = 3, SeatStartTimeReservation = '{DateTime.Now.ToString("HH':'mm':'ss")}', SeatEndTimeReservation = '{DateTime.Now.AddMinutes(2).ToString("HH':'mm':'ss")}' WHERE SeatStatus=1 AND SeatNumber Like '{buttonNumber}' AND MovieID = (SELECT MovieID FROM Project1.dbo.Movies WHERE MovieName Like '{MovieName}' AND MovieRoom = '{MovieRoom}' AND MovieDate = '{DateTime.Parse(MovieDate).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")}')";
                        SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        timerSR_TB.Visible = true;
                        seconds_LB.Visible = true;
                        clickedbutton++;
                        if (refreshTimer != null && clickedbutton > 0)
                            refreshTimer.Stop();
                        timerStart();
                        return;

                    }
                    else if(buttonName == "BTN_SR_" + dataReader.GetValue(0).ToString() && dataReader.GetValue(1).ToString() == "3")
                    {
                        string commandText = $"UPDATE Project1.dbo.Seats SET UserID = NULL, SeatStatus = 1, SeatStartTimeReservation = NULL, SeatEndTimeReservation = NULL WHERE SeatStatus=3 AND SeatNumber Like '{buttonNumber}' AND UserID = (SELECT UserID FROM Project1.dbo.Users WHERE UserLogin Like '{userLogin_LB.Text}') AND MovieID = (SELECT MovieID FROM Project1.dbo.Movies WHERE MovieName Like '{MovieName}' AND MovieRoom = '{MovieRoom}' AND MovieDate = '{DateTime.Parse(MovieDate).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")}')";
                        SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                        cmd2.ExecuteNonQuery();
                        cmd2.Dispose();

                        clickedbutton -= 1;
                        if (clickedbutton == 0)
                        {
                            refreshTimer.Stop();
                            counter = 120;
                            timerSR_TB.Visible = false;
                            seconds_LB.Visible = false;
                        }
                        return;
                    }
                }
                cmdSelect.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void saveChooseSeat_BTN_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;");
            try
            {
                cnn.Open();
                string commandText = $"UPDATE s SET SeatStatus = 2 FROM Project1.dbo.Seats s INNER JOIN Project1.dbo.Users u ON s.UserID=u.UserID WHERE s.UserID = (SELECT UserID FROM Project1.dbo.Users WHERE UserLogin Like '{userLogin_LB.Text}') AND SeatStatus Like '3' AND s.MovieID = (SELECT MovieID FROM Project1.dbo.Movies WHERE MovieName Like '{MovieName}' AND MovieRoom = '{MovieRoom}' AND MovieDate = '{DateTime.Parse(MovieDate).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")}')";
                SqlCommand cmd = new SqlCommand(commandText, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
                refreshTimer.Stop();
                timerSR_TB.Visible = false;
                seconds_LB.Visible = false;
            }
        }

        private void changeColor(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;");
            try
            {
                cnn.Open();
                string commandText = $"SELECT s.SeatNumber, s.SeatStatus FROM Project1.dbo.Seats s WHERE s.MovieID = (SELECT MovieID FROM Project1.dbo.Movies WHERE MovieName Like '{MovieName}' AND MovieRoom = '{MovieRoom}' AND MovieDate = '{DateTime.Parse(MovieDate).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")}')";
                SqlCommand cmdSelect = new SqlCommand(commandText, cnn);
                SqlDataReader dataReader = cmdSelect.ExecuteReader();

                while (dataReader.Read())
                {
                    foreach (var button in panel1.Controls.OfType<Button>())
                    {
                        if (button.Name == "BTN_SR_" + dataReader.GetValue(0).ToString() && dataReader.GetValue(1).ToString() == "1")
                        {
                            button.BackColor = Color.LawnGreen;
                            button.Enabled = true;
                            button.FlatAppearance.BorderSize = 0;
                            button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
                        }

                        if (button.Name == "BTN_SR_" + dataReader.GetValue(0).ToString() && dataReader.GetValue(1).ToString() == "3")
                        {
                            button.BackColor = Color.Gold;
                            SqlConnection cnn2 = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;");
                            try
                            {
                                cnn2.Open();
                                string queryText = $"SELECT u.UserLogin FROM Project1.dbo.Seats s INNER JOIN Project1.dbo.Users u ON u.UserID = s.UserID WHERE s.SeatNumber = {dataReader.GetValue(0)} AND s.MovieID = (SELECT MovieID FROM Project1.dbo.Movies WHERE MovieName Like '{MovieName}' AND MovieRoom = '{MovieRoom}' AND MovieDate = '{DateTime.Parse(MovieDate).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")}')";
                                SqlCommand sqlCommand = new SqlCommand(queryText, cnn2);
                                SqlDataReader dataSelect = sqlCommand.ExecuteReader();

                                while (dataSelect.Read())
                                {
                                    if (dataSelect.GetValue(0).ToString() != userLogin_LB.Text)
                                    {

                                        button.Enabled = false;
                                        button.FlatAppearance.BorderSize = 0;
                                    }
                                    else
                                    {
                                        button.FlatAppearance.BorderColor = Color.FromArgb(255,120,0);
                                        button.FlatAppearance.BorderSize = 3;
                                        button.Enabled = true;
                                    }

                                }
                                sqlCommand.Dispose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                cnn2.Close();
                            }
                        }

                        if (button.Name == "BTN_SR_" + dataReader.GetValue(0).ToString() && dataReader.GetValue(1).ToString() == "2")
                        {
                            button.BackColor = Color.Crimson;
                            button.Enabled = false;
                            SqlConnection cnn2 = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;");
                            try
                            {
                                cnn2.Open();
                                string queryText = $"SELECT u.UserLogin FROM Project1.dbo.Seats s INNER JOIN Project1.dbo.Users u ON u.UserID = s.UserID WHERE s.SeatNumber = {dataReader.GetValue(0)} AND s.MovieID = (SELECT MovieID FROM Project1.dbo.Movies WHERE MovieName Like '{MovieName}' AND MovieRoom = '{MovieRoom}' AND MovieDate = '{DateTime.Parse(MovieDate).ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss")}')";
                                SqlCommand sqlCommand = new SqlCommand(queryText, cnn2);
                                SqlDataReader dataSelect = sqlCommand.ExecuteReader();

                                while (dataSelect.Read())
                                {
                                    if (dataSelect.GetValue(0).ToString() != userLogin_LB.Text)
                                    {
                                        button.FlatAppearance.BorderSize = 0;
                                    }
                                    else
                                    {
                                        button.FlatAppearance.BorderColor = Color.FromArgb(120,11,33);
                                        button.FlatAppearance.BorderSize = 3;
                                    }

                                }
                                sqlCommand.Dispose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {
                                cnn2.Close();
                            }
                        }
                    }
                }
                cmdSelect.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void deleteReservation()
        {
            SqlConnection cnn = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;");
            try
            {
                cnn.Open();
                string commandText = $"UPDATE Project1.dbo.Seats SET UserID = NULL, SeatStatus = 1, SeatStartTimeReservation = NULL, SeatEndTimeReservation = NULL WHERE SeatStatus = 3 AND UserID = (SELECT UserID FROM Project1.dbo.Users WHERE UserLogin Like '{userLogin_LB.Text}')";
                SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();

                if (clickedbutton != 0)
                {
                    refreshTimer.Stop();
                    counter = 120;
                    timerSR_TB.Visible = false;
                    seconds_LB.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                refreshTimer.Stop();
                deleteReservation();
            }

            timerSR_TB.Text = counter.ToString();
        }

        private void timerStart()
        {
            refreshTimer = new Timer();
            refreshTimer.Tick += new EventHandler(refreshTimer_Tick);
            refreshTimer.Interval = 1000; // 1 second
            refreshTimer.Start();
            timerSR_TB.Text = counter.ToString();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            dbTimer.Stop();
            deleteReservation();
            Application.ExitThread();
        }

        private void userLogin_LB_Click(object sender, EventArgs e)
        {
            dbTimer.Stop();
            deleteReservation();
            this.Hide();
            SignIn signin = new SignIn();
            signin.ShowDialog();
            this.Close();
        }

        private void userLogin_LB_MouseEnter(object sender, EventArgs e)
        {
            userLogin_LB.Font = new Font(userLogin_LB.Font, FontStyle.Underline);
        }

        private void userLogin_LB_MouseLeave(object sender, EventArgs e)
        {
            userLogin_LB.Font = new Font(userLogin_LB.Font, FontStyle.Regular);
        }

        private void backChooseSeat_BTN_Click(object sender, EventArgs e)
        {
            dbTimer.Stop();
            deleteReservation();
            this.Hide();
            MoviesList movieslist = new MoviesList();
            movieslist.ShowDialog();
            this.Close();
        }
    }
}
