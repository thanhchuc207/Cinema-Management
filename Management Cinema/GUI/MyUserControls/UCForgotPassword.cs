using BLL;
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
    public partial class UCForgotPassword : UserControl
    {
        public UCForgotPassword()
        {
            InitializeComponent();
            lblResult.Visible = false;
            lblResult.Text = "Không tìm thấy tài khoản liên kết với email trên";

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (txtEmail.Text == "")
            {
                lblResult.Text = "Vui lòng nhập email";
                if (lblResult.Visible == false)
                {
                    lblResult.Visible = true;
                }
            }
            else
            {
                bool ck = bll.CheckEmail(txtEmail.Text);
                if (ck == true)
                {
                    bll.SetPass();
                    bll.SendEmail(txtEmail.Text);
                    Panel panel = (Panel)this.Parent;
                    panel.Controls.Remove(this);
                    panel.Controls.Add(new UCVerification());

                }
                else
                {
                    lblResult.Text = "Không tìm thấy tài khoản tương ứng với email trên!";
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new UCLogin());
            this.Dispose();

        }
    }
}
