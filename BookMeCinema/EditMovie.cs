using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookMeCinema
{
    public partial class EditMovie : Form
    {
        string MovieID = MoviesList.movieID,
               MovieName = MoviesList.movieName,
               MovieDate = MoviesList.movieDate,
               MovieTime = MoviesList.movieTime;

        int MovieRoom = int.Parse(MoviesList.movieRoom), NewMovieRoom;
        public EditMovie()
        { 
            InitializeComponent();
            userLogin_LB.Text = SignIn.loginDisplay;

            MovieDate = DateTime.ParseExact(MovieDate, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            MovieTime = DateTime.ParseExact(MovieTime, "HH:mm:ss", CultureInfo.InvariantCulture).ToString("HH:mm:ss", CultureInfo.InvariantCulture);

            MovieNameEdit_TB.Text = MovieName;
            MovieDateEdit_TB.Text = MovieDate;
            MovieTimeEdit_TB.Text = MovieTime;

            if (MovieRoom == 1)
            {
                Room1_CB.Checked = true;
            }
            else if (MovieRoom == 2)
            {
                Room2_CB.Checked = true;
            }
            else if(MovieRoom == 3)
            {
                Room3_CB.Checked = true;
            }
        }

        private void SaveEdit_BT_Click(object sender, EventArgs e)
        {
            if (Room1_CB.Checked)
            {
                NewMovieRoom = 1;
            }
            else if (Room2_CB.Checked)
            {
                NewMovieRoom = 2;
            }
            else if (Room3_CB.Checked)
            {
                NewMovieRoom = 3;
            }

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection cnn = new SqlConnection(connectionString);
            
            try
            {
                cnn.Open();
                string commandText = $"UPDATE Project1.dbo.Movies SET MovieName = '{MovieNameEdit_TB.Text}', MovieRoom = '{NewMovieRoom}', MovieDate = '{MovieDateEdit_TB.Text}', MovieTime = '{MovieTimeEdit_TB.Text}' WHERE MovieID LIKE '{MovieID}'";
                SqlCommand cmd = new SqlCommand(commandText, cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            this.Hide();
            MoviesList moviesList = new MoviesList();
            moviesList.ShowDialog();
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

        private void DeleteEdit_BT_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                string commandText = $"DELETE s FROM Project1.dbo.Seats s INNER JOIN Project1.dbo.Movies m ON m.MovieID=s.MovieID WHERE m.MovieID Like '{MovieID}'; DELETE m FROM Project1.dbo.Movies m WHERE MovieID Like '{MovieID}'; ";
                SqlCommand cmd = new SqlCommand(commandText, cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();
            }

            this.Hide();
            MoviesList moviesList = new MoviesList();
            moviesList.ShowDialog();
            this.Close();
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

        private void CancelEdit_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoviesList moviesList = new MoviesList();
            moviesList.ShowDialog();
            this.Close();
        }

        private void delMovie_BTN_MouseEnter(object sender, EventArgs e)
        {
            DeleteEdit_BT.UseVisualStyleBackColor = false;
            DeleteEdit_BT.BackColor = Color.Transparent;
        }

        private void delMovie_BTN_MouseLeave(object sender, EventArgs e)
        {
            DeleteEdit_BT.UseVisualStyleBackColor = false;
            DeleteEdit_BT.BackColor = Color.Transparent;
        }
    }
}
