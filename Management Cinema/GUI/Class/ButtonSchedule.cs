using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using GUI.MyUserControls;
using Guna3.UC;

namespace GUI.Class
{
    public class ButtonSchedule : Button
    {
        public delegate void buttonSchedule_Del(int roomid);
        public buttonSchedule_Del buttonSchedule_del { get; set; }
        UCSchedule ucSchedule { get; set; }
        int id_room { get; set; }

        public ButtonSchedule(UCSchedule u, int id)
        {
            ucSchedule = u;
            this.id_room = id;
            this.Height = 45;
            this.Width = 80;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            buttonSchedule_del(id_room);
        }
    }
}
