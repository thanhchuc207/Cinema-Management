namespace GUI.MyUserControls
{
    partial class UCVerification
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtVerification = new Guna.UI.WinForms.GunaLineTextBox();
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
            this.pnMain.Controls.Add(this.btnSave);
            this.pnMain.Controls.Add(this.lblResult);
            this.pnMain.Controls.Add(this.gunaPictureBox1);
            this.pnMain.Controls.Add(this.txtVerification);
            this.pnMain.Controls.Add(this.lblNotification);
            this.pnMain.Controls.Add(this.btBack);
            this.pnMain.Location = new System.Drawing.Point(26, 62);
            this.pnMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(729, 656);
            this.pnMain.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(123)))), ((int)(((byte)(187)))));
            this.lblTitle.Location = new System.Drawing.Point(90, 95);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(564, 62);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Khôi phục mật khẩu";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnSave.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btnSave.HoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.Font = new System.Drawing.Font("Cambria", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(362, 522);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 56);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Xác nhận";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(206, 302);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(398, 22);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Mã xác nhận không chính xác, vui lòng nhập lại";
            this.lblResult.Visible = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::GUI.Properties.Resources.icons8_lock_301;
            this.gunaPictureBox1.Location = new System.Drawing.Point(152, 231);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // txtVerification
            // 
            this.txtVerification.BackColor = System.Drawing.Color.White;
            this.txtVerification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerification.FocusedLineColor = System.Drawing.SystemColors.Highlight;
            this.txtVerification.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtVerification.LineColor = System.Drawing.Color.Gainsboro;
            this.txtVerification.Location = new System.Drawing.Point(211, 235);
            this.txtVerification.Margin = new System.Windows.Forms.Padding(2);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.PasswordChar = '*';
            this.txtVerification.SelectedText = "";
            this.txtVerification.Size = new System.Drawing.Size(379, 51);
            this.txtVerification.TabIndex = 4;
            // 
            // lblNotification
            // 
            this.lblNotification.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.lblNotification.Location = new System.Drawing.Point(145, 380);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(522, 40);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "Nhập mã xác nhận đã gửi qua email";
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
            this.btBack.HoverState.BorderColor = System.Drawing.Color.LightGray;
            this.btBack.HoverState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btBack.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.btBack.Image = global::GUI.Properties.Resources.icons8_back_501;
            this.btBack.ImageSize = new System.Drawing.Size(50, 50);
            this.btBack.Location = new System.Drawing.Point(15, 14);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(50, 50);
            this.btBack.TabIndex = 1;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // UCVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCVerification";
            this.Size = new System.Drawing.Size(781, 781);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtVerification;
        private Guna.UI.WinForms.GunaLabel lblNotification;
        private Guna.UI2.WinForms.Guna2Button btBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}
