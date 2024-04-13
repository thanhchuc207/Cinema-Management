namespace GUI.MyUserControls
{
    partial class UCMoviePictureStaff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMoviePictureStaff));
            this.txtNameMovie = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnImageMovie = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // txtNameMovie
            // 
            this.txtNameMovie.BackColor = System.Drawing.Color.Transparent;
            this.txtNameMovie.BorderThickness = 0;
            this.txtNameMovie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameMovie.DefaultText = "Name Movie";
            this.txtNameMovie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMovie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMovie.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameMovie.ForeColor = System.Drawing.Color.Black;
            this.txtNameMovie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMovie.Location = new System.Drawing.Point(0, 300);
            this.txtNameMovie.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameMovie.Name = "txtNameMovie";
            this.txtNameMovie.PasswordChar = '\0';
            this.txtNameMovie.PlaceholderText = "";
            this.txtNameMovie.SelectedText = "";
            this.txtNameMovie.Size = new System.Drawing.Size(280, 50);
            this.txtNameMovie.TabIndex = 1;
            this.txtNameMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.btnImageMovie;
            // 
            // btnImageMovie
            // 
            this.btnImageMovie.BackColor = System.Drawing.Color.White;
            this.btnImageMovie.HoverState.ImageSize = new System.Drawing.Size(270, 277);
            this.btnImageMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnImageMovie.Image")));
            this.btnImageMovie.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnImageMovie.ImageRotate = 0F;
            this.btnImageMovie.ImageSize = new System.Drawing.Size(280, 287);
            this.btnImageMovie.Location = new System.Drawing.Point(3, 3);
            this.btnImageMovie.Name = "btnImageMovie";
            this.btnImageMovie.Size = new System.Drawing.Size(274, 290);
            this.btnImageMovie.TabIndex = 2;
            this.btnImageMovie.Click += new System.EventHandler(this.btnImageMovie_Click_1);
            // 
            // UCMoviePictureStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnImageMovie);
            this.Controls.Add(this.txtNameMovie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCMoviePictureStaff";
            this.Size = new System.Drawing.Size(280, 350);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtNameMovie;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnImageMovie;
    }
}
