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

namespace GUI
{
    public partial class FormEditCustomer : Form
    {
        int Id = -1;
        public FormEditCustomer(int id_customer = -1)
        {
            InitializeComponent();
            if (id_customer != -1)
            {
                this.Id = id_customer;
                LoadCustomer(id_customer);
            }
            else
            {
                dtpBirthday.Value=DateTime.Now;
                lblIdCustomer.Visible = false;
                txtIdCustomer.Visible = false;
            }
        }
        public void LoadCustomer(int id)
        {
            BLL_TBCustomer customer = new BLL_TBCustomer();
            DTO_Customer cus = customer.GetCustomer(id);
            if (cus != null)
            {
                txtIdCustomer.Text = cus.customer_id.ToString();
                txtNameCustomer.Text = cus.customer_name;
                txtAddress.Text = cus.customer_address.ToString();
                dtpBirthday.Value = cus.customer_birthday;
                txtPhone.Text = cus.customer_phone;
            }
        }
        private void txtNameCustomer_Enter(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "Nhập họ và tên")
            {
                txtNameCustomer.Text = "";
                txtNameCustomer.ForeColor = Color.Black;
            }
        }

        private void txtNameCustomer_Leave(object sender, EventArgs e)
        {
            if (txtNameCustomer.Text == "")
            {
                txtNameCustomer.Text = "Nhập họ và tên";
                txtNameCustomer.ForeColor = Color.Silver;
            }
            else
            {
                BLL_TBCustomer bllCus=new BLL_TBCustomer();
                if (bllCus.CheckFormatName(txtNameCustomer.Text) == false)
                {
                    lblResultName.Visible = true;
                }
                else
                {
                    lblResultName.Visible = false;
                }
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Nhập địa chỉ")
            {
                txtAddress.Text = "";
                txtAddress.ForeColor = Color.Black;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Nhập địa chỉ";
                txtAddress.ForeColor = Color.Silver;
            }
            else
            {
                BLL_TBCustomer bll = new BLL_TBCustomer();
                if (bll.CheckFormatAddress(txtAddress.Text) == false)
                {
                    lblResultAddress.Visible = true;
                }
                else
                {
                    lblResultAddress.Visible = false;
                }
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Nhập số điện thoại";
                txtPhone.ForeColor = Color.Silver;
            }
            else
            {
                BLL_TBCustomer bll = new BLL_TBCustomer();
                if (bll.CheckFormatIsPhone(txtPhone.Text) == false)
                {
                    lblResultPhone.Visible = true;
                }
                else
                {
                    lblResultPhone.Visible = false;
                }
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Nhập số điện thoại")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_TBCustomer bll = new BLL_TBCustomer();
            if(bll.CheckFormatIsPhone(txtPhone.Text) == true && bll.CheckFormatAddress(txtAddress.Text) == true && bll.CheckFormatName(txtNameCustomer.Text) == true && bll.CheckFormatBirday(dtpBirthday.Value) == true)
            {
                if(Id==-1)
                {
                    bool check = bll.CheckPhone(txtPhone.Text);
                    if(check==true)
                    {
                        MessageBox.Show("Số điện thoại đã có người đăng kí");
                    }
                    else
                    {
                        DTO_Customer cus = new DTO_Customer();
                        cus.customer_id = Id;
                        cus.customer_phone = txtPhone.Text;
                        cus.customer_address = txtAddress.Text;
                        cus.customer_birthday = dtpBirthday.Value;
                        cus.customer_name = txtNameCustomer.Text;
                        bll.SaveOrUpdate(cus);
                        this.Close();
                    }
                }
                else
                {
                    DTO_Customer cus = new DTO_Customer();
                    cus.customer_id = Id;
                    cus.customer_phone = txtPhone.Text;
                    cus.customer_address = txtAddress.Text;
                    cus.customer_birthday = dtpBirthday.Value;
                    cus.customer_name = txtNameCustomer.Text;
                    bll.SaveOrUpdate(cus);
                    this.Close();
                }    
                
            }
            else
            {
                MessageBox.Show("Sai định dạng vui lòng kiểm tra");
            }
            
        }

        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            BLL_TBCustomer cus = new BLL_TBCustomer();
            if (cus.CheckFormatBirday(dtpBirthday.Value) == false)
            {
                lblResultBirthday.Visible = true;
            }
            else
            {
                lblResultBirthday.Visible = false;
            }
            
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
