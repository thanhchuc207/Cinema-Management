using Guna3.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            panel1.Controls.Add(new UCMovie());
        }
        
        private void btPhong_Click(object sender, EventArgs e)
        {
           /* if(!panel1.Controls.Contains(UCQLLichChieu.Instance))
            {
                panel1.Controls.Add(UCQLLichChieu.Instance);
                UCQLLichChieu.Instance.Dock = DockStyle.Fill;
                UCQLLichChieu.Instance.BringToFront();
            }
            else
                UCQLLichChieu.Instance.BringToFront();
           */
        }
    

        private void btPhim_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCMovie());
        }

        private void btLichchieu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCSchedule());
        }

        private void btNhansu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCStaff());
        }

        private void btKhachhang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCCustomer());
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCReceipt());
        }

        private void ucHoaDon1_Load(object sender, EventArgs e)
        {

        }
    }
}
