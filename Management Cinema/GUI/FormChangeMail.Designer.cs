namespace GUI
{
    partial class FormChangeMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVerification = new System.Windows.Forms.Label();
            this.txtOldEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtVerification = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblResultEmail = new System.Windows.Forms.Label();
            this.btnSendEmail = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(127, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(127, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email mới";
            // 
            // lblVerification
            // 
            this.lblVerification.AutoSize = true;
            this.lblVerification.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVerification.Location = new System.Drawing.Point(127, 216);
            this.lblVerification.Name = "lblVerification";
            this.lblVerification.Size = new System.Drawing.Size(138, 24);
            this.lblVerification.TabIndex = 1;
            this.lblVerification.Text = "Mã xác nhận";
            this.lblVerification.Visible = false;
            // 
            // txtOldEmail
            // 
            this.txtOldEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldEmail.DefaultText = "";
            this.txtOldEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOldEmail.ForeColor = System.Drawing.Color.Black;
            this.txtOldEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldEmail.Location = new System.Drawing.Point(290, 32);
            this.txtOldEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOldEmail.Name = "txtOldEmail";
            this.txtOldEmail.PasswordChar = '\0';
            this.txtOldEmail.PlaceholderText = "";
            this.txtOldEmail.ReadOnly = true;
            this.txtOldEmail.SelectedText = "";
            this.txtOldEmail.Size = new System.Drawing.Size(318, 43);
            this.txtOldEmail.TabIndex = 2;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewEmail.DefaultText = "";
            this.txtNewEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewEmail.ForeColor = System.Drawing.Color.Black;
            this.txtNewEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewEmail.Location = new System.Drawing.Point(290, 110);
            this.txtNewEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.PasswordChar = '\0';
            this.txtNewEmail.PlaceholderText = "";
            this.txtNewEmail.SelectedText = "";
            this.txtNewEmail.Size = new System.Drawing.Size(318, 43);
            this.txtNewEmail.TabIndex = 2;
            this.txtNewEmail.TextChanged += new System.EventHandler(this.txtNewEmail_TextChanged);
            // 
            // txtVerification
            // 
            this.txtVerification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVerification.DefaultText = "";
            this.txtVerification.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVerification.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVerification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerification.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVerification.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerification.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtVerification.ForeColor = System.Drawing.Color.Black;
            this.txtVerification.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVerification.Location = new System.Drawing.Point(290, 202);
            this.txtVerification.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtVerification.Name = "txtVerification";
            this.txtVerification.PasswordChar = '\0';
            this.txtVerification.PlaceholderText = "";
            this.txtVerification.SelectedText = "";
            this.txtVerification.Size = new System.Drawing.Size(318, 43);
            this.txtVerification.TabIndex = 3;
            this.txtVerification.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 13;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.HoverState.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Location = new System.Drawing.Point(636, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblResultEmail
            // 
            this.lblResultEmail.AutoSize = true;
            this.lblResultEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultEmail.ForeColor = System.Drawing.Color.Red;
            this.lblResultEmail.Location = new System.Drawing.Point(287, 157);
            this.lblResultEmail.Name = "lblResultEmail";
            this.lblResultEmail.Size = new System.Drawing.Size(240, 16);
            this.lblResultEmail.TabIndex = 11;
            this.lblResultEmail.Text = "Vui lòng nhập đúng định dạng Email";
            this.lblResultEmail.Visible = false;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BorderRadius = 13;
            this.btnSendEmail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendEmail.FillColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnSendEmail.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.HoverState.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendEmail.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendEmail.Location = new System.Drawing.Point(636, 111);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(109, 42);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Gửi mã";
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(287, 249);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 16);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Chúng tôi đã gửi mã xác nhận đến Email mới bạn vui lòng kiểm tra";
            this.lblTitle.Visible = false;
            // 
            // FormChangeMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 376);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblResultEmail);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtVerification);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.txtOldEmail);
            this.Controls.Add(this.lblVerification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChangeMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVerification;
        private Guna.UI2.WinForms.Guna2TextBox txtOldEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtNewEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtVerification;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblResultEmail;
        private Guna.UI2.WinForms.Guna2Button btnSendEmail;
        private System.Windows.Forms.Label lblTitle;
    }
}