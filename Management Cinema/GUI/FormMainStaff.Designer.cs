namespace GUI
{
    partial class FormMainStaff
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btReceipt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfor = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnMovie = new Guna.UI2.WinForms.Guna2Button();
            this.pnView = new Guna.UI2.WinForms.Guna2Panel();
            this.pnIcon = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            this.pnIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.pnMain.Controls.Add(this.guna2Button2);
            this.pnMain.Controls.Add(this.btReceipt);
            this.pnMain.Controls.Add(this.guna2Button1);
            this.pnMain.Controls.Add(this.btnInfor);
            this.pnMain.Controls.Add(this.btnCustomer);
            this.pnMain.Controls.Add(this.btnMovie);
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(325, 899);
            this.pnMain.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::GUI.Properties.Resources.Blue_Cute_Certificate_Of_Kindergarten_Graduation_removebg_preview;
            this.guna2Button2.ImageSize = new System.Drawing.Size(200, 120);
            this.guna2Button2.Location = new System.Drawing.Point(15, 14);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Size = new System.Drawing.Size(292, 62);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btReceipt
            // 
            this.btReceipt.BorderRadius = 20;
            this.btReceipt.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btReceipt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btReceipt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btReceipt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btReceipt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btReceipt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btReceipt.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReceipt.ForeColor = System.Drawing.Color.White;
            this.btReceipt.Image = global::GUI.Properties.Resources.icons8_bill_50;
            this.btReceipt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btReceipt.ImageSize = new System.Drawing.Size(50, 50);
            this.btReceipt.Location = new System.Drawing.Point(11, 342);
            this.btReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btReceipt.Name = "btReceipt";
            this.btReceipt.Size = new System.Drawing.Size(235, 56);
            this.btReceipt.TabIndex = 20;
            this.btReceipt.Text = "Hóa đơn";
            this.btReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btReceipt.Click += new System.EventHandler(this.btReceipt_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::GUI.Properties.Resources.icons8_logout_32;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2Button1.Location = new System.Drawing.Point(15, 565);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(231, 51);
            this.guna2Button1.TabIndex = 15;
            this.guna2Button1.Text = "Đăng xuất";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnInfor
            // 
            this.btnInfor.BorderRadius = 20;
            this.btnInfor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInfor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btnInfor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInfor.ForeColor = System.Drawing.Color.White;
            this.btnInfor.Image = global::GUI.Properties.Resources.icons8_edit_user_48;
            this.btnInfor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfor.ImageSize = new System.Drawing.Size(50, 50);
            this.btnInfor.Location = new System.Drawing.Point(15, 462);
            this.btnInfor.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(238, 51);
            this.btnInfor.TabIndex = 14;
            this.btnInfor.Text = "Tài khoản";
            this.btnInfor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BorderRadius = 20;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btnCustomer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::GUI.Properties.Resources.human_care_50;
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCustomer.Location = new System.Drawing.Point(12, 228);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(274, 56);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click_1);
            // 
            // btnMovie
            // 
            this.btnMovie.BorderRadius = 20;
            this.btnMovie.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btnMovie.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.White;
            this.btnMovie.Image = global::GUI.Properties.Resources.clapperboard_50;
            this.btnMovie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMovie.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMovie.Location = new System.Drawing.Point(15, 120);
            this.btnMovie.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(271, 54);
            this.btnMovie.TabIndex = 8;
            this.btnMovie.Text = "Phim";
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click_1);
            // 
            // pnView
            // 
            this.pnView.BackColor = System.Drawing.SystemColors.Control;
            this.pnView.BorderColor = System.Drawing.Color.Gray;
            this.pnView.Location = new System.Drawing.Point(332, 65);
            this.pnView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(1238, 819);
            this.pnView.TabIndex = 6;
            // 
            // pnIcon
            // 
            this.pnIcon.BackColor = System.Drawing.Color.White;
            this.pnIcon.Controls.Add(this.btnClose);
            this.pnIcon.Location = new System.Drawing.Point(332, 0);
            this.pnIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnIcon.Name = "pnIcon";
            this.pnIcon.Size = new System.Drawing.Size(1249, 58);
            this.pnIcon.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 15;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.LightGray;
            this.btnClose.HoverState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Image = global::GUI.Properties.Resources.icons8_multiply_50;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(1174, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1585, 899);
            this.Controls.Add(this.pnIcon);
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.pnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainStaff";
            this.pnMain.ResumeLayout(false);
            this.pnIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel pnIcon;
        private Guna.UI2.WinForms.Guna2Panel pnView;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Button btClose;
        private Guna.UI2.WinForms.Guna2Button btnMovie;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnInfor;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btReceipt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}