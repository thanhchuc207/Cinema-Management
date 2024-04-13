using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Class
{
    public class DayButton :Guna2Button
    {
        public DateTime date { get; set; }
        public DayButton(DateTime st)
        {
            date = st;
            this.Font = new Font("Arial", 16, FontStyle.Bold);
            this.Size = new Size(100, 65);
            this.Text = st.ToString("dd/MM");
            this.BorderRadius = 10;
            this.FillColor = Color.White;
            this.BorderColor = Color.DarkGray;
            this.ForeColor = Color.Black;
            this.BorderThickness = 1;
            this.HoverState.Font = new Font("Arial", 17, FontStyle.Bold);
            this.HoverState.ForeColor = Color.White;
            this.HoverState.FillColor = Color.FromArgb(45, 125, 220);
            this.HoverState.BorderColor = Color.Blue;
            this.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
