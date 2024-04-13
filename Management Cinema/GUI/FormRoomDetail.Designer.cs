namespace GUI
{
    partial class FormRoomDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnSeat = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbRow = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbSeat = new Guna.UI.WinForms.GunaLineTextBox();
            this.tbRoomName = new Guna.UI.WinForms.GunaLineTextBox();
            this.cbbRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumSeatFree = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNumSeatBooking = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnType = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btSave = new Guna.UI2.WinForms.Guna2Button();
            this.btDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btClose = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            this.pnType.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin phòng chiếu";
            // 
            // pnSeat
            // 
            this.pnSeat.AutoScroll = true;
            this.pnSeat.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.pnSeat.BackColor = System.Drawing.Color.White;
            this.pnSeat.BorderColor = System.Drawing.Color.DimGray;
            this.pnSeat.BorderThickness = 1;
            this.pnSeat.Location = new System.Drawing.Point(300, 80);
            this.pnSeat.Margin = new System.Windows.Forms.Padding(2);
            this.pnSeat.Name = "pnSeat";
            this.pnSeat.Size = new System.Drawing.Size(896, 474);
            this.pnSeat.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Số lượng ghế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Số hàng ghế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng chiếu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderColor = System.Drawing.Color.DimGray;
            this.panel1.BorderThickness = 1;
            this.panel1.Controls.Add(this.tbRow);
            this.panel1.Controls.Add(this.tbSeat);
            this.panel1.Controls.Add(this.tbRoomName);
            this.panel1.Controls.Add(this.cbbRoomType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbNumSeatFree);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbNumSeatBooking);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 572);
            this.panel1.TabIndex = 3;
            // 
            // tbRow
            // 
            this.tbRow.BackColor = System.Drawing.Color.White;
            this.tbRow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRow.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbRow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbRow.LineColor = System.Drawing.Color.Gainsboro;
            this.tbRow.Location = new System.Drawing.Point(63, 346);
            this.tbRow.Name = "tbRow";
            this.tbRow.PasswordChar = '\0';
            this.tbRow.SelectedText = "";
            this.tbRow.Size = new System.Drawing.Size(160, 34);
            this.tbRow.TabIndex = 76;
            this.tbRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRow.TextChanged += new System.EventHandler(this.tbRow_TextChanged_1);
            this.tbRow.Leave += new System.EventHandler(this.tbRow_Leave_1);
            // 
            // tbSeat
            // 
            this.tbSeat.BackColor = System.Drawing.Color.White;
            this.tbSeat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSeat.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbSeat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbSeat.LineColor = System.Drawing.Color.Gainsboro;
            this.tbSeat.Location = new System.Drawing.Point(63, 201);
            this.tbSeat.Name = "tbSeat";
            this.tbSeat.PasswordChar = '\0';
            this.tbSeat.SelectedText = "";
            this.tbSeat.Size = new System.Drawing.Size(160, 34);
            this.tbSeat.TabIndex = 75;
            this.tbSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSeat.TextChanged += new System.EventHandler(this.tbSeat_TextChanged_1);
            this.tbSeat.Leave += new System.EventHandler(this.tbSeat_Leave_1);
            // 
            // tbRoomName
            // 
            this.tbRoomName.BackColor = System.Drawing.Color.White;
            this.tbRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRoomName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbRoomName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.tbRoomName.LineColor = System.Drawing.Color.Gainsboro;
            this.tbRoomName.Location = new System.Drawing.Point(63, 69);
            this.tbRoomName.Name = "tbRoomName";
            this.tbRoomName.PasswordChar = '\0';
            this.tbRoomName.SelectedText = "";
            this.tbRoomName.Size = new System.Drawing.Size(160, 34);
            this.tbRoomName.TabIndex = 74;
            this.tbRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbRoomType
            // 
            this.cbbRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cbbRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbRoomType.ItemHeight = 30;
            this.cbbRoomType.Location = new System.Drawing.Point(74, 448);
            this.cbbRoomType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbRoomType.Name = "cbbRoomType";
            this.cbbRoomType.Size = new System.Drawing.Size(123, 36);
            this.cbbRoomType.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 410);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 70;
            this.label4.Text = "Loại phòng";
            // 
            // tbNumSeatFree
            // 
            this.tbNumSeatFree.BorderColor = System.Drawing.Color.White;
            this.tbNumSeatFree.BorderRadius = 10;
            this.tbNumSeatFree.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbNumSeatFree.DefaultText = "15";
            this.tbNumSeatFree.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNumSeatFree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNumSeatFree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumSeatFree.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumSeatFree.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumSeatFree.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumSeatFree.ForeColor = System.Drawing.Color.DimGray;
            this.tbNumSeatFree.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumSeatFree.Location = new System.Drawing.Point(768, 545);
            this.tbNumSeatFree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumSeatFree.Name = "tbNumSeatFree";
            this.tbNumSeatFree.PasswordChar = '\0';
            this.tbNumSeatFree.PlaceholderText = "";
            this.tbNumSeatFree.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNumSeatFree.SelectedText = "";
            this.tbNumSeatFree.Size = new System.Drawing.Size(60, 32);
            this.tbNumSeatFree.TabIndex = 54;
            this.tbNumSeatFree.TabStop = false;
            this.tbNumSeatFree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNumSeatBooking
            // 
            this.tbNumSeatBooking.BorderColor = System.Drawing.Color.White;
            this.tbNumSeatBooking.BorderRadius = 10;
            this.tbNumSeatBooking.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbNumSeatBooking.DefaultText = "35";
            this.tbNumSeatBooking.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNumSeatBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNumSeatBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumSeatBooking.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumSeatBooking.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumSeatBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumSeatBooking.ForeColor = System.Drawing.Color.DimGray;
            this.tbNumSeatBooking.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumSeatBooking.Location = new System.Drawing.Point(474, 545);
            this.tbNumSeatBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNumSeatBooking.Name = "tbNumSeatBooking";
            this.tbNumSeatBooking.PasswordChar = '\0';
            this.tbNumSeatBooking.PlaceholderText = "";
            this.tbNumSeatBooking.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbNumSeatBooking.SelectedText = "";
            this.tbNumSeatBooking.Size = new System.Drawing.Size(60, 32);
            this.tbNumSeatBooking.TabIndex = 53;
            this.tbNumSeatBooking.TabStop = false;
            this.tbNumSeatBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(665, 550);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 52;
            this.label10.Text = "Còn trống:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 550);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 51;
            this.label9.Text = "Đã đặt:";
            // 
            // pnType
            // 
            this.pnType.AutoScroll = true;
            this.pnType.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.pnType.BackColor = System.Drawing.Color.White;
            this.pnType.Controls.Add(this.label12);
            this.pnType.Controls.Add(this.guna2Button5);
            this.pnType.Controls.Add(this.label8);
            this.pnType.Controls.Add(this.guna2Button4);
            this.pnType.Location = new System.Drawing.Point(301, 554);
            this.pnType.Margin = new System.Windows.Forms.Padding(2);
            this.pnType.Name = "pnType";
            this.pnType.Size = new System.Drawing.Size(895, 99);
            this.pnType.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(285, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 29);
            this.label12.TabIndex = 21;
            this.label12.Text = "Chưa thiết lập";
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderRadius = 3;
            this.guna2Button5.Enabled = false;
            this.guna2Button5.FillColor = System.Drawing.Color.Gray;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(234, 29);
            this.guna2Button5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(44, 44);
            this.guna2Button5.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(70, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Đang chọn";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 3;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(20)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(19, 29);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(44, 44);
            this.guna2Button4.TabIndex = 18;
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
            this.btSave.Location = new System.Drawing.Point(474, 672);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(90, 45);
            this.btSave.TabIndex = 47;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.btDelete.Location = new System.Drawing.Point(651, 672);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 45);
            this.btDelete.TabIndex = 48;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClose
            // 
            this.btClose.Image = global::GUI.Properties.Resources.icons8_multiply_50;
            this.btClose.Location = new System.Drawing.Point(1158, 12);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.TabIndex = 20;
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
            // FormRoomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.pnType);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSeat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRoomDetail";
            this.Text = "FormRoomDetail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnType.ResumeLayout(false);
            this.pnType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnType;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbNumSeatFree;
        private Guna.UI2.WinForms.Guna2TextBox tbNumSeatBooking;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btClose;
        private Guna.UI2.WinForms.Guna2Button btSave;
        private Guna.UI2.WinForms.Guna2Button btDelete;
        private Guna.UI2.WinForms.Guna2ComboBox cbbRoomType;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI.WinForms.GunaLineTextBox tbRoomName;
        private Guna.UI.WinForms.GunaLineTextBox tbRow;
        private Guna.UI.WinForms.GunaLineTextBox tbSeat;
    }
}