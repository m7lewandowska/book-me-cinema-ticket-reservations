using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookMeCinema
{
    public partial class AddMovie : Form
    {
        string MovieNameAdd, MovieDateAdd, MovieTimeAdd;
        int MovieRoomAdd;
        string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;";

        public AddMovie()
        {
            InitializeComponent();
            userLogin_LB.Text = SignIn.loginDisplay;
            MovieDateAdd_TB.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm");
            // MovieDateAdd_TB.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
            MovieTimeAdd_TB.Text = "01:30";
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        private void userLogin_LB_MouseEnter(object sender, EventArgs e)
        {
            userLogin_LB.Font = new Font(userLogin_LB.Font, FontStyle.Underline);
        }

        private void userLogin_LB_MouseLeave(object sender, EventArgs e)
        {
            userLogin_LB.Font = new Font(userLogin_LB.Font, FontStyle.Regular);
        }

        private void userLogin_LB_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signin = new SignIn();
            signin.ShowDialog();
            this.Close();
        }

        public static bool isValidDate(string dateValue)
        {
            string pattern = @"20\d{2}-((0[1-9])|(1[0-2]))-((0[1-9])|([1-2][0-9])|(3[0-1]))\s(([0-1][0-9])|(2[0-3])):([0-5][0-9])";
            Regex dateRegex = new Regex(pattern);
            return dateRegex.IsMatch(dateValue);
        }

        public static bool isValidTime(string timeValue)
        {
            string pattern = @"(([0-1][0-9])|(2[0-3])):([0-5][0-9])";
            Regex timeRegex = new Regex(pattern);
            return timeRegex.IsMatch(timeValue);
        }

        private void SaveAdd_BT_Click(object sender, EventArgs e)
        {
            MovieNameAdd = MovieNameAdd_TB.Text;
            MovieDateAdd = MovieDateAdd_TB.Text;
            MovieTimeAdd = MovieTimeAdd_TB.Text;

            if (isValidDate(MovieDateAdd))
            {
                if (isValidTime(MovieTimeAdd))
                {
                    if (Room1_CB.Checked)
                    {
                        MovieRoomAdd = 1;
                    }
                    else if (Room2_CB.Checked)
                    {
                        MovieRoomAdd = 2;
                    }
                    else if (Room3_CB.Checked)
                    {
                        MovieRoomAdd = 3;
                    }

                    SqlConnection cnn = new SqlConnection(connectionString);
                    DateTime MDA = DateTime.Parse(MovieDateAdd);
                    string commandText = $"INSERT INTO Project1.dbo.Movies (MovieName, MovieRoom, MovieDate, MovieTime) VALUES ('{MovieNameAdd}','{MovieRoomAdd}','{MovieDateAdd}', '{MovieTimeAdd}')";

                    try
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand($"SELECT TOP 1 MovieRoom, MovieEnd = MovieDate + CAST(MovieTime as smalldatetime) FROM Project1.dbo.Movies WHERE MovieRoom Like {MovieRoomAdd} ORDER BY MovieEnd DESC;", cnn);
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        if (!dataReader.HasRows)
                        {
                            try
                            {
                                SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                                cmd2.ExecuteNonQuery();
                                cmd2.Dispose();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            finally
                            {

                                SqlCommand cmd3 = new SqlCommand(commandText, cnn);
                                for (int i = 1; i < 10; i++)
                                {
                                    string generatrSeatsQuery = $"INSERT INTO Project1.dbo.Seats(MovieID, SeatNumber, SeatStatus) VALUES (IDENT_CURRENT('Project1.dbo.Movies'),{i},1)";
                                    cmd3 = new SqlCommand(generatrSeatsQuery, cnn);
                                    cmd3.ExecuteNonQuery();
                                    cmd3.Dispose();
                                }

                                this.Hide();
                                MoviesList moviesList = new MoviesList();
                                moviesList.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            while (dataReader.Read())
                            {
                                DateTime ActualDate = DateTime.Parse(DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss"));
                                DateTime MEA = DateTime.Parse(dataReader[1].ToString());
                                int movieRoom = (int)dataReader[0];

                                if (MDA > ActualDate)
                                {
                                    switch (MovieRoomAdd)
                                    {
                                        case 1:
                                            if (MDA >= MEA)
                                            {
                                                try
                                                {
                                                    SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                                                    cmd2.ExecuteNonQuery();
                                                    cmd2.Dispose();

                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                                finally
                                                {
                                                    SqlCommand cmd3 = new SqlCommand(commandText, cnn);
                                                    for (int i = 1; i < 10; i++)
                                                    {
                                                        string generatrSeatsQuery = $"INSERT INTO Project1.dbo.Seats(MovieID, SeatNumber, SeatStatus) VALUES (IDENT_CURRENT('Project1.dbo.Movies'),{i},1)";
                                                        cmd3 = new SqlCommand(generatrSeatsQuery, cnn);
                                                        cmd3.ExecuteNonQuery();
                                                        cmd3.Dispose();
                                                    }


                                                    this.Hide();
                                                    MoviesList moviesList = new MoviesList();
                                                    moviesList.ShowDialog();
                                                    this.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("You are trying to add a video at the time of another video");
                                            }
                                            break;

                                        case 2:
                                            if (MDA >= MEA)
                                            {
                                                try
                                                {
                                                    SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                                                    cmd2.ExecuteNonQuery();
                                                    cmd2.Dispose();

                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                                finally
                                                {
                                                    SqlCommand cmd3 = new SqlCommand(commandText, cnn);
                                                    for (int i = 1; i < 10; i++)
                                                    {
                                                        string generatrSeatsQuery = $"INSERT INTO Project1.dbo.Seats(MovieID, SeatNumber, SeatStatus) VALUES (IDENT_CURRENT('Project1.dbo.Movies'),{i},1)";
                                                        cmd3 = new SqlCommand(generatrSeatsQuery, cnn);
                                                        cmd3.ExecuteNonQuery();
                                                        cmd3.Dispose();
                                                    }

                                                    this.Hide();
                                                    MoviesList moviesList = new MoviesList();
                                                    moviesList.ShowDialog();
                                                    this.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("You are trying to add a video at the time of another video");
                                            }
                                            break;

                                        case 3:
                                            if (MDA >= MEA)
                                            {
                                                try
                                                {
                                                    SqlCommand cmd2 = new SqlCommand(commandText, cnn);
                                                    cmd2.ExecuteNonQuery();
                                                    
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }
                                                finally
                                                {

                                                    SqlCommand cmd3 = new SqlCommand(commandText, cnn);
                                                    for (int i = 1; i < 10; i++)
                                                    {
                                                        string generatrSeatsQuery = $"INSERT INTO Project1.dbo.Seats(MovieID, SeatNumber, SeatStatus) VALUES (IDENT_CURRENT('Project1.dbo.Movies'),{i},1)";
                                                        cmd3 = new SqlCommand(generatrSeatsQuery, cnn);
                                                        cmd3.ExecuteNonQuery();
                                                        cmd3.Dispose();
                                                    }

                                                    this.Hide();
                                                    MoviesList moviesList = new MoviesList();
                                                    moviesList.ShowDialog();
                                                    this.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("You are trying to add a video at the time of another video");
                                            }
                                            break;

                                        default:
                                            MessageBox.Show("You are trying to add a video to unknown room");
                                            break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("You are trying to add a video in the past");
                                }
                            }
                        }
                        cmd.Dispose();

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
                else
                {
                    MessageBox.Show("Wrong time format");
                    MovieTimeAdd_TB.Text = "01:30";
                }
            }
            else
            {
                MessageBox.Show("Wrong date format");
                MovieDateAdd_TB.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm");
            }
        }

        private void CancelAdd_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoviesList moviesList = new MoviesList();
            moviesList.ShowDialog();
            this.Close();
        }
    }
}
