using BCrypt.Net;
using BLL;
using DTO;
using Guna3.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3
{
    public partial class FormStaffAdd : Form
    {
        public delegate void formStaffAdd_Del();
        public formStaffAdd_Del formStaffEdit_del { get; set; }
        public FormStaffAdd()
        {
            InitializeComponent();
            LoadCBBRole();
        }
        private void LoadCBBRole()
        {
            DTO_CBBRole staff = new DTO_CBBRole
            {
                role_id = false,
                role_name = "Nhân viên"

            };
            DTO_CBBRole manager = new DTO_CBBRole
            {
                role_id = true,
                role_name = "Quản lý"
            };
            cbbRole.Items.Add(staff);
            cbbRole.Items.Add(manager);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool CheckInForEmail(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }
        private bool CheckFormatUsernamePass(string un)
        {
            return Regex.IsMatch(un, "^[a-zA-Z0-9]{6}$");
        }
        private bool CheckFormatPhone(string pn)
        {
            return Regex.IsMatch(pn, "^[0-9]{10}$");
        }
        private bool CheckInfor()
        {
            if(tbName.Text=="")
            {
                MessageBox.Show("Vui lòng điền tên");
                return false;
            }
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng điền email");
                return false;
            }
            if(!CheckInForEmail(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đúng định dạng email");
                return false;

            }
            if (tbPhone.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại");
                return false;
            }
            if((tbPhone.Text.Substring(0,1)!="0") || (!CheckFormatPhone(tbPhone.Text)))
            {
                MessageBox.Show("Vui lòng điền đúng định dạng số điện thoại. \nSố điện thoại cần bao gồm 10 số và bắt đầu bằng số 0");
                return false;
            }    
            if(cbbRole.Text=="")
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
                return false;
            }
            if((rdobtFemale.Checked==false) && (rdobtMale.Checked==false))
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return false;
            }
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên tài khoản");
                return false;
            }
            if(CheckFormatUsernamePass(tbUsername.Text)==false)
            {
                MessageBox.Show("Vui lòng điền đúng định dạng tên tài khoản. \nTên tài khoản cần có ít nhất 6 ký tự và không chứa các ký tự đặc biệt");
                return false;
            }
            if (tbPwd.Text == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu");
                return false;
            }
            if (CheckFormatUsernamePass(tbPhone.Text)==false)
            {
                MessageBox.Show("Vui lòng điền mật khẩu có ít nhất 6 ký tự và không chứa các ký tự đặc biệt");
                return false;
            }
            if (tbPwdAgain.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu");
                return false;
            }
            if(tbPwd!=tbPwdAgain)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return false;
            }
            return true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if(CheckInfor())
            {
                bool gender;
                if (rdobtMale.Checked) gender = false;
                else gender = true;

                bool role_staff;
                if (cbbRole.Text == "Nhân viên") role_staff = false;
                else role_staff = true;

                BLL_TBStaff bll = new BLL_TBStaff();
                DTO_Staff i = new DTO_Staff
                {
                    staff_name = tbName.Text,
                    staff_birthday = dtpkBirthday.Value,
                    staff_gender = gender,
                    staff_phone = tbPhone.Text,
                    email = tbEmail.Text,
                    role = role_staff,
                    staff_usename = tbUsername.Text,
                    staff_pwd = BCrypt.Net.BCrypt.HashPassword(tbPwd.Text, 10),

                };
                string message = "";
                if(bll.AddStaff(i,ref message))
                {
                    MessageBox.Show(message);
                    formStaffEdit_del();
                    Close();
                }
                else
                {
                    MessageBox.Show(message);
                }
                
            }           
        }

        private void btViewPass_Click(object sender, EventArgs e)
        {
            if (tbPwd.PasswordChar == '*')
                tbPwd.PasswordChar = '\0';
            else
                tbPwd.PasswordChar = '*';
        }
    }
}
