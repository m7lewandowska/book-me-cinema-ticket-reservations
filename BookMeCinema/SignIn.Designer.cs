
namespace BookMeCinema
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.SignIn_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLoginSI_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordSI_TB = new System.Windows.Forms.TextBox();
            this.CreateAccount_label = new System.Windows.Forms.Label();
            this.close_BTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).BeginInit();
            this.SuspendLayout();
            // 
            // SignIn_BTN
            // 
            this.SignIn_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.SignIn_BTN.FlatAppearance.BorderSize = 0;
            this.SignIn_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignIn_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.SignIn_BTN.Location = new System.Drawing.Point(383, 326);
            this.SignIn_BTN.Name = "SignIn_BTN";
            this.SignIn_BTN.Size = new System.Drawing.Size(109, 37);
            this.SignIn_BTN.TabIndex = 0;
            this.SignIn_BTN.Text = "SIGN IN";
            this.SignIn_BTN.UseVisualStyleBackColor = false;
            this.SignIn_BTN.Click += new System.EventHandler(this.SignIn_BTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 450);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(304, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign In";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(304, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login:";
            // 
            // userLoginSI_TB
            // 
            this.userLoginSI_TB.Location = new System.Drawing.Point(304, 168);
            this.userLoginSI_TB.Name = "userLoginSI_TB";
            this.userLoginSI_TB.Size = new System.Drawing.Size(269, 23);
            this.userLoginSI_TB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(304, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // PasswordSI_TB
            // 
            this.PasswordSI_TB.Location = new System.Drawing.Point(304, 247);
            this.PasswordSI_TB.Name = "PasswordSI_TB";
            this.PasswordSI_TB.PasswordChar = '*';
            this.PasswordSI_TB.Size = new System.Drawing.Size(269, 23);
            this.PasswordSI_TB.TabIndex = 9;
            // 
            // CreateAccount_label
            // 
            this.CreateAccount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.CreateAccount_label.Location = new System.Drawing.Point(383, 285);
            this.CreateAccount_label.Name = "CreateAccount_label";
            this.CreateAccount_label.Size = new System.Drawing.Size(106, 23);
            this.CreateAccount_label.TabIndex = 10;
            this.CreateAccount_label.Text = "Create an account";
            this.CreateAccount_label.Click += new System.EventHandler(this.CreateAccount_label_Click);
            this.CreateAccount_label.MouseEnter += new System.EventHandler(this.CreateAccount_label_MouseEnter);
            this.CreateAccount_label.MouseLeave += new System.EventHandler(this.CreateAccount_label_MouseLeave);
            // 
            // close_BTN
            // 
            this.close_BTN.Image = global::BookMeCinema.Properties.Resources.close;
            this.close_BTN.Location = new System.Drawing.Point(610, 10);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(12, 12);
            this.close_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_BTN.TabIndex = 11;
            this.close_BTN.TabStop = false;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // SignIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.close_BTN);
            this.Controls.Add(this.CreateAccount_label);
            this.Controls.Add(this.PasswordSI_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userLoginSI_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SignIn_BTN);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookMe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userLoginSI_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordSI_TB;
        private System.Windows.Forms.Label CreateAccount_label;
        private System.Windows.Forms.PictureBox close_BTN;
    }
}

