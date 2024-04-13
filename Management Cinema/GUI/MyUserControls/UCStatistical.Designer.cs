namespace GUI.MyUserControls
{
    partial class UCStatistical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbbItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbTimes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbChoose = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtvView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(154, 43);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "Thống kê";
            // 
            // cbbItems
            // 
            this.cbbItems.BackColor = System.Drawing.Color.Transparent;
            this.cbbItems.BorderRadius = 5;
            this.cbbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbItems.FocusedColor = System.Drawing.Color.Empty;
            this.cbbItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbItems.FormattingEnabled = true;
            this.cbbItems.ItemHeight = 30;
            this.cbbItems.Location = new System.Drawing.Point(504, 86);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.Size = new System.Drawing.Size(140, 36);
            this.cbbItems.TabIndex = 8;
            this.cbbItems.SelectedIndexChanged += new System.EventHandler(this.cbbItems_SelectedIndexChanged);
            // 
            // cbbTimes
            // 
            this.cbbTimes.BackColor = System.Drawing.Color.Transparent;
            this.cbbTimes.BorderRadius = 5;
            this.cbbTimes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimes.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTimes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTimes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbTimes.FormattingEnabled = true;
            this.cbbTimes.ItemHeight = 30;
            this.cbbTimes.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cbbTimes.Location = new System.Drawing.Point(259, 86);
            this.cbbTimes.Name = "cbbTimes";
            this.cbbTimes.Size = new System.Drawing.Size(140, 36);
            this.cbbTimes.TabIndex = 9;
            this.cbbTimes.SelectedIndexChanged += new System.EventHandler(this.cbbTimes_SelectedIndexChanged);
            // 
            // cbbChoose
            // 
            this.cbbChoose.BackColor = System.Drawing.Color.Transparent;
            this.cbbChoose.BorderRadius = 5;
            this.cbbChoose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChoose.FocusedColor = System.Drawing.Color.Empty;
            this.cbbChoose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbChoose.FormattingEnabled = true;
            this.cbbChoose.ItemHeight = 30;
            this.cbbChoose.Items.AddRange(new object[] {
            "Phim",
            "Khách hàng"});
            this.cbbChoose.Location = new System.Drawing.Point(14, 86);
            this.cbbChoose.Name = "cbbChoose";
            this.cbbChoose.Size = new System.Drawing.Size(154, 36);
            this.cbbChoose.TabIndex = 7;
            this.cbbChoose.SelectedIndexChanged += new System.EventHandler(this.cbbChoose_SelectedIndexChanged);
            // 
            // dtvView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtvView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtvView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvView.Location = new System.Drawing.Point(0, 179);
            this.dtvView.Name = "dtvView";
            this.dtvView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtvView.RowHeadersVisible = false;
            this.dtvView.Size = new System.Drawing.Size(980, 468);
            this.dtvView.TabIndex = 11;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtvView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtvView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtvView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtvView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtvView.ThemeStyle.HeaderStyle.Height = 50;
            this.dtvView.ThemeStyle.ReadOnly = true;
            this.dtvView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtvView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtvView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtvView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtvView.ThemeStyle.RowsStyle.Height = 22;
            this.dtvView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtvView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UCStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtvView);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbbItems);
            this.Controls.Add(this.cbbTimes);
            this.Controls.Add(this.cbbChoose);
            this.Name = "UCStatistical";
            this.Size = new System.Drawing.Size(980, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dtvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbItems;
        private Guna.UI2.WinForms.Guna2ComboBox cbbTimes;
        private Guna.UI2.WinForms.Guna2ComboBox cbbChoose;
        private Guna.UI2.WinForms.Guna2DataGridView dtvView;
    }
}
