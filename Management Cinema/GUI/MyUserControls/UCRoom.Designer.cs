namespace GUI.MyUserControls
{
    partial class UCRoom
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tbSearchRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btRoomType = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSeatType = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tbSearchRoom
            // 
            this.tbSearchRoom.BorderRadius = 20;
            this.tbSearchRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchRoom.DefaultText = "";
            this.tbSearchRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchRoom.FillColor = System.Drawing.Color.LightGray;
            this.tbSearchRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchRoom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchRoom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearchRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearchRoom.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.tbSearchRoom.Location = new System.Drawing.Point(20, 20);
            this.tbSearchRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearchRoom.Name = "tbSearchRoom";
            this.tbSearchRoom.PasswordChar = '\0';
            this.tbSearchRoom.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.tbSearchRoom.PlaceholderText = "Tìm kiếm";
            this.tbSearchRoom.SelectedText = "";
            this.tbSearchRoom.Size = new System.Drawing.Size(647, 50);
            this.tbSearchRoom.TabIndex = 13;
            this.tbSearchRoom.TextChanged += new System.EventHandler(this.tbSearchRoom_TextChanged);
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
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btAdd.Location = new System.Drawing.Point(686, 25);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(119, 45);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Thêm";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRoomType
            // 
            this.btRoomType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btRoomType.BorderColor = System.Drawing.Color.White;
            this.btRoomType.BorderRadius = 10;
            this.btRoomType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btRoomType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btRoomType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRoomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btRoomType.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btRoomType.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btRoomType.ForeColor = System.Drawing.Color.White;
            this.btRoomType.ImageSize = new System.Drawing.Size(30, 30);
            this.btRoomType.Location = new System.Drawing.Point(826, 25);
            this.btRoomType.Name = "btRoomType";
            this.btRoomType.Size = new System.Drawing.Size(174, 45);
            this.btRoomType.TabIndex = 15;
            this.btRoomType.Text = "Loại phòng";
            this.btRoomType.Click += new System.EventHandler(this.btRoomType_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 740);
            this.panel1.TabIndex = 16;
            // 
            // btSeatType
            // 
            this.btSeatType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btSeatType.BorderColor = System.Drawing.Color.White;
            this.btSeatType.BorderRadius = 10;
            this.btSeatType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSeatType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSeatType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSeatType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSeatType.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btSeatType.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.btSeatType.ForeColor = System.Drawing.Color.White;
            this.btSeatType.ImageSize = new System.Drawing.Size(30, 30);
            this.btSeatType.Location = new System.Drawing.Point(1032, 25);
            this.btSeatType.Name = "btSeatType";
            this.btSeatType.Size = new System.Drawing.Size(174, 45);
            this.btSeatType.TabIndex = 17;
            this.btSeatType.Text = "Loại ghế";
            this.btSeatType.Click += new System.EventHandler(this.btSeatType_Click);
            // 
            // UCRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btSeatType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btRoomType);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbSearchRoom);
            this.Name = "UCRoom";
            this.Size = new System.Drawing.Size(1260, 834);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchRoom;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2Button btRoomType;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btSeatType;
    }
}
