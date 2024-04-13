namespace GUI
{
    partial class FormPrintReceipt
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
            this.rvData = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBooking = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // rvData
            // 
            this.rvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvData.LocalReport.ReportEmbeddedResource = "GUI.ReportReceipt.rdlc";
            this.rvData.Location = new System.Drawing.Point(21, 12);
            this.rvData.Margin = new System.Windows.Forms.Padding(2);
            this.rvData.Name = "rvData";
            this.rvData.ServerReport.BearerToken = null;
            this.rvData.Size = new System.Drawing.Size(1202, 657);
            this.rvData.TabIndex = 0;
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBooking.BorderRadius = 10;
            this.btnBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(98)))), ((int)(((byte)(210)))));
            this.btnBooking.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.HoverState.BorderColor = System.Drawing.Color.Blue;
            this.btnBooking.HoverState.CustomBorderColor = System.Drawing.Color.Blue;
            this.btnBooking.HoverState.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBooking.HoverState.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBooking.Location = new System.Drawing.Point(21, 675);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(2);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(190, 64);
            this.btnBooking.TabIndex = 58;
            this.btnBooking.Text = "Xuất vé";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // FormPrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 752);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.rvData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrintReceipt";
            this.Text = "FormPrintReceipt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrintReceipt_FormClosed);
            this.Load += new System.EventHandler(this.FormPrintReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvData;
        private Guna.UI2.WinForms.Guna2Button btnBooking;
    }
}