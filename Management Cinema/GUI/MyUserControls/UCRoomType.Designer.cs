namespace GUI.MyUserControls
{
    partial class UCRoomType
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
            this.lblRoomTypeName = new System.Windows.Forms.Label();
            this.pnView = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // lblRoomTypeName
            // 
            this.lblRoomTypeName.AutoSize = true;
            this.lblRoomTypeName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRoomTypeName.ForeColor = System.Drawing.Color.Black;
            this.lblRoomTypeName.Location = new System.Drawing.Point(26, 15);
            this.lblRoomTypeName.Name = "lblRoomTypeName";
            this.lblRoomTypeName.Size = new System.Drawing.Size(117, 24);
            this.lblRoomTypeName.TabIndex = 0;
            this.lblRoomTypeName.Text = "RoomType";
            // 
            // pnView
            // 
            this.pnView.AutoScroll = true;
            this.pnView.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.pnView.BorderRadius = 5;
            this.pnView.BorderThickness = 1;
            this.pnView.Location = new System.Drawing.Point(3, 62);
            this.pnView.Name = "pnView";
            this.pnView.Size = new System.Drawing.Size(944, 108);
            this.pnView.TabIndex = 1;
            // 
            // UCRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnView);
            this.Controls.Add(this.lblRoomTypeName);
            this.Name = "UCRoomType";
            this.Size = new System.Drawing.Size(950, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomTypeName;
        private Guna.UI2.WinForms.Guna2Panel pnView;
    }
}
