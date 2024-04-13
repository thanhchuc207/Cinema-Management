using BLL;
using DTO;
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
    public partial class UCRoomType : UserControl
    {
        public delegate void ShowTime(int movie_id, DateTime date);
        public event ShowTime schedule;
        int room_type_id=-1;
        public UCRoomType(int roomType)
        {
            InitializeComponent();
            BLL_TBRoom bllRoom=new BLL_TBRoom();
            this.room_type_id = roomType;
            lblRoomTypeName.Text = bllRoom.GetRoomTypeName(roomType);
            schedule += ShowSchedule;
        }
        public void ShowSchedule(int movie_id,DateTime date)
        {
            if(pnView.Controls.Count > 0)
            {
                while(pnView.Controls.Count > 0)
                {
                    Control c = pnView.Controls[0];
                    pnView.Controls.RemoveAt(0);
                    c.Dispose();
                }
            }
            BLL_TBSchedule bllSchedule=new BLL_TBSchedule();
            List<DTO_TBSchedule> list= new List<DTO_TBSchedule>();
            list = bllSchedule.GetListSchedule(movie_id, date, room_type_id);
            if (list.Count > 0)
            {
                int x = 20;
                foreach (DTO_TBSchedule dto in list)
                {

                    ShowtimeButton btn = new ShowtimeButton(dto);
                    btn.Left = x;
                    btn.Top = (pnView.Height - btn.Height) / 2;
                    pnView.Controls.Add(btn);
                    btn.Click += new EventHandler(ShowTimeButton_Click);
                    x += btn.Width + 20;
                }
            }
        }
        public void ShowTimeButton_Click(object sender, EventArgs e)
        {
            ShowtimeButton btn = (ShowtimeButton)sender;
            FormBookChair frm = new FormBookChair(btn.shedule_id);
            FormMainStaff frmStaff = (FormMainStaff)this.ParentForm;
            frm.ShowDialog(frmStaff);

        }
    }
}
