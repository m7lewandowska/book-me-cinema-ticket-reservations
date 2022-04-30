using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace BookMeCinema
{
    public partial class MoviesList : Form
    {
        public static string movieID;
        public static string movieName;
        public static string movieRoom;
        public static string movieDate;
        public static string movieTime;
        public static string role;
        public static ArrayList moviesIDList = new ArrayList();
        public static ArrayList moviesNameList = new ArrayList();
        public static ArrayList moviesRoomList = new ArrayList();
        public static ArrayList moviesDateList = new ArrayList();
        public static ArrayList moviesTimeList = new ArrayList();

        public MoviesList()
        {
            
            InitializeComponent();
            moviesIDList.Clear();
            moviesNameList.Clear();
            moviesRoomList.Clear();
            moviesDateList.Clear();
            moviesTimeList.Clear();
            userLogin_LB.Text = SignIn.loginDisplay;
            role = SignIn.userRole;

            if (role == "Worker")
            {
                addMovie_BTN.Visible = true;
                
            }
            else
            {
                addMovie_BTN.Visible = false;
                addMovie_BTN.Enabled = false;
            }

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT MovieID,MovieName, MovieRoom, MovieDate, MovieTime FROM Project1.dbo.Movies", cnn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    moviesIDList.Add(dataReader[0].ToString());
                    moviesNameList.Add(dataReader[1].ToString());
                    moviesRoomList.Add(dataReader[2].ToString());
                    moviesDateList.Add(dataReader[3].ToString());
                    moviesTimeList.Add(dataReader[4].ToString());
                }

                cmd.Dispose();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }



            for (int i = 0; i < moviesNameList.Count; i++)
            {
                Button button = new Button();
                button.Tag = i;
                button.Name = (i).ToString() + "_BTN";
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.AutoSize = false;
                button.Height = 50;
                button.Width = 570;
                button.Text = (moviesNameList[i].ToString() + " | Room number: " + moviesRoomList[i].ToString() + " | " + moviesDateList[i].ToString() + " | " + moviesTimeList[i].ToString());
                moviesList_FP.Controls.Add(button);
                button.Click += new EventHandler(this.button_click);

                moviesList_FP.AutoScroll = false;
                moviesList_FP.VerticalScroll.Maximum = 0;
                moviesList_FP.VerticalScroll.Visible = false;
                moviesList_FP.HorizontalScroll.Maximum = 0;
                moviesList_FP.HorizontalScroll.Visible = false;
                moviesList_FP.AutoScroll = true;
            }
        }

        void button_click(object sender, EventArgs e)
        {
            if (role == "Worker")
            {
                //Worker
                Button btn = sender as Button;
                string buttonName = btn.Name.ToString();
                int buttonNumber = int.Parse(buttonName.Substring(0, 1));

                movieID = moviesIDList[buttonNumber].ToString();
                movieName = moviesNameList[buttonNumber].ToString();
                movieRoom = moviesRoomList[buttonNumber].ToString();
                movieDate = moviesDateList[buttonNumber].ToString();
                movieTime = moviesTimeList[buttonNumber].ToString();

                this.Hide();
                EditMovie editmovie = new EditMovie();
                editmovie.ShowDialog();
                this.Close();
            }
            else
            {
                //Client
                Button btn = sender as Button;
                string buttonName = btn.Name.ToString();
                int buttonNumber = int.Parse(buttonName.Substring(0, 1));

                movieID = moviesIDList[buttonNumber].ToString();
                movieName = moviesNameList[buttonNumber].ToString();
                movieRoom = moviesRoomList[buttonNumber].ToString();
                movieDate = moviesDateList[buttonNumber].ToString();
                movieTime = moviesTimeList[buttonNumber].ToString();

                this.Hide();
                SeatsReservation seatsreservation = new SeatsReservation();
                seatsreservation.ShowDialog();
                this.Close();
            }
        }

        private void userLogin_LB_MouseEnter(object sender, EventArgs e)
        {
            userLogin_LB.Font = new Font(userLogin_LB.Font, FontStyle.Underline);
        }

        private void userLogin_LB_MouseLeave(object sender, EventArgs e)
        {
            userLogin_LB.Font = new Font(userLogin_LB.Font, FontStyle.Regular);
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void userLogin_LB_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signin = new SignIn();
            signin.ShowDialog();
            this.Close();
        }

        private void addMovie_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMovie addmovie = new AddMovie();
            addmovie.ShowDialog();
            this.Close();
        }

        private void addMovie_BTN_MouseEnter(object sender, EventArgs e)
        {
            addMovie_BTN.UseVisualStyleBackColor = false;
            addMovie_BTN.BackColor = Color.Transparent;
        }

        private void addMovie_BTN_MouseLeave(object sender, EventArgs e)
        {
            addMovie_BTN.UseVisualStyleBackColor = false;
            addMovie_BTN.BackColor = Color.Transparent;
        }
    }
}
