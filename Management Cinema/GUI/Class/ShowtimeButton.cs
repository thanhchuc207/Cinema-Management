using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace GUI.Class
{
    public class ShowtimeButton :Guna2Button
    {
        public int shedule_id;
        public ShowtimeButton(DTO_TBSchedule st)
        {
            
            shedule_id = st.schedule_id;
            this.Size = new Size(170, 50);
            this.FillColor = Color.White;
            this.ForeColor = Color.FromArgb(0, 88, 220);
            this.Font = new Font("Arial", 14, FontStyle.Regular);
            this.BorderRadius = 8;
            this.BorderColor = Color.FromArgb(82, 222, 253);
            this.BorderThickness = 1;

            this.HoverState.Font = new Font("Arial", 15, FontStyle.Bold);
            this.HoverState.BorderColor = Color.Blue;
            this.HoverState.FillColor = Color.DeepSkyBlue;
            this.HoverState.ForeColor = Color.White;
            this.Text = st.schedule_start.ToString("hh\\:mm") + " ~ " + st.schedule_end.ToString("hh\\:mm");
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

    }
}
