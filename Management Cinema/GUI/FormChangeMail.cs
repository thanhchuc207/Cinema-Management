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

namespace GUI
{
    public partial class FormChangeMail : Form
    {
        public FormChangeMail(string Email)
        {
            InitializeComponent();
            txtOldEmail.Text = Email;
        }

        private void txtNewEmail_TextChanged(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatEmail(txtNewEmail.Text) == false)
            {
                lblResultEmail.Text = "Vui lòng nhập đúng định dạng Email";
                lblResultEmail.Visible = true;
            }
            else
            {
                lblResultEmail.Visible = false;
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (txtNewEmail.Text == "")
            {
                lblResultEmail.Text = "Vui lòng nhập Email mới";
                if (lblResultEmail.Visible == false)
                {
                    lblResultEmail.Visible = true;
                }
            }
            else
            {
                BLL_TBStaff bll = new BLL_TBStaff();
                if (bll.CheckFormatEmail(txtNewEmail.Text) == false)
                {
                    lblResultEmail.Text = "Vui lòng nhập đúng định dạng Email";
                    lblResultEmail.Visible = true;
                }
                else
                {
                    DialogResult di = MessageBox.Show("Chúng tôi sẽ gửi mã xác nhận đến địa chỉ Email mà bạn vừa nhập. Bạn có chắc chắn không?", "Gửi mã", MessageBoxButtons.YesNo);
                    if (di == DialogResult.Yes)
                    {
                        lblResultEmail.Visible = false;
                        bll.SetPass();
                        bll.SendEmail(txtNewEmail.Text);
                        txtNewEmail.ReadOnly = true;
                        lblTitle.Visible = true;
                        lblVerification.Visible = true;
                        txtVerification.Visible = true;
                        btnSendEmail.Text = "Gửi lại mã";
                        btnSave.Visible = true;
                    }

                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (txtVerification.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã xác nhận");
            }
            else
            {
                int pass = int.Parse(txtVerification.Text);
                if (bll.CheckPass(pass) == false)
                {
                    MessageBox.Show("Mã xác nhận sai vui lòng nhập lại");
                }
                else
                {
                    bll.SaveEmail(txtNewEmail.Text);
                    MessageBox.Show("Đổi Email thành công!");
                    this.Close();
                }
            }
        }
    }
}
