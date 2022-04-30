using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookMeCinema
{
    public partial class SignIn : Form
    {
        public static string loginDisplay;
        public static string userRole;
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch)) return ch;
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Encryption(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decryption(string input, int key)
        {
            return Encryption(input, 26 - key);
        }
        public SignIn()
        {
            InitializeComponent();
        }

        private void CreateAccount_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
            this.Close();
        }

        private void CreateAccount_label_MouseEnter(object sender, EventArgs e)
        {
            CreateAccount_label.Font = new Font(CreateAccount_label.Font, FontStyle.Underline);
        }

        private void CreateAccount_label_MouseLeave(object sender, EventArgs e)
        {
            CreateAccount_label.Font = new Font(CreateAccount_label.Font, FontStyle.Regular);
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void SignIn_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userLoginSI_TB.Text) || string.IsNullOrWhiteSpace(PasswordSI_TB.Text) || userLoginSI_TB.Text.Any(Char.IsWhiteSpace) || PasswordSI_TB.Text.Any(Char.IsWhiteSpace))
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                string login = userLoginSI_TB.Text;
                loginDisplay = login;

                string password = PasswordSI_TB.Text;
                string passCrypto = Encryption(password, 4);

                string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                SqlDataReader dataReader;
                String sql;
                sql = $"SELECT u.UserLogin, p.Password, r.Description FROM Project1.dbo.Users as u INNER JOIN Project1.dbo.Passwords p ON u.PasswordID = p.PasswordID INNER JOIN Project1.dbo.Roles r ON u.RoleID = r.RoleID WHERE u.UserLogin LIKE '{login}' AND p.Password LIKE '{passCrypto}'";

                SqlCommand cmd = new SqlCommand(sql, cnn);
                try
                {
                    dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        string passDB = dataReader.GetValue(1).ToString();

                        if ((dataReader.GetValue(0).ToString() == login) && (passDB == passCrypto))
                        {
                            userRole = dataReader.GetValue(2).ToString();
                            this.Hide();
                            MoviesList moviesList = new MoviesList();
                            moviesList.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your login or password is incorrect");
                    }
                    dataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Dispose();
                    cnn.Close();
                }

            }
        }
    }
}
