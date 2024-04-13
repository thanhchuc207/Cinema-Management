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
    public partial class FormStaffEdit : Form
    {
        public delegate void formStaffEdit_Del();
        public formStaffEdit_Del formStaffEdit_del { get; set; }

        public int staffID { get; set; }
        public FormStaffEdit(int ID)
        {
            InitializeComponent();
            LoadCBBRole();
            staffID = ID;
            GUI(ID);
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
        private void GUI(int ID)
        {

            BLL_TBStaff db = new BLL_TBStaff();
            DTO_Staff i = db.GetStaff(ID);
            tbID.Text = i.staff_id.ToString();
            tbID.Enabled = false;
            tbName.Text = i.staff_name.ToString();
            dtpkBirthday.Value = i.staff_birthday;
            tbPhone.Text = i.staff_phone.ToString();
            tbEmail.Text = i.email.ToString();
            if (i.role == false)
                cbbRole.Text = "Nhân viên";
            else cbbRole.Text = "Quản lý";
            if (i.staff_gender) rdobtFemale.Checked = true;
            else rdobtMale.Checked = true;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                BLL_TBStaff bll = new BLL_TBStaff();
                if (bll.DeleteStaff(staffID))
                {
                    MessageBox.Show("Xóa thành công!");
                    formStaffEdit_del();
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản này");
                }

            }
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
        private bool CheckFormatPhone(string pn)
        {
            return Regex.IsMatch(pn, "^[0-9]{10}$");
        }
        private bool CheckInfor()
        {
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên");
                return false;
            }
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng điền email");
                return false;
            }
            if (!CheckInForEmail(tbEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đúng định dạng email");
                return false;

            }
            if (tbPhone.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại");
                return false;
            }
            if ((tbPhone.Text.Substring(0, 1) != "0") || (!CheckFormatPhone(tbPhone.Text)))
            {
                MessageBox.Show("Vui lòng điền đúng định dạng số điện thoại. \nSố điện thoại cần bao gồm 10 số và bắt đầu bằng số 0");
                return false;
            }
            if (cbbRole.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ");
                return false;
            }
            if ((!rdobtFemale.Checked) && (!rdobtMale.Checked))
            {
                MessageBox.Show("Vui lòng chọn giới tính");
                return false;
            }
            return true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if(CheckInfor())
            {
                BLL_TBStaff db = new BLL_TBStaff();
                bool gender;
                if (rdobtMale.Checked) gender = false;
                else gender = true;

                bool role_staff;
                if (cbbRole.Text == "Nhân viên") role_staff = false;
                else role_staff = true;
                DTO_Staff i = new DTO_Staff
                {
                    staff_id = staffID,
                    staff_name = tbName.Text,
                    staff_birthday = dtpkBirthday.Value,
                    staff_gender = gender,
                    staff_phone = tbPhone.Text,
                    email = tbEmail.Text,
                    role = role_staff,

                };
                string message = "";
                if (db.UpdateStaff(i, ref message))
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
    }
}
