using BLL;
using DTO;
using GUI.Class;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3.UC
{
    public partial class UCSchedule : UserControl
    {
        public UCSchedule()
        {
            InitializeComponent();
            GUI();
            LoadDGV();
        }

        private void GUI()
        {
            int x = 70;
            int y = 580;

            BLL_TBRoom bll = new BLL_TBRoom();
            ButtonSchedule btAll = new ButtonSchedule(this,0);
            btAll.buttonSchedule_del += new ButtonSchedule.buttonSchedule_Del(LoadDGV);
            btAll.Text = "Toàn bộ";
            btAll.Location = new Point(x, y);
            x += 90;
            this.Controls.Add(btAll);
            foreach (var i in bll.GetAllRoomNames())
            {
                ButtonSchedule bt = new ButtonSchedule(this, i.room_id);
                bt.buttonSchedule_del += new ButtonSchedule.buttonSchedule_Del(LoadDGV);
                bt.Text = i.room_name;
                
                bt.Location = new Point(x, y);
                x += 90;
                this.Controls.Add(bt);
            }

        }
        public void LoadDGV(int roomID =0)
        {
            BLL_TBSchedule bll = new BLL_TBSchedule();
            if(roomID == 0)
                dataGridView1.DataSource= bll.GetAllSchedules().ToList();
            else
                dataGridView1.DataSource=bll.GetAllScheduleByRoom(roomID);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormSchedule form = new FormSchedule(0);
            form.formScheduleAddEdit_del += new FormSchedule.FormScheduleAddEdit_Del(LoadDGV);
            form.Show();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                FormSchedule form = new FormSchedule(id);
                form.formScheduleAddEdit_del += new FormSchedule.FormScheduleAddEdit_Del(LoadDGV);
                form.Show();
            }
        }


        private void tbSearchSchedule_TextChanged(object sender, EventArgs e)
        {
            if(tbSearchSchedule.Text!="")
            {
                BLL_TBSchedule bll = new BLL_TBSchedule();
                dataGridView1.DataSource = bll.GetSchedulesByMovieDateRoom(tbSearchSchedule.Text);
            }

            if (tbSearchSchedule.Text.Length == 0)
                LoadDGV();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                FormSchedule form = new FormSchedule(id);
                form.formScheduleAddEdit_del += new FormSchedule.FormScheduleAddEdit_Del(LoadDGV);
                form.Show();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult d;
                d = MessageBox.Show("Bạn chắc chắn muốn xóa lịch chiếu này?", "Xóa lịch chiếu", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    BLL_TBSchedule bll = new BLL_TBSchedule();
                    if (bll.DeleteSchedule(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Tồn tại vé đã đặt ở lịch chiếu này");
                    }
                }
            }
               
        }
    }
}
