using BLL;
using DTO;
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
    public partial class UCUpdateInformationStaff : UserControl
    {
        public UCUpdateInformationStaff()
        {
            InitializeComponent();
            LoadInfor();
        }
        public void LoadInfor()
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            DTO_Staff result = bll.GetInforStaff();
            if (result != null)
            {
                txtEmail.Text = result.email;
                dtpBirthday.Value = result.staff_birthday;
                txtNameStaff.Text = result.staff_name;
                if (result.staff_gender == true)
                {
                    cbbGenre.SelectedIndex = 0;
                }
                else
                {
                    cbbGenre.SelectedIndex = 1;
                }
                if (result.role == true)
                {
                    txtRole.Text = "Quản lí";
                }
                else
                {
                    txtRole.Text = "Nhân viên";
                }
                txtPhone.Text = result.staff_phone;
            }

        }

        private void btnChangeBirthday_Click(object sender, EventArgs e)
        {
            if (dtpBirthday.Enabled == false)
            {
                dtpBirthday.Enabled = true;
            }
        }



        private void btnSavePass_Click(object sender, EventArgs e)
        {

            BLL_TBStaff bll = new BLL_TBStaff();
            if (txtOldPass.Text == "" && txtNewPass.Text == "" && txtReNewPass.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                lblResultOldPass.Text = "Vui lòng nhập đầy đủ mật khẩu!";
                lblResultOldPass.Visible = true;
                lblResultUsername.Text = "Vui lòng nhập đầy đủ tên người dùng";
                lblResultUsername.Visible = true;
            }
            else if(txtUsername.Text!="" && (txtReNewPass.Text=="" && txtNewPass.Text=="" && txtOldPass.Text==""))
            {
                if (bll.CheckFormatUserName(txtUsername.Text))
                {
                    bll.SavePass("", txtUsername.Text);
                    MessageBox.Show("Đổi tên đăng nhập thành công");
                }
                else
                {
                    lblResultUsername.Text = "Tên người dùng bao gồm chữ hoặc số không có khoảng trắng và kí tự đặc biệt";
                    lblResultUsername.Visible = true;
                }
            }
            else if (txtUsername.Text == "" && (txtReNewPass.Text != "" && txtNewPass.Text != "" && txtOldPass.Text != ""))
            {
                if (bll.CheckPass(txtOldPass.Text))
                {
                    if (txtNewPass.Text != txtReNewPass.Text)
                    {
                        lblResultRePass.Text = "Mật khẩu không trùng khớp với nhau!";
                        lblResultRePass.Visible = true;
                    }
                    else
                    {
                        if (bll.CheckFormatPass(txtNewPass.Text))
                        {
                            bll.SavePass(txtNewPass.Text, "");
                            MessageBox.Show("Đổi mật khẩu thành công!");
                            GUIUsers();
                        }
                        else
                        {
                            lblResultNewPass.Text = "Mật khẩu phải từ 1-16 kí tự. Chỉ bao gồm chữ và số không được có kí tự đặc biệt!";
                            lblResultNewPass.Visible = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai! Vui lòng nhập lại");
                    lblResultOldPass.Text = "Mật khẩu sai! Vui lòng nhập lại";
                    lblResultOldPass.Visible = true;
                }
            }
            else if(txtUsername.Text != "" && (txtReNewPass.Text != "" && txtNewPass.Text != "" && txtOldPass.Text != ""))
            {
                if (bll.CheckFormatUserName(txtUsername.Text))
                {
                    if (bll.CheckPass(txtOldPass.Text))
                    {
                        if (txtNewPass.Text != txtReNewPass.Text)
                        {
                            lblResultRePass.Text = "Mật khẩu không trùng khớp với nhau!";
                            lblResultRePass.Visible = true;
                        }
                        else
                        {
                            if (bll.CheckFormatPass(txtNewPass.Text))
                            {
                                bll.SavePass(txtNewPass.Text, txtUsername.Text);
                                MessageBox.Show("Đổi mật khẩu và tên đăng nhập thành công!");
                                GUIUsers();
                            }
                            else
                            {
                                lblResultNewPass.Text = "Mật khẩu phải từ 1-16 kí tự. Chỉ bao gồm chữ và số không được có kí tự đặc biệt!";
                                lblResultNewPass.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai! Vui lòng nhập lại");
                        lblResultOldPass.Text = "Mật khẩu sai! Vui lòng nhập lại";
                        lblResultOldPass.Visible = true;
                    }
                }
                else
                {
                    lblResultUsername.Text = "Tên người dùng bao gồm chữ hoặc số không có khoảng trắng và kí tự đặc biệt";
                    lblResultUsername.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Lỗi vui lòng kiểm tra lại!");
            }
            //if ((txtOldPass.Text == "" && txtNewPass.Text == "" && txtReNewPass.Text == "") && txtUsername.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            //    lblResultOldPass.Text = "Vui lòng nhập đầy đủ mật khẩu!";
            //    lblResultOldPass.Visible = true;
            //}
            //else
            //{
            //    if (bll.CheckFormatUserName(txtUsername.Text))
            //    {
            //        if (bll.CheckPass(txtOldPass.Text))
            //        {
            //            if (txtNewPass.Text != txtReNewPass.Text)
            //            {
            //                lblResultRePass.Text = "Mật khẩu không trùng khớp với nhau!";
            //                lblResultRePass.Visible = true;
            //            }
            //            else
            //            {
            //                if (bll.CheckFormatPass(txtNewPass.Text))
            //                {
            //                    bll.SavePass(txtNewPass.Text, txtUsername.Text);
            //                    MessageBox.Show("Đổi mật khẩu thành công!");
            //                    GUIUsers();
            //                }
            //                else
            //                {
            //                    lblResultNewPass.Text = "Mật khẩu phải từ 1-16 kí tự. Chỉ bao gồm chữ và số không được có kí tự đặc biệt!";
            //                    lblResultNewPass.Visible = true;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Mật khẩu sai! Vui lòng nhập lại");
            //            lblResultOldPass.Text = "Mật khẩu sai! Vui lòng nhập lại";
            //            lblResultOldPass.Visible = true;
            //        }
            //    }
            //    else
            //    {
            //        lblResultUsername.Visible = true;
            //    }
            //}
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatPass(txtNewPass.Text))
            {
                lblResultNewPass.Visible = false;
            }
            else
            {
                lblResultNewPass.Visible=true;
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            lblResultOldPass.Visible=false;
        }

        private void txtReNewPass_TextChanged(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatPass(txtReNewPass.Text))
            {
                lblResultRePass.Visible = false;
            }
            else
            {
                lblResultRePass.Text = "Mật khẩu phải từ 1-16 kí tự. Chỉ bao gồm chữ và số không được có kí tự đặc biệt!";
                lblResultRePass.Visible = true;
            }
        }

        private void btViewPass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.PasswordChar == '*')
                txtOldPass.PasswordChar = '\0';
            else
                txtOldPass.PasswordChar = '*';
        }

        private void btnNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '*')
                txtNewPass.PasswordChar = '\0';
            else
                txtNewPass.PasswordChar = '*';
        }

        private void btnViewRePass_Click(object sender, EventArgs e)
        {
            if (txtReNewPass.PasswordChar == '*')
                txtReNewPass.PasswordChar = '\0';
            else
                txtReNewPass.PasswordChar = '*';
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = tcInfor.SelectedIndex;
            if (i==0)
            {
                LoadInfor();
            }
            else if(i==1)
            {
                GUIUsers();
            }
        }
        private void GUIUsers()
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            DTO_Staff result = bll.GetInforStaff();
            if(result != null)
            {
                txtUsername.Text = result.staff_usename;
            }
            txtNewPass.Text = "";
            txtOldPass.Text = "";
            txtReNewPass.Text = "";
            lblResultNewPass.Visible = false;
            lblResultOldPass.Visible = false;
            lblResultRePass.Visible = false;
            lblResultUsername.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (txtNameStaff.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtUsername.Text != "")
            {
                if (bll.CheckFormatPhone(txtPhone.Text) && bll.CheckFormatBirthday(dtpBirthday.Value) && bll.CheckFormatNameStaff(txtNameStaff.Text))
                {
                    DTO_Staff staff = new DTO_Staff();
                    staff.staff_id = bll.GetId();
                    staff.staff_usename = txtUsername.Text;
                    staff.staff_name = txtNameStaff.Text;
                    staff.email = txtEmail.Text;
                    if (cbbGenre.SelectedIndex == 0)
                    {
                        staff.staff_gender = true;
                    }
                    else
                    {
                        staff.staff_gender = false;
                    }
                    staff.staff_phone = txtPhone.Text;
                    staff.staff_birthday = dtpBirthday.Value;
                    bll.SaveInfor(staff);
                    MessageBox.Show("Cập nhật thông tin thành công");
                    LoadInfor();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void txtNameStaff_TextChanged(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatNameStaff(txtNameStaff.Text) == false)
            {
                lblResultName.Visible = true;
            }
            else
            {
                lblResultName.Visible = false;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatPhone(txtPhone.Text) == false)
            {
                lblResultPhone.Visible = true;
            }
            else
            {
                lblResultPhone.Visible = false;
            }
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatBirthday(dtpBirthday.Value) == false)
            {
                lblResultDate.Visible = true;
            }
            else
            {
                lblResultDate.Visible = false;
            }
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            FormChangeMail form=new FormChangeMail(txtEmail.Text);
            form.ShowDialog();
            form.FormClosed += CloseFormLoad;
        }
        private void CloseFormLoad(object sender, EventArgs e)
        {
            //BLL_TBStaff bll=new BLL_TBStaff();
            //DTO_Staff staff = bll.GetInforStaff();
            //txtEmail.ReadOnly=false;
            //txtEmail.Text = staff.email;
            //txtEmail.ReadOnly = true;
            LoadInfor();
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {
            BLL_TBStaff bll = new BLL_TBStaff();
            if (bll.CheckFormatUserName(txtUsername.Text) == false)
            {
                lblResultUsername.Visible = true;
            }
            else
            {
                lblResultUsername.Visible = false;
            }
        }
    }
}
