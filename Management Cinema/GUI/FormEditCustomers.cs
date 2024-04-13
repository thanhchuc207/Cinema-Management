using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormEditCustomers : Form
    {
        
        int Id = -1;
        public FormEditCustomers(int id_customer = -1)
        {
            InitializeComponent();
            if (id_customer != -1)
            {
                this.Id = id_customer;
                LoadCustomer(id_customer);
            }
            else
            {
                lblIdCustomer.Visible = false;
                txtIdCustomer.Visible = false;
            }
        }
        public void LoadCustomer(int id)
        {
            BLL_TBCustomer bll=new BLL_TBCustomer();
            DTO_Customer cus = bll.GetCustomer(id);
            if (cus != null)
            {
                txtIdCustomer.Text = cus.customer_id.ToString();
                txtNameCustomer.Text = cus.customer_name;
                txtAddress.Text = cus.customer_address.ToString();
                dtpBirthday.Value = cus.customer_birthday;
                txtPhone.Text = cus.customer_phone;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL_TBCustomer bll = new BLL_TBCustomer();
            DTO_Customer cus = new DTO_Customer();
            if (bll.CheckFormatIsPhone(txtPhone.Text)==true && bll.CheckFormatName(txtNameCustomer.Text)==true && bll.CheckFormatAddress(txtAddress.Text)==true && bll.CheckFormatBirday(dtpBirthday.Value)==true)
            {
                cus.customer_id = Id;
                cus.customer_phone = txtPhone.Text;
                cus.customer_address = txtAddress.Text;
                cus.customer_birthday = dtpBirthday.Value;
                cus.customer_name = txtNameCustomer.Text;
                bll.SaveOrUpdate(cus);


                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho từng thông tin");
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

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            BLL_TBCustomer bll = new BLL_TBCustomer();
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Nhập số điện thoại";
                txtPhone.ForeColor = Color.Silver;
            }
            else
            {
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
            BLL_TBCustomer bll = new BLL_TBCustomer();
            if (txtNameCustomer.Text == "")
            {
                txtNameCustomer.Text = "Nhập họ và tên";
                txtNameCustomer.ForeColor = Color.Silver;
            }
            else
            {
                if (bll.CheckFormatName(txtNameCustomer.Text) == false)
                {
                    lblResultName.Visible = true;
                }
                else
                {
                    lblResultName.Visible = false;
                }
            }
        }

        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            BLL_TBCustomer bll = new BLL_TBCustomer();
            DateTime dt=dtpBirthday.Value.Date;
            if (bll.CheckFormatBirday(dt) == false)
            {
                lblResultBirthday.Visible = true;
            }
            else
            {
                lblResultBirthday.Visible = false;
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
            BLL_TBCustomer bll = new BLL_TBCustomer();
            if (txtAddress.Text == "")
            {
                txtAddress.Text = "Nhập địa chỉ";
                txtAddress.ForeColor = Color.Silver;
            }
            else
            {
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
    }
}
