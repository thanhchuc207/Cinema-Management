using BLL;
using GUI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UCRoom : UserControl
    {
        public UCRoom()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            panel1.Controls.Clear();
            int x = 50;
            int y = 50;
            BLL_TBRoom bll = new BLL_TBRoom();
            foreach (var i in bll.GetAllRoomTypes())
            {
                Label lb = new Label();
                lb.Width = 80;
                lb.Height = 45;
                lb.Text = i.room_type_name;
                lb.Location = new Point(x, y + 20);
                panel1.Controls.Add(lb);
                BLL_TBRoom bll1 = new BLL_TBRoom();
                int x1 = x + 90;
                foreach (var j in bll1.GetAllRoomNameByType(i.room_type_id))
                {
                    ButtonRoom bt = new ButtonRoom(this,j.room_id);
                    
                    bt.Text = j.room_name;
                    bt.Location = new Point(x1, y);
                    x1 += 90;
                    panel1.Controls.Add(bt);
                }
                y += 100;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormRoomDetail form = new FormRoomDetail(0);
            form.formRoomDetail_del += new FormRoomDetail.FormRoomDetail_Del(GUI);
            form.Show();
        }

        private void tbSearchRoom_TextChanged(object sender, EventArgs e)
        {
            if(tbSearchRoom.Text!="")
            {
                panel1.Controls.Clear();
                int x = 50;
                int y = 50;
                BLL_TBRoom bll = new BLL_TBRoom();
                foreach (var i in bll.GetAllRoomTypes())
                {
                    Label lb = new Label();
                    lb.Width = 80;
                    lb.Height = 45;
                    lb.Text = i.room_type_name;
                    lb.Location = new Point(x, y + 20);
                    panel1.Controls.Add(lb);
                    BLL_TBRoom bll1 = new BLL_TBRoom();
                    int x1 = x + 90;
                    foreach (var j in bll1.GetRoomNameByTypeAndName(i.room_type_id, tbSearchRoom.Text))
                    {
                        ButtonRoom bt = new ButtonRoom(this, j.room_id);

                        bt.Text = j.room_name;
                        bt.Location = new Point(x1, y);
                        x1 += 90;
                        panel1.Controls.Add(bt);
                    }
                    y += 100;
                }
            }
            if (tbSearchRoom.Text.Length == 0)
                GUI();
        }

        private void btRoomType_Click(object sender, EventArgs e)
        {
            FormRoomType f = new FormRoomType();
            f.formRoomType_del += new FormRoomType.FormRoomType_Del(GUI);
            f.Show();
        }

        private void btSeatType_Click(object sender, EventArgs e)
        {
            FormSeatType f = new FormSeatType();
            f.ShowDialog();
        }
    }
}
