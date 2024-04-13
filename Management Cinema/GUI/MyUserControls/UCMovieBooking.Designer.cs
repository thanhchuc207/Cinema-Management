namespace GUI.MyUserControls
{
    partial class UCMovieBooking
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
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.cbbGenges = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnMovie = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btReload = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 17);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(237, 32);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Phim đang chiếu";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.LineColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Location = new System.Drawing.Point(59, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(285, 37);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Tìm kiếm phim";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.gunaLineTextBox1_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // cbbGenges
            // 
            this.cbbGenges.BackColor = System.Drawing.Color.Transparent;
            this.cbbGenges.BorderThickness = 0;
            this.cbbGenges.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGenges.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenges.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGenges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGenges.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbGenges.ForeColor = System.Drawing.Color.DimGray;
            this.cbbGenges.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.cbbGenges.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.cbbGenges.HoverState.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbGenges.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbbGenges.ItemHeight = 30;
            this.cbbGenges.Items.AddRange(new object[] {
            "Tat ca"});
            this.cbbGenges.Location = new System.Drawing.Point(368, 75);
            this.cbbGenges.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGenges.Name = "cbbGenges";
            this.cbbGenges.Size = new System.Drawing.Size(219, 36);
            this.cbbGenges.TabIndex = 4;
            this.cbbGenges.SelectedIndexChanged += new System.EventHandler(this.cbbGenges_SelectedIndexChanged);
            // 
            // pnMovie
            // 
            this.pnMovie.AutoScroll = true;
            this.pnMovie.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.pnMovie.Location = new System.Drawing.Point(0, 117);
            this.pnMovie.Margin = new System.Windows.Forms.Padding(2);
            this.pnMovie.Name = "pnMovie";
            this.pnMovie.Size = new System.Drawing.Size(980, 533);
            this.pnMovie.TabIndex = 6;
            // 
            // guna2Button1
            // 
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Silver;
            this.guna2Button1.Image = global::GUI.Properties.Resources.icons8_search_241;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(22, 75);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(32, 32);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btReload
            // 
            this.btReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReload.FillColor = System.Drawing.Color.White;
            this.btReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btReload.ForeColor = System.Drawing.Color.White;
            this.btReload.Image = global::GUI.Properties.Resources.icons8_reload_30;
            this.btReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btReload.Location = new System.Drawing.Point(602, 75);
            this.btReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(32, 32);
            this.btReload.TabIndex = 9;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // UCMovieBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pnMovie);
            this.Controls.Add(this.cbbGenges);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCMovieBooking";
            this.Size = new System.Drawing.Size(980, 650);
            this.Load += new System.EventHandler(this.UCMovieBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGenges;
        private Guna.UI2.WinForms.Guna2Panel pnMovie;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btReload;
    }
}
