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
    public partial class UCResetPassword : UserControl
    {
        public UCResetPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (txtPass.Text != "" && txtRePass.Text != "")
            {
                if (txtPass.Text == txtRePass.Text)
                {
                    bll.RePass(txtPass.Text);
                    Panel panel = (Panel)this.Parent;
                    panel.Controls.Remove(this);
                    panel.Controls.Add(new UCFinishReset());
                    this.Dispose();
                }
                else
                {
                    lblResult.Text = "Mật khẩu không trùng khớp";
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
            }
            else
            {
                lblResult.Text = "Vui lòng nhập mật khẩu";
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new UCLogin());
            this.Dispose();

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new UCForgotPassword());
            this.Dispose();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatPass(txtPass.Text) == false)
            {
                lblResult.Text = "Mật khẩu bao gồm 1-16 kí tự bao gồm chữ và số và không có kí tự đặc biệt";
                lblResult.Visible = true;
            }
            else
            {
                lblResult.Visible = false;
            }
        }

        private void txtRePass_TextChanged(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatPass(txtPass.Text) == false)
            {
                lblResult.Text = "Mật khẩu bao gồm 1-16 kí tự bao gồm chữ và số và không có kí tự đặc biệt";
                lblResult.Visible = true;
            }
            else
            {
                lblResult.Visible = false;
            }
        }
    }
}
