using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookMeCinema
{
    public partial class SignUp : Form
    {
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

        public SignUp()
        {
            InitializeComponent();
        }

        private void HaveAccount_label_MouseEnter(object sender, EventArgs e)
        {
            HaveAccount_label.Font = new Font(HaveAccount_label.Font, FontStyle.Underline);
        }

        private void HaveAccount_label_MouseLeave(object sender, EventArgs e)
        {
            HaveAccount_label.Font = new Font(HaveAccount_label.Font, FontStyle.Regular);
        }

        private void HaveAccount_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signin = new SignIn();
            signin.ShowDialog();
            this.Close();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void SignUp_BTN_Click(object sender, EventArgs e)
        {
            string userlogin = userLoginSU_TB.Text;
            string password = PasswordSU_TB.Text;
            string commandText = "";

            string connectionString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            SqlCommand cmdSelect = new SqlCommand($"SELECT * FROM Project1.dbo.Users WHERE UserLogin Like '{userlogin}'", cnn);
            try
            {
                SqlDataReader dataReader = cmdSelect.ExecuteReader();
                while (!dataReader.Read())
                {
                    if (PinCode_TB.Text == "213742069" && IsWorker_CB.Checked == true)
                    {
                        //Worker
                        if (string.IsNullOrWhiteSpace(userLoginSU_TB.Text) || string.IsNullOrWhiteSpace(PasswordSU_TB.Text) || userLoginSU_TB.Text.Any(Char.IsWhiteSpace) || PasswordSU_TB.Text.Any(Char.IsWhiteSpace))
                        {
                            MessageBox.Show("Invalid input");
                        }
                        else
                        {
                            commandText = $"INSERT INTO Project1.dbo.Passwords (Password) VALUES ('{Encryption(password, 4)}'); INSERT INTO Project1.dbo.Users (UserLogin,RoleID,PasswordID) VALUES ('{userlogin}',1,(SELECT TOP 1 PasswordID FROM Project1.dbo.Passwords ORDER BY PasswordID DESC));";
                        }
                    }
                    else if (IsWorker_CB.Checked == false)
                    {
                        //Client
                        if (string.IsNullOrWhiteSpace(userLoginSU_TB.Text) || string.IsNullOrWhiteSpace(PasswordSU_TB.Text) || userLoginSU_TB.Text.Any(Char.IsWhiteSpace) || PasswordSU_TB.Text.Any(Char.IsWhiteSpace))
                        {
                            MessageBox.Show("Invalid input");
                        }
                        else
                        {
                            commandText = $"INSERT INTO Project1.dbo.Passwords (Password) VALUES ('{Encryption(password, 4)}'); INSERT INTO Project1.dbo.Users (UserLogin,RoleID,PasswordID) VALUES ('{userlogin}',2,(SELECT TOP 1 PasswordID FROM Project1.dbo.Passwords ORDER BY PasswordID DESC));";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong pin code!");
                        PinCode_TB.Text = "";
                    }

                    SqlCommand cmd = new SqlCommand(commandText, cnn);
                    cmd.ExecuteNonQuery();

                    this.Hide();
                    SignIn signin = new SignIn();
                    signin.ShowDialog();
                    this.Close();
                }
                MessageBox.Show("Login exist!");
                userLoginSU_TB.Text = "";
                PasswordSU_TB.Text = "";
                PinCode_TB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmdSelect.Dispose();
                cnn.Close();
            }

        }

        private void IsWorker_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (IsWorker_CB.Checked)
            {
                PinCode_TB.Visible = true;
            }
            else
            {
                PinCode_TB.Visible = false;
            }
        }
    }
}
