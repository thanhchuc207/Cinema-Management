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
    public partial class UCVerification : UserControl
    {
        public UCVerification()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            int check = int.Parse(txtVerification.Text);
            if (bll.CheckPass(check))
            {
                Panel panel = (Panel)this.Parent;
                panel.Controls.Remove(this);
                panel.Controls.Add(new UCResetPassword());
            }
            else
            {
                if (lblResult.Visible == false)
                {
                    lblResult.Visible = true;
                }
            }


        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new UCForgotPassword());
            this.Dispose();
        }
    }
}
