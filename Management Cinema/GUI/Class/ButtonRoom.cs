using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Guna3;
using Guna3.UC;
using GUI.MyUserControls;

namespace GUI.Class
{
    public class ButtonRoom : Button
    {
       
         int id_room { get; set; }
        UCRoom ucRoom { get; set; }

        public ButtonRoom(UCRoom u , int id)
        {
           ucRoom = u;
            this.id_room = id;
            this.Height= 45;
            this.Width = 80;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            
            FormRoomDetail form = new FormRoomDetail(id_room);
            form.formRoomDetail_del += new FormRoomDetail.FormRoomDetail_Del(ucRoom.GUI);
            form.Show();
            
        }
    }
}
