
namespace BookMeCinema
{
    partial class MoviesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesList));
            this.close_BTN = new System.Windows.Forms.PictureBox();
            this.moviesList_FP = new System.Windows.Forms.FlowLayoutPanel();
            this.userLogin_LB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoText_LB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addMovie_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_BTN
            // 
            this.close_BTN.Image = global::BookMeCinema.Properties.Resources.close;
            this.close_BTN.Location = new System.Drawing.Point(610, 10);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(12, 12);
            this.close_BTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_BTN.TabIndex = 18;
            this.close_BTN.TabStop = false;
            this.close_BTN.Click += new System.EventHandler(this.close_BTN_Click);
            // 
            // moviesList_FP
            // 
            this.moviesList_FP.AutoScroll = true;
            this.moviesList_FP.Location = new System.Drawing.Point(26, 116);
            this.moviesList_FP.Name = "moviesList_FP";
            this.moviesList_FP.Size = new System.Drawing.Size(581, 309);
            this.moviesList_FP.TabIndex = 19;
            // 
            // userLogin_LB
            // 
            this.userLogin_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.userLogin_LB.Location = new System.Drawing.Point(159, 18);
            this.userLogin_LB.Name = "userLogin_LB";
            this.userLogin_LB.Size = new System.Drawing.Size(206, 20);
            this.userLogin_LB.TabIndex = 20;
            this.toolTip1.SetToolTip(this.userLogin_LB, "Logout");
            this.userLogin_LB.Click += new System.EventHandler(this.userLogin_LB_Click);
            this.userLogin_LB.MouseEnter += new System.EventHandler(this.userLogin_LB_MouseEnter);
            this.userLogin_LB.MouseLeave += new System.EventHandler(this.userLogin_LB_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // logoText_LB
            // 
            this.logoText_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.logoText_LB.Location = new System.Drawing.Point(58, 18);
            this.logoText_LB.Name = "logoText_LB";
            this.logoText_LB.Size = new System.Drawing.Size(102, 23);
            this.logoText_LB.TabIndex = 22;
            this.logoText_LB.Text = "Book Your Seats  | ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(265, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 43);
            this.label2.TabIndex = 23;
            this.label2.Text = "Movies List";
            // 
            // addMovie_BTN
            // 
            this.addMovie_BTN.BackColor = System.Drawing.Color.Transparent;
            this.addMovie_BTN.BackgroundImage = global::BookMeCinema.Properties.Resources.addico;
            this.addMovie_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addMovie_BTN.FlatAppearance.BorderSize = 0;
            this.addMovie_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addMovie_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addMovie_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMovie_BTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.addMovie_BTN.Location = new System.Drawing.Point(381, 63);
            this.addMovie_BTN.Name = "addMovie_BTN";
            this.addMovie_BTN.Size = new System.Drawing.Size(17, 17);
            this.addMovie_BTN.TabIndex = 24;
            this.toolTip1.SetToolTip(this.addMovie_BTN, "Add movie");
            this.addMovie_BTN.UseVisualStyleBackColor = false;
            this.addMovie_BTN.Click += new System.EventHandler(this.addMovie_BTN_Click);
            this.addMovie_BTN.MouseEnter += new System.EventHandler(this.addMovie_BTN_MouseEnter);
            this.addMovie_BTN.MouseLeave += new System.EventHandler(this.addMovie_BTN_MouseLeave);
            // 
            // MoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.addMovie_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoText_LB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userLogin_LB);
            this.Controls.Add(this.moviesList_FP);
            this.Controls.Add(this.close_BTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MoviesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoviesList";
            ((System.ComponentModel.ISupportInitialize)(this.close_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox close_BTN;
        private System.Windows.Forms.FlowLayoutPanel moviesList_FP;
        private System.Windows.Forms.Label userLogin_LB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logoText_LB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addMovie_BTN;
    }
}