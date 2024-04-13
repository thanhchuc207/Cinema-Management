namespace GUI
{
    partial class FormEditCustomer
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
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResultAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResultBirthday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResultName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblResultPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpBirthday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPhone = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtAddress = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNameCustomer = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtIdCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIdCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNameBirthday = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNameCustomer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Thông tin khách hàng";
            // 
            // lblResultAddress
            // 
            this.lblResultAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblResultAddress.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultAddress.ForeColor = System.Drawing.Color.Red;
            this.lblResultAddress.Location = new System.Drawing.Point(264, 310);
            this.lblResultAddress.Name = "lblResultAddress";
            this.lblResultAddress.Size = new System.Drawing.Size(313, 17);
            this.lblResultAddress.TabIndex = 37;
            this.lblResultAddress.Text = "Địa chỉ không được chứa kí tự đặc biệt. Vui lòng nhập lại";
            this.lblResultAddress.Visible = false;
            // 
            // lblResultBirthday
            // 
            this.lblResultBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblResultBirthday.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultBirthday.ForeColor = System.Drawing.Color.Red;
            this.lblResultBirthday.Location = new System.Drawing.Point(264, 245);
            this.lblResultBirthday.Name = "lblResultBirthday";
            this.lblResultBirthday.Size = new System.Drawing.Size(247, 17);
            this.lblResultBirthday.TabIndex = 38;
            this.lblResultBirthday.Text = "Ngày sinh không được lớn hơn ngày hiện tại.";
            this.lblResultBirthday.Visible = false;
            // 
            // lblResultName
            // 
            this.lblResultName.BackColor = System.Drawing.Color.Transparent;
            this.lblResultName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultName.ForeColor = System.Drawing.Color.Red;
            this.lblResultName.Location = new System.Drawing.Point(264, 174);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(447, 17);
            this.lblResultName.TabIndex = 39;
            this.lblResultName.Text = "Họ và tên chỉ gồm chữ cái không được có số và các kí tự đặc biệt. Vui lòng nhập l" +
    "ại";
            this.lblResultName.Visible = false;
            // 
            // lblResultPhone
            // 
            this.lblResultPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblResultPhone.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResultPhone.ForeColor = System.Drawing.Color.Red;
            this.lblResultPhone.Location = new System.Drawing.Point(264, 378);
            this.lblResultPhone.Name = "lblResultPhone";
            this.lblResultPhone.Size = new System.Drawing.Size(341, 17);
            this.lblResultPhone.TabIndex = 40;
            this.lblResultPhone.Text = "Số điện thoại phải là chữ số và gồm có 10 số. Vui Lòng nhập lại";
            this.lblResultPhone.Visible = false;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BackColor = System.Drawing.Color.White;
            this.dtpBirthday.Checked = true;
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.FillColor = System.Drawing.Color.White;
            this.dtpBirthday.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(264, 203);
            this.dtpBirthday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(236, 36);
            this.dtpBirthday.TabIndex = 36;
            this.dtpBirthday.Value = new System.DateTime(2023, 5, 9, 22, 17, 34, 940);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            this.dtpBirthday.Leave += new System.EventHandler(this.dtpBirthday_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPhone.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhone.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPhone.LineColor = System.Drawing.Color.Gainsboro;
            this.txtPhone.Location = new System.Drawing.Point(264, 343);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(351, 35);
            this.txtPhone.TabIndex = 33;
            this.txtPhone.Text = "Nhập số điện thoại";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAddress.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAddress.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAddress.LineColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.Location = new System.Drawing.Point(264, 275);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(351, 35);
            this.txtAddress.TabIndex = 34;
            this.txtAddress.Text = "Nhập địa chỉ";
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.BackColor = System.Drawing.Color.White;
            this.txtNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCustomer.FocusedLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNameCustomer.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNameCustomer.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNameCustomer.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNameCustomer.Location = new System.Drawing.Point(264, 139);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.Size = new System.Drawing.Size(351, 35);
            this.txtNameCustomer.TabIndex = 35;
            this.txtNameCustomer.Text = "Nhập họ và tên";
            this.txtNameCustomer.Enter += new System.EventHandler(this.txtNameCustomer_Enter);
            this.txtNameCustomer.Leave += new System.EventHandler(this.txtNameCustomer_Leave);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.BorderColor = System.Drawing.Color.White;
            this.txtIdCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdCustomer.DefaultText = "";
            this.txtIdCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtIdCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdCustomer.Location = new System.Drawing.Point(73, 85);
            this.txtIdCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.PasswordChar = '\0';
            this.txtIdCustomer.PlaceholderText = "";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.SelectedText = "";
            this.txtIdCustomer.Size = new System.Drawing.Size(111, 29);
            this.txtIdCustomer.TabIndex = 32;
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCustomer.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIdCustomer.Location = new System.Drawing.Point(25, 84);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(23, 29);
            this.lblIdCustomer.TabIndex = 27;
            this.lblIdCustomer.Text = "Id";
            // 
            // lblNameBirthday
            // 
            this.lblNameBirthday.AutoSize = false;
            this.lblNameBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblNameBirthday.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBirthday.Location = new System.Drawing.Point(75, 210);
            this.lblNameBirthday.Name = "lblNameBirthday";
            this.lblNameBirthday.Size = new System.Drawing.Size(109, 24);
            this.lblNameBirthday.TabIndex = 28;
            this.lblNameBirthday.Text = "Ngày sinh";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = false;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.lblPhone.Location = new System.Drawing.Point(75, 343);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(139, 24);
            this.lblPhone.TabIndex = 29;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = false;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.lblAddress.Location = new System.Drawing.Point(75, 275);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(109, 24);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = false;
            this.lblNameCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblNameCustomer.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(75, 139);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(109, 24);
            this.lblNameCustomer.TabIndex = 31;
            this.lblNameCustomer.Text = "Họ và tên";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(-1, 56);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(801, 15);
            this.guna2HtmlLabel1.TabIndex = 41;
            this.guna2HtmlLabel1.Text = "_________________________________________________________________________________" +
    "____________________________________________________";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(112)))), ((int)(((byte)(182)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btnSave.HoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(678, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 5;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.HoverState.CustomBorderColor = System.Drawing.SystemColors.GrayText;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnClose.HoverState.Image = global::GUI.Properties.Resources.icons8_close_48__1_;
            this.btnClose.Image = global::GUI.Properties.Resources.icons8_close_48;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(745, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 26;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblResultAddress);
            this.Controls.Add(this.lblResultBirthday);
            this.Controls.Add(this.lblResultName);
            this.Controls.Add(this.lblResultPhone);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.txtIdCustomer);
            this.Controls.Add(this.lblIdCustomer);
            this.Controls.Add(this.lblNameBirthday);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNameCustomer);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditCustomer";
            this.Text = "FormEditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResultAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResultBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResultName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblResultPhone;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthday;
        private Guna.UI.WinForms.GunaLineTextBox txtPhone;
        private Guna.UI.WinForms.GunaLineTextBox txtAddress;
        private Guna.UI.WinForms.GunaLineTextBox txtNameCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtIdCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIdCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameBirthday;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameCustomer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}