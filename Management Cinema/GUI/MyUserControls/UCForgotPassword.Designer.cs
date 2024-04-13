namespace GUI.MyUserControls
{
    partial class UCForgotPassword
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSendMail = new Guna.UI2.WinForms.Guna2Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtEmail = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblNotification = new Guna.UI.WinForms.GunaLabel();
            this.btBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BorderColor = System.Drawing.Color.Gray;
            this.pnMain.BorderRadius = 20;
            this.pnMain.BorderThickness = 1;
            this.pnMain.Controls.Add(this.lblTitle);
            this.pnMain.Controls.Add(this.btnSendMail);
            this.pnMain.Controls.Add(this.lblResult);
            this.pnMain.Controls.Add(this.gunaPictureBox1);
            this.pnMain.Controls.Add(this.txtEmail);
            this.pnMain.Controls.Add(this.lblNotification);
            this.pnMain.Controls.Add(this.btBack);
            this.pnMain.Location = new System.Drawing.Point(25, 58);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(716, 644);
            this.pnMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblTitle.Location = new System.Drawing.Point(90, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 62);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Khôi phục mật khẩu";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BorderRadius = 20;
            this.btnSendMail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnSendMail.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnSendMail.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btnSendMail.HoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendMail.Location = new System.Drawing.Point(378, 539);
            this.btnSendMail.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(212, 56);
            this.btnSendMail.TabIndex = 8;
            this.btnSendMail.Text = "Gửi mã";
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(181, 295);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(399, 22);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Không tìm thấy tài khoản liên kết với email trên";
            this.lblResult.Visible = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::GUI.Properties.Resources.icons8_mail_50;
            this.gunaPictureBox1.Location = new System.Drawing.Point(128, 229);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedLineColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.LineColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(185, 235);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(405, 51);
            this.txtEmail.TabIndex = 4;
            // 
            // lblNotification
            // 
            this.lblNotification.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNotification.Location = new System.Drawing.Point(128, 369);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(462, 150);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "Chúng tôi sẽ gửi lại mã xác nhận thông qua email liên kết với tài khoản trên";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.Transparent;
            this.btBack.BorderRadius = 20;
            this.btBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBack.FillColor = System.Drawing.Color.Transparent;
            this.btBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.btBack.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btBack.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btBack.Image = global::GUI.Properties.Resources.icons8_back_501;
            this.btBack.ImageSize = new System.Drawing.Size(50, 50);
            this.btBack.Location = new System.Drawing.Point(15, 12);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(50, 50);
            this.btBack.TabIndex = 1;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // UCForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCForgotPassword";
            this.Size = new System.Drawing.Size(769, 769);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btBack;
        private Guna.UI.WinForms.GunaLabel lblNotification;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtEmail;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI2.WinForms.Guna2Button btnSendMail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}
