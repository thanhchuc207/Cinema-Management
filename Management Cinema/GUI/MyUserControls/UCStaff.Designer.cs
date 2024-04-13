namespace Guna3.UC
{
    partial class UCStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tbSearchStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btDelete = new Guna.UI2.WinForms.Guna2Button();
            this.datagridView1 = new System.Windows.Forms.DataGridView();
            this.staff_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_usename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tbSearchStaff
            // 
            this.tbSearchStaff.AcceptsReturn = true;
            this.tbSearchStaff.BorderRadius = 20;
            this.tbSearchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchStaff.DefaultText = "";
            this.tbSearchStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchStaff.FillColor = System.Drawing.Color.LightGray;
            this.tbSearchStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchStaff.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchStaff.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearchStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchStaff.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbSearchStaff.Location = new System.Drawing.Point(20, 20);
            this.tbSearchStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearchStaff.Name = "tbSearchStaff";
            this.tbSearchStaff.PasswordChar = '\0';
            this.tbSearchStaff.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearchStaff.PlaceholderText = "Tìm kiếm";
            this.tbSearchStaff.SelectedText = "";
            this.tbSearchStaff.Size = new System.Drawing.Size(500, 50);
            this.tbSearchStaff.TabIndex = 10;
            this.tbSearchStaff.TextChanged += new System.EventHandler(this.tbSearchStaff_TextChanged);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btAdd.BorderColor = System.Drawing.Color.White;
            this.btAdd.BorderRadius = 10;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btAdd.Location = new System.Drawing.Point(550, 20);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 45);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Thêm";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btEdit.BorderColor = System.Drawing.Color.White;
            this.btEdit.BorderRadius = 10;
            this.btEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btEdit.Location = new System.Drawing.Point(710, 20);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(119, 45);
            this.btEdit.TabIndex = 12;
            this.btEdit.Text = "Sửa";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btDelete.BorderColor = System.Drawing.Color.White;
            this.btDelete.BorderRadius = 10;
            this.btDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(81)))), ((int)(((byte)(137)))));
            this.btDelete.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btDelete.Location = new System.Drawing.Point(870, 20);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(119, 45);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // datagridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.datagridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridView1.BackgroundColor = System.Drawing.Color.White;
            this.datagridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staff_id,
            this.staff_name,
            this.staff_birthday,
            this.staff_gender,
            this.staff_phone,
            this.email,
            this.Role,
            this.staff_usename});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridView1.EnableHeadersVisualStyles = false;
            this.datagridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(66)))), ((int)(((byte)(110)))));
            this.datagridView1.Location = new System.Drawing.Point(35, 110);
            this.datagridView1.MultiSelect = false;
            this.datagridView1.Name = "datagridView1";
            this.datagridView1.ReadOnly = true;
            this.datagridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridView1.RowHeadersVisible = false;
            this.datagridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.datagridView1.RowTemplate.Height = 24;
            this.datagridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridView1.Size = new System.Drawing.Size(1182, 674);
            this.datagridView1.TabIndex = 14;
            this.datagridView1.VirtualMode = true;
            this.datagridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagridView1_CellFormatting);
            // 
            // staff_id
            // 
            this.staff_id.DataPropertyName = "staff_id";
            this.staff_id.HeaderText = "Mã nhân viên";
            this.staff_id.MinimumWidth = 6;
            this.staff_id.Name = "staff_id";
            this.staff_id.ReadOnly = true;
            // 
            // staff_name
            // 
            this.staff_name.DataPropertyName = "staff_name";
            this.staff_name.HeaderText = "Tên nhân viên";
            this.staff_name.MinimumWidth = 6;
            this.staff_name.Name = "staff_name";
            this.staff_name.ReadOnly = true;
            // 
            // staff_birthday
            // 
            this.staff_birthday.DataPropertyName = "staff_birthday";
            this.staff_birthday.HeaderText = "Ngày sinh";
            this.staff_birthday.MinimumWidth = 6;
            this.staff_birthday.Name = "staff_birthday";
            this.staff_birthday.ReadOnly = true;
            // 
            // staff_gender
            // 
            this.staff_gender.DataPropertyName = "staff_gender";
            this.staff_gender.HeaderText = "Giới tính";
            this.staff_gender.MinimumWidth = 6;
            this.staff_gender.Name = "staff_gender";
            this.staff_gender.ReadOnly = true;
            // 
            // staff_phone
            // 
            this.staff_phone.DataPropertyName = "staff_phone";
            this.staff_phone.HeaderText = "Số điện thoại";
            this.staff_phone.MinimumWidth = 6;
            this.staff_phone.Name = "staff_phone";
            this.staff_phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "role";
            this.Role.HeaderText = "Chức vụ";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // staff_usename
            // 
            this.staff_usename.DataPropertyName = "staff_usename";
            this.staff_usename.HeaderText = "Tên tài khoản";
            this.staff_usename.MinimumWidth = 6;
            this.staff_usename.Name = "staff_usename";
            this.staff_usename.ReadOnly = true;
            // 
            // UCStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.datagridView1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbSearchStaff);
            this.Name = "UCStaff";
            this.Size = new System.Drawing.Size(1260, 834);
            ((System.ComponentModel.ISupportInitialize)(this.datagridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchStaff;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2Button btEdit;
        private Guna.UI2.WinForms.Guna2Button btDelete;
        private System.Windows.Forms.DataGridView datagridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_usename;
    }
}
