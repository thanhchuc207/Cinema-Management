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

namespace GUI
{
    public delegate void myDel(UserControl x,UserControl y);
    public partial class FormMainStaff : Form
    {
        public event myDel ChangedUC;
        public void LoadForm()
        {
            if(pnView.Controls.Count > 0)
            {
                UserControl x = pnView.Controls[0] as UserControl;

                pnView.Controls.Clear();
                x.Dispose();
            }
            
            UCMovieBooking uc = new UCMovieBooking();
            uc.ChangedUC += ReloadUC;
            pnView.Controls.Add(uc);
           // btnMovie.Checked = true;

        }

        public FormMainStaff()
        {
            InitializeComponent();
            LoadForm();
        }
        public void ReloadUC(UserControl Load, UserControl Remove)
        {
            if (pnView.Controls.Contains(Remove))
            {
                pnView.Controls.Remove(Remove);
                Remove.Dispose();
            }
            if(pnView.Controls.Count>0)
            {
                while(pnView.Controls.Count>0)
                {
                    Control c = pnView.Controls[0];
                    pnView.Controls.RemoveAt(0);
                    c.Dispose();

                }
            }
            Load.Dock = DockStyle.Fill;

            pnView.Controls.Add(Load);
        }  

        private void btnClose_Click(object sender, EventArgs e)
        {
            FormMainLogin form = (FormMainLogin)this.Owner;
            form.Close();
            Close();
        }


        private void btnMovie_Click_1(object sender, EventArgs e)
        {
            UserControl x = pnView.Controls[0] as UserControl;

            pnView.Controls.Clear();
            x.Dispose();
            UCMovieBooking uc = new UCMovieBooking();

            uc.ChangedUC += ReloadUC;
            pnView.Controls.Add(uc);
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            UserControl x = pnView.Controls[0] as UserControl;

            pnView.Controls.Clear();
            x.Dispose();
            UCCustomerStaff uC = new UCCustomerStaff();
            pnView.Controls.Add(uC);
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            UserControl x = pnView.Controls[0] as UserControl;

            pnView.Controls.Clear();
            x.Dispose();
            UCUpdateInformationStaff uC = new UCUpdateInformationStaff();
            pnView.Controls.Add(uC);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất tài khoản", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                //FormMainLogin f = new FormMainLogin();
                //f.ShowDialog();
                //this.Hide();
                this.Close();
            }
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            UserControl x = pnView.Controls[0] as UserControl;

            pnView.Controls.Clear();
            x.Dispose();
            UCReceipt uC = new UCReceipt();
            uC.Dock = DockStyle.Fill;
            pnView.Controls.Add(uC);
        }
    }
}
