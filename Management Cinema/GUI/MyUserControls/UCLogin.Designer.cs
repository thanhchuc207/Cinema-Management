namespace GUI.MyUserControls
{
    partial class UCLogin
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
            this.pnLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btViewPass = new Guna.UI2.WinForms.Guna2Button();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pbPass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassWord = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtUser = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogin
            // 
            this.pnLogin.BorderColor = System.Drawing.Color.Gray;
            this.pnLogin.BorderRadius = 20;
            this.pnLogin.BorderThickness = 1;
            this.pnLogin.Controls.Add(this.guna2HtmlLabel1);
            this.pnLogin.Controls.Add(this.btViewPass);
            this.pnLogin.Controls.Add(this.lblWelcome);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Controls.Add(this.lbForgotPassword);
            this.pnLogin.Controls.Add(this.lblResult);
            this.pnLogin.Controls.Add(this.pbPass);
            this.pnLogin.Controls.Add(this.pbLogin);
            this.pnLogin.Controls.Add(this.txtPassWord);
            this.pnLogin.Controls.Add(this.txtUser);
            this.pnLogin.Location = new System.Drawing.Point(20, 46);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(573, 515);
            this.pnLogin.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(151, 100);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(394, 70);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "đã quay trở lại";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btViewPass
            // 
            this.btViewPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btViewPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btViewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btViewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btViewPass.FillColor = System.Drawing.Color.White;
            this.btViewPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btViewPass.ForeColor = System.Drawing.Color.White;
            this.btViewPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btViewPass.Image = global::GUI.Properties.Resources.icons8_eye_48;
            this.btViewPass.ImageSize = new System.Drawing.Size(25, 25);
            this.btViewPass.Location = new System.Drawing.Point(497, 310);
            this.btViewPass.Margin = new System.Windows.Forms.Padding(2);
            this.btViewPass.Name = "btViewPass";
            this.btViewPass.Size = new System.Drawing.Size(30, 30);
            this.btViewPass.TabIndex = 38;
            this.btViewPass.Click += new System.EventHandler(this.btViewPass_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblWelcome.Location = new System.Drawing.Point(22, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(390, 70);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Chào mừng bạn";
            this.lblWelcome.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.HoverState.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(132, 440);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(340, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(255)))));
            this.lbForgotPassword.Location = new System.Drawing.Point(269, 375);
            this.lbForgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(203, 35);
            this.lbForgotPassword.TabIndex = 1;
            this.lbForgotPassword.Text = "Quên mật khẩu";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(165, 343);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(312, 17);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            // 
            // pbPass
            // 
            this.pbPass.Image = global::GUI.Properties.Resources.icons8_lock_30;
            this.pbPass.ImageRotate = 0F;
            this.pbPass.Location = new System.Drawing.Point(132, 295);
            this.pbPass.Margin = new System.Windows.Forms.Padding(2);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(30, 30);
            this.pbPass.TabIndex = 5;
            this.pbPass.TabStop = false;
            // 
            // pbLogin
            // 
            this.pbLogin.Image = global::GUI.Properties.Resources.icons8_user_30;
            this.pbLogin.ImageRotate = 0F;
            this.pbLogin.Location = new System.Drawing.Point(132, 204);
            this.pbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(30, 30);
            this.pbLogin.TabIndex = 4;
            this.pbLogin.TabStop = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.White;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.FocusedLineColor = System.Drawing.SystemColors.Highlight;
            this.txtPassWord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassWord.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPassWord.Location = new System.Drawing.Point(168, 293);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(303, 41);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedLineColor = System.Drawing.SystemColors.Highlight;
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUser.LineColor = System.Drawing.Color.Gainsboro;
            this.txtUser.Location = new System.Drawing.Point(168, 202);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(303, 41);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(615, 615);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogin;
        private Guna.UI.WinForms.GunaLineTextBox txtPassWord;
        private Guna.UI.WinForms.GunaLineTextBox txtUser;
        private Guna.UI2.WinForms.Guna2PictureBox pbPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btViewPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
