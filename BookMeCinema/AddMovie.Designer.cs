
namespace BookMeCinema
{
    partial class AddMovie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.label2 = new System.Windows.Forms.Label();
            this.logoText_LB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userLogin_LB = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.close_BTN = new System.Windows.Forms.PictureBox();
            this.CancelAdd_BTN = new System.Windows.Forms.Button();
            this.SaveAdd_BT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieNameAdd_TB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Room3_CB = new System.Windows.Forms.RadioButton();
            this.Room2_CB = new System.Windows.Forms.RadioButton();
            this.Room1_CB = new System.Windows.Forms.RadioButton();
            this.MovieDateAdd_TB = new System.Windows.Forms.TextBox();
            this.MovieTimeAdd_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(228, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 43);
            this.label2.TabIndex = 24;
            this.label2.Text = "Add New Movie";
            // 
            // logoText_LB
            // 
            this.logoText_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.logoText_LB.Location = new System.Drawing.Point(58, 18);
            this.logoText_LB.Name = "logoText_LB";
            this.logoText_LB.Size = new System.Drawing.Size(102, 23);
            this.logoText_LB.TabIndex = 26;
            this.logoText_LB.Text = "Book Your Seats  | ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // userLogin_LB
            // 
            this.userLogin_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.userLogin_LB.Location = new System.Drawing.Point(159, 18);
            this.userLogin_LB.Name = "userLogin_LB";
            this.userLogin_LB.Size = new System.Drawing.Size(206, 20);
            this.userLogin_LB.TabIndex = 27;
            this.toolTip1.SetToolTip(this.userLogin_LB, "Logout");
            this.userLogin_LB.Click += new System.EventHandler(this.userLogin_LB_Click);
            this.userLogin_LB.MouseEnter += new System.EventHandler(this.userLogin_LB_MouseEnter);
            this.userLogin_LB.MouseLeave += new System.EventHandler(this.userLogin_LB_MouseLeave);
            // 
            // close_BTN
            // 
            this.close_BTN.Image = global::BookMeCinema.Properties.Resources.close;
            this.close_BTN.Location = new System.Drawing.Point(610, 10);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(12, 12);
            this.close_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_BTN.TabIndex = 28;
            this.close_BTN.TabStop = false;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // CancelAdd_BTN
            // 
            this.CancelAdd_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.CancelAdd_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelAdd_BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.CancelAdd_BTN.Location = new System.Drawing.Point(179, 357);
            this.CancelAdd_BTN.Name = "CancelAdd_BTN";
            this.CancelAdd_BTN.Size = new System.Drawing.Size(130, 35);
            this.CancelAdd_BTN.TabIndex = 37;
            this.CancelAdd_BTN.Text = "Cancel";
            this.CancelAdd_BTN.UseVisualStyleBackColor = false;
            this.CancelAdd_BTN.Click += new System.EventHandler(this.CancelAdd_BTN_Click);
            // 
            // SaveAdd_BT
            // 
            this.SaveAdd_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(0)))), ((int)(((byte)(176)))));
            this.SaveAdd_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveAdd_BT.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveAdd_BT.Location = new System.Drawing.Point(322, 357);
            this.SaveAdd_BT.Name = "SaveAdd_BT";
            this.SaveAdd_BT.Size = new System.Drawing.Size(130, 35);
            this.SaveAdd_BT.TabIndex = 36;
            this.SaveAdd_BT.Text = "Add";
            this.SaveAdd_BT.UseVisualStyleBackColor = false;
            this.SaveAdd_BT.Click += new System.EventHandler(this.SaveAdd_BT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(181, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Movie Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(181, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Movie Room:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(181, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Movie Name:";
            // 
            // MovieNameAdd_TB
            // 
            this.MovieNameAdd_TB.Location = new System.Drawing.Point(181, 139);
            this.MovieNameAdd_TB.Name = "MovieNameAdd_TB";
            this.MovieNameAdd_TB.Size = new System.Drawing.Size(273, 23);
            this.MovieNameAdd_TB.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Room3_CB);
            this.panel1.Controls.Add(this.Room2_CB);
            this.panel1.Controls.Add(this.Room1_CB);
            this.panel1.Location = new System.Drawing.Point(181, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 21);
            this.panel1.TabIndex = 41;
            // 
            // Room3_CB
            // 
            this.Room3_CB.AutoSize = true;
            this.Room3_CB.ForeColor = System.Drawing.SystemColors.Control;
            this.Room3_CB.Location = new System.Drawing.Point(195, 3);
            this.Room3_CB.Name = "Room3_CB";
            this.Room3_CB.Size = new System.Drawing.Size(66, 19);
            this.Room3_CB.TabIndex = 2;
            this.Room3_CB.Text = "Room 3";
            this.Room3_CB.UseVisualStyleBackColor = true;
            // 
            // Room2_CB
            // 
            this.Room2_CB.AutoSize = true;
            this.Room2_CB.ForeColor = System.Drawing.SystemColors.Control;
            this.Room2_CB.Location = new System.Drawing.Point(99, 3);
            this.Room2_CB.Name = "Room2_CB";
            this.Room2_CB.Size = new System.Drawing.Size(66, 19);
            this.Room2_CB.TabIndex = 1;
            this.Room2_CB.Text = "Room 2";
            this.Room2_CB.UseVisualStyleBackColor = true;
            // 
            // Room1_CB
            // 
            this.Room1_CB.AutoSize = true;
            this.Room1_CB.Checked = true;
            this.Room1_CB.ForeColor = System.Drawing.SystemColors.Control;
            this.Room1_CB.Location = new System.Drawing.Point(3, 3);
            this.Room1_CB.Name = "Room1_CB";
            this.Room1_CB.Size = new System.Drawing.Size(66, 19);
            this.Room1_CB.TabIndex = 0;
            this.Room1_CB.TabStop = true;
            this.Room1_CB.Text = "Room 1";
            this.Room1_CB.UseVisualStyleBackColor = true;
            // 
            // MovieDateAdd_TB
            // 
            this.MovieDateAdd_TB.Location = new System.Drawing.Point(181, 253);
            this.MovieDateAdd_TB.Name = "MovieDateAdd_TB";
            this.MovieDateAdd_TB.PlaceholderText = "YYYY-MM-DD HH:mm";
            this.MovieDateAdd_TB.Size = new System.Drawing.Size(273, 23);
            this.MovieDateAdd_TB.TabIndex = 43;
            // 
            // MovieTimeAdd_TB
            // 
            this.MovieTimeAdd_TB.Location = new System.Drawing.Point(181, 312);
            this.MovieTimeAdd_TB.Name = "MovieTimeAdd_TB";
            this.MovieTimeAdd_TB.PlaceholderText = "HH:mm";
            this.MovieTimeAdd_TB.Size = new System.Drawing.Size(273, 23);
            this.MovieTimeAdd_TB.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(181, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Movie Time:";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.MovieTimeAdd_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MovieDateAdd_TB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelAdd_BTN);
            this.Controls.Add(this.SaveAdd_BT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MovieNameAdd_TB);
            this.Controls.Add(this.close_BTN);
            this.Controls.Add(this.userLogin_LB);
            this.Controls.Add(this.logoText_LB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label logoText_LB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userLogin_LB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox close_BTN;
        private System.Windows.Forms.Button CancelAdd_BTN;
        private System.Windows.Forms.Button SaveAdd_BT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MovieNameAdd_TB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Room3_CB;
        private System.Windows.Forms.RadioButton Room2_CB;
        private System.Windows.Forms.RadioButton Room1_CB;
        private System.Windows.Forms.TextBox MovieDateAdd_TB;
        private System.Windows.Forms.TextBox MovieTimeAdd_TB;
        private System.Windows.Forms.Label label5;
    }
}