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
using Guna3;

namespace GUI.MyUserControls
{
    public partial class UCLogin : UserControl
    {
       
        public UCLogin()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            lblResult.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
            lblResult.Visible = false;

        }
        private void frmStaff_Closed(object sender, EventArgs e)
        {
            //this.ParentForm.Close();
            txtPassWord.Text = "";
            txtUser.Text = "";
            FormMainLogin form = (FormMainLogin)this.ParentForm;
            form.Show();
            
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
          
            Panel panel = (Panel)this.Parent;
            panel.Controls.Remove(this);
            panel.Controls.Add(new UCForgotPassword());
            this.Dispose();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           
            BLL_TBStaff bll = new BLL_TBStaff();
            if (txtUser.Text == "" || txtPassWord.Text == "")
            {
                lblResult.Text = "Vui lòng nhập tên đăng nhập và mật khẩu đầy đủ";
                if (lblResult.Visible == false)
                {
                    lblResult.Visible = true;
                }
            }
            else
            {
                bool login = bll.CheckLogin(txtUser.Text, txtPassWord.Text);
                if (login == true)
                {
                    bool ck = bll.CheckRole();
                    FormMainLogin form = (FormMainLogin)this.ParentForm;
                    if (ck == true)
                    {
                        FormMain frm=new FormMain();
                        frm.FormClosed += frmStaff_Closed;
                        frm.Show(this);
                        form.Hide();
                    }
                    else
                    {
                        FormMainStaff frm=new FormMainStaff();
                        frm.FormClosed += frmStaff_Closed;
                        frm.Show(this);
                        form.Hide();
                    }

                }
                else
                {
                  
                    string text = bll.ShowErrorLogin(txtUser.Text, txtPassWord.Text);
                    lblResult.Text = text;
                    if (lblResult.Visible == false)
                    {
                        lblResult.Visible = true;
                    }
                }
            }
        }

        private void btViewPass_Click(object sender, EventArgs e)
        {
            if (txtPassWord.PasswordChar == '*')
                txtPassWord.PasswordChar = '\0';
            else
                txtPassWord.PasswordChar = '*';
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            lblResult.Visible = false;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblResult.Visible = false;
        }
    }
}
