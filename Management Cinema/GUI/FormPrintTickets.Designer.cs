namespace GUI
{
    partial class FormPrintTickets
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
            this.rvTickets = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbbItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dTOTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dTOTicketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvTickets
            // 
            this.rvTickets.Location = new System.Drawing.Point(10, 51);
            this.rvTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rvTickets.Name = "rvTickets";
            this.rvTickets.ServerReport.BearerToken = null;
            this.rvTickets.Size = new System.Drawing.Size(639, 516);
            this.rvTickets.TabIndex = 0;
            // 
            // cbbItems
            // 
            this.cbbItems.BackColor = System.Drawing.Color.Transparent;
            this.cbbItems.DataSource = this.dTOTicketBindingSource;
            this.cbbItems.DisplayMember = "ticket_id";
            this.cbbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbItems.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbItems.ItemHeight = 30;
            this.cbbItems.Location = new System.Drawing.Point(11, 11);
            this.cbbItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbItems.Name = "cbbItems";
            this.cbbItems.Size = new System.Drawing.Size(155, 36);
            this.cbbItems.TabIndex = 3;
            this.cbbItems.ValueMember = "ticket_id";
            this.cbbItems.SelectedIndexChanged += new System.EventHandler(this.cbbItems_SelectedIndexChanged);
            // 
            // dTOTicketBindingSource
            // 
            this.dTOTicketBindingSource.DataSource = typeof(DTO.DTO_Ticket);
            // 
            // FormPrintTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(660, 578);
            this.Controls.Add(this.cbbItems);
            this.Controls.Add(this.rvTickets);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrintTickets";
            this.Text = "FormPrintTickets";
            this.Load += new System.EventHandler(this.FormPrintTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTOTicketBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvTickets;
        private Guna.UI2.WinForms.Guna2ComboBox cbbItems;
        private System.Windows.Forms.BindingSource dTOTicketBindingSource;
    }
}