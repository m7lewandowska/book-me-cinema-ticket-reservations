
namespace BookMeCinema
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HaveAccount_label = new System.Windows.Forms.Label();
            this.PasswordSU_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userLoginSU_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignUp_BTN = new System.Windows.Forms.Button();
            this.close_BTN = new System.Windows.Forms.PictureBox();
            this.IsWorker_CB = new System.Windows.Forms.CheckBox();
            this.PinCode_TB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 450);
            this.panel1.TabIndex = 5;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(304, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign Up";
            // 
            // HaveAccount_label
            // 
            this.HaveAccount_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.HaveAccount_label.Location = new System.Drawing.Point(366, 333);
            this.HaveAccount_label.Name = "HaveAccount_label";
            this.HaveAccount_label.Size = new System.Drawing.Size(149, 23);
            this.HaveAccount_label.TabIndex = 16;
            this.HaveAccount_label.Text = "I already have an account";
            this.HaveAccount_label.Click += new System.EventHandler(this.HaveAccount_label_Click);
            this.HaveAccount_label.MouseEnter += new System.EventHandler(this.HaveAccount_label_MouseEnter);
            this.HaveAccount_label.MouseLeave += new System.EventHandler(this.HaveAccount_label_MouseLeave);
            // 
            // PasswordSU_TB
            // 
            this.PasswordSU_TB.Location = new System.Drawing.Point(304, 247);
            this.PasswordSU_TB.Name = "PasswordSU_TB";
            this.PasswordSU_TB.PasswordChar = '*';
            this.PasswordSU_TB.Size = new System.Drawing.Size(269, 23);
            this.PasswordSU_TB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(304, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // userLoginSU_TB
            // 
            this.userLoginSU_TB.Location = new System.Drawing.Point(304, 168);
            this.userLoginSU_TB.Name = "userLoginSU_TB";
            this.userLoginSU_TB.Size = new System.Drawing.Size(269, 23);
            this.userLoginSU_TB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(304, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login:";
            // 
            // SignUp_BTN
            // 
            this.SignUp_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.SignUp_BTN.FlatAppearance.BorderSize = 0;
            this.SignUp_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignUp_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.SignUp_BTN.Location = new System.Drawing.Point(383, 375);
            this.SignUp_BTN.Name = "SignUp_BTN";
            this.SignUp_BTN.Size = new System.Drawing.Size(109, 37);
            this.SignUp_BTN.TabIndex = 11;
            this.SignUp_BTN.Text = "SIGN UP";
            this.SignUp_BTN.UseVisualStyleBackColor = false;
            this.SignUp_BTN.Click += new System.EventHandler(this.SignUp_BTN_Click);
            // 
            // close_BTN
            // 
            this.close_BTN.Image = global::BookMeCinema.Properties.Resources.close;
            this.close_BTN.Location = new System.Drawing.Point(610, 10);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(12, 12);
            this.close_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_BTN.TabIndex = 17;
            this.close_BTN.TabStop = false;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // IsWorker_CB
            // 
            this.IsWorker_CB.AutoSize = true;
            this.IsWorker_CB.ForeColor = System.Drawing.SystemColors.Control;
            this.IsWorker_CB.Location = new System.Drawing.Point(304, 288);
            this.IsWorker_CB.Name = "IsWorker_CB";
            this.IsWorker_CB.Size = new System.Drawing.Size(112, 19);
            this.IsWorker_CB.TabIndex = 18;
            this.IsWorker_CB.Text = "Worker Account";
            this.IsWorker_CB.UseVisualStyleBackColor = true;
            this.IsWorker_CB.CheckedChanged += new System.EventHandler(this.IsWorker_CB_CheckedChanged);
            // 
            // PinCode_TB
            // 
            this.PinCode_TB.Location = new System.Drawing.Point(434, 288);
            this.PinCode_TB.Name = "PinCode_TB";
            this.PinCode_TB.PasswordChar = '*';
            this.PinCode_TB.PlaceholderText = "Enter pin code";
            this.PinCode_TB.Size = new System.Drawing.Size(139, 23);
            this.PinCode_TB.TabIndex = 19;
            this.PinCode_TB.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.PinCode_TB);
            this.Controls.Add(this.IsWorker_CB);
            this.Controls.Add(this.close_BTN);
            this.Controls.Add(this.HaveAccount_label);
            this.Controls.Add(this.PasswordSU_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userLoginSU_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUp_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HaveAccount_label;
        private System.Windows.Forms.TextBox PasswordSU_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userLoginSU_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignUp_BTN;
        private System.Windows.Forms.PictureBox close_BTN;
        private System.Windows.Forms.CheckBox IsWorker_CB;
        private System.Windows.Forms.TextBox PinCode_TB;
    }
}