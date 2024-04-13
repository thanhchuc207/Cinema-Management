using BLL;
using GUI;
using GUI.MyUserControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCRoom());
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
            panel1.Controls.Add(new UCStatiscal());
        }

        private void ucHoaDon1_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            FormMainLogin form =(FormMainLogin) this.Owner;
            form.Close();
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất tài khoản", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
               //FormMainLogin f = new FormMainLogin();
               // f.ShowDialog();
               // this.Hide();
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất tài khoản", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                //FormMainLogin f = new FormMainLogin();
                // f.ShowDialog();
                // this.Hide();
                this.Close();
            }
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new UCReceipt());
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            UserControl x = panel1.Controls[0] as UserControl;

            panel1.Controls.Clear();
            x.Dispose();
            UCUpdateInformationStaff uC = new UCUpdateInformationStaff();
            panel1.Controls.Add(uC);
        }
    }
}
