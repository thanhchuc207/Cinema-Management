namespace Guna3
{
    partial class FormSchedule
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbDatePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbMovieName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpkDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btSave = new Guna.UI2.WinForms.Guna2Button();
            this.cbbRoomName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btDelete);
            this.guna2Panel1.Controls.Add(this.dtpkTime);
            this.guna2Panel1.Controls.Add(this.guna2TextBox7);
            this.guna2Panel1.Controls.Add(this.tbDatePrice);
            this.guna2Panel1.Controls.Add(this.cbbMovieName);
            this.guna2Panel1.Controls.Add(this.dtpkDate);
            this.guna2Panel1.Controls.Add(this.btSave);
            this.guna2Panel1.Controls.Add(this.cbbRoomName);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(700, 350);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.BorderRadius = 10;
            this.btDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDelete.FillColor = System.Drawing.Color.OrangeRed;
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(383, 268);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 45);
            this.btDelete.TabIndex = 65;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dtpkTime
            // 
            this.dtpkTime.Checked = true;
            this.dtpkTime.CustomFormat = "hh:mm:ss";
            this.dtpkTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkTime.Location = new System.Drawing.Point(504, 190);
            this.dtpkTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkTime.Name = "dtpkTime";
            this.dtpkTime.ShowUpDown = true;
            this.dtpkTime.Size = new System.Drawing.Size(161, 36);
            this.dtpkTime.TabIndex = 64;
            this.dtpkTime.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox7.BorderRadius = 10;
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2TextBox7.DefaultText = "%";
            this.guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox7.ForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox7.Location = new System.Drawing.Point(316, 194);
            this.guna2TextBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "";
            this.guna2TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(41, 32);
            this.guna2TextBox7.TabIndex = 63;
            this.guna2TextBox7.TabStop = false;
            // 
            // tbDatePrice
            // 
            this.tbDatePrice.BorderColor = System.Drawing.Color.White;
            this.tbDatePrice.BorderRadius = 10;
            this.tbDatePrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbDatePrice.DefaultText = "";
            this.tbDatePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDatePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDatePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDatePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDatePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDatePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatePrice.ForeColor = System.Drawing.Color.DimGray;
            this.tbDatePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDatePrice.Location = new System.Drawing.Point(265, 194);
            this.tbDatePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDatePrice.MaxLength = 3;
            this.tbDatePrice.Name = "tbDatePrice";
            this.tbDatePrice.PasswordChar = '\0';
            this.tbDatePrice.PlaceholderText = "";
            this.tbDatePrice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDatePrice.SelectedText = "";
            this.tbDatePrice.Size = new System.Drawing.Size(53, 32);
            this.tbDatePrice.TabIndex = 61;
            this.tbDatePrice.TabStop = false;
            this.tbDatePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbMovieName
            // 
            this.cbbMovieName.BackColor = System.Drawing.Color.Transparent;
            this.cbbMovieName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbMovieName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMovieName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbMovieName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbMovieName.ItemHeight = 30;
            this.cbbMovieName.Location = new System.Drawing.Point(35, 80);
            this.cbbMovieName.Name = "cbbMovieName";
            this.cbbMovieName.Size = new System.Drawing.Size(423, 36);
            this.cbbMovieName.TabIndex = 49;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Checked = true;
            this.dtpkDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDate.Location = new System.Drawing.Point(39, 190);
            this.dtpkDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpkDate.MinDate = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(162, 36);
            this.dtpkDate.TabIndex = 48;
            this.dtpkDate.Value = new System.DateTime(2023, 6, 11, 0, 0, 0, 0);
            // 
            // btSave
            // 
            this.btSave.BorderRadius = 10;
            this.btSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(206, 268);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(90, 45);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbbRoomName
            // 
            this.cbbRoomName.BackColor = System.Drawing.Color.Transparent;
            this.cbbRoomName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRoomName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoomName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbRoomName.ItemHeight = 30;
            this.cbbRoomName.Location = new System.Drawing.Point(500, 80);
            this.cbbRoomName.Name = "cbbRoomName";
            this.cbbRoomName.Size = new System.Drawing.Size(137, 36);
            this.cbbRoomName.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Phụ thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Phòng chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "Thời gian bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày chiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên phim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 28);
            this.label7.TabIndex = 48;
            this.label7.Text = "Thông tin suất chiếu";
            // 
            // btClose
            // 
            this.btClose.Image = global::GUI.Properties.Resources.icons8_multiply_50;
            this.btClose.Location = new System.Drawing.Point(658, 10);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 49;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 26;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemSuatChieu";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRoomName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btClose;
        private Guna.UI2.WinForms.Guna2ComboBox cbbMovieName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkDate;
        private Guna.UI2.WinForms.Guna2TextBox tbDatePrice;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkTime;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
        private Guna.UI2.WinForms.Guna2Button btDelete;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}