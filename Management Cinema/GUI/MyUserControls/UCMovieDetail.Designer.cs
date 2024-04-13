namespace GUI.MyUserControls
{
    partial class UCMovieDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbMovieName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbLength = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.MoviePicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbbMovieGenre = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim";
            // 
            // tbMovieName
            // 
            this.tbMovieName.BorderColor = System.Drawing.Color.White;
            this.tbMovieName.BorderRadius = 10;
            this.tbMovieName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbMovieName.DefaultText = "";
            this.tbMovieName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMovieName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMovieName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMovieName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMovieName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMovieName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieName.ForeColor = System.Drawing.Color.DimGray;
            this.tbMovieName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMovieName.Location = new System.Drawing.Point(35, 60);
            this.tbMovieName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.PasswordChar = '\0';
            this.tbMovieName.PlaceholderText = "";
            this.tbMovieName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbMovieName.SelectedText = "";
            this.tbMovieName.Size = new System.Drawing.Size(327, 32);
            this.tbMovieName.TabIndex = 48;
            this.tbMovieName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "_____________________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(390, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 23);
            this.label15.TabIndex = 52;
            this.label15.Text = "Thể loại";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(387, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(266, 16);
            this.label16.TabIndex = 54;
            this.label16.Text = "_____________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 55;
            this.label4.Text = "Khởi chiếu";
            // 
            // tbDate
            // 
            this.tbDate.BorderColor = System.Drawing.Color.White;
            this.tbDate.BorderRadius = 10;
            this.tbDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbDate.DefaultText = "";
            this.tbDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.ForeColor = System.Drawing.Color.DimGray;
            this.tbDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDate.Location = new System.Drawing.Point(30, 160);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDate.Name = "tbDate";
            this.tbDate.PasswordChar = '\0';
            this.tbDate.PlaceholderText = "";
            this.tbDate.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDate.SelectedText = "";
            this.tbDate.Size = new System.Drawing.Size(141, 32);
            this.tbDate.TabIndex = 56;
            this.tbDate.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(34, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "___________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(270, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 23);
            this.label17.TabIndex = 58;
            this.label17.Text = "Thời lượng";
            // 
            // tbLength
            // 
            this.tbLength.BorderColor = System.Drawing.Color.White;
            this.tbLength.BorderRadius = 10;
            this.tbLength.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLength.DefaultText = "";
            this.tbLength.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLength.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLength.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLength.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLength.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLength.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLength.ForeColor = System.Drawing.Color.DimGray;
            this.tbLength.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLength.Location = new System.Drawing.Point(277, 160);
            this.tbLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLength.Name = "tbLength";
            this.tbLength.PasswordChar = '\0';
            this.tbLength.PlaceholderText = "";
            this.tbLength.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbLength.SelectedText = "";
            this.tbLength.Size = new System.Drawing.Size(53, 32);
            this.tbLength.TabIndex = 59;
            this.tbLength.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(274, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "_______________";
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox7.BorderRadius = 10;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2TextBox7.DefaultText = "phút";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox7.ForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Location = new System.Drawing.Point(324, 160);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "";
            this.guna2TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(59, 32);
            this.guna2TextBox7.TabIndex = 61;
            this.guna2TextBox7.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(500, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 23);
            this.label18.TabIndex = 62;
            this.label18.Text = "Giá vé";
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.White;
            this.tbPrice.BorderRadius = 10;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Location = new System.Drawing.Point(500, 160);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(80, 32);
            this.tbPrice.TabIndex = 63;
            this.tbPrice.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(501, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 16);
            this.label19.TabIndex = 64;
            this.label19.Text = "__________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 65;
            this.label8.Text = "Poster";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(255, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 23);
            this.label20.TabIndex = 67;
            this.label20.Text = "Mô tả";
            // 
            // tbDescription
            // 
            this.tbDescription.BorderColor = System.Drawing.Color.DimGray;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.DefaultText = "";
            this.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.DimGray;
            this.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.Location = new System.Drawing.Point(255, 260);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PlaceholderText = "";
            this.tbDescription.SelectedText = "";
            this.tbDescription.Size = new System.Drawing.Size(419, 226);
            this.tbDescription.TabIndex = 68;
            // 
            // MoviePicture
            // 
            this.MoviePicture.Location = new System.Drawing.Point(30, 260);
            this.MoviePicture.Name = "MoviePicture";
            this.MoviePicture.Size = new System.Drawing.Size(196, 226);
            this.MoviePicture.TabIndex = 69;
            this.MoviePicture.TabStop = false;
            this.MoviePicture.Click += new System.EventHandler(this.MoviePicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbbMovieGenre
            // 
            this.cbbMovieGenre.BackColor = System.Drawing.Color.Transparent;
            this.cbbMovieGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMovieGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieGenre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMovieGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMovieGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMovieGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbMovieGenre.ItemHeight = 30;
            this.cbbMovieGenre.Location = new System.Drawing.Point(390, 58);
            this.cbbMovieGenre.Name = "cbbMovieGenre";
            this.cbbMovieGenre.Size = new System.Drawing.Size(263, 36);
            this.cbbMovieGenre.TabIndex = 70;
            // 
            // UCMovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbbMovieGenre);
            this.Controls.Add(this.MoviePicture);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.guna2TextBox7);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label19);
            this.Name = "UCMovieDetail";
            this.Size = new System.Drawing.Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbMovieName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox tbLength;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2TextBox tbDescription;
        private System.Windows.Forms.PictureBox MoviePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMovieGenre;
    }
}
