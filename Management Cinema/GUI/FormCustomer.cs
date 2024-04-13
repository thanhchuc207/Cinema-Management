using BLL;
using DTO;
using Guna3.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3
{
    public partial class FormCustomer : Form
    {
        public delegate void formCustomerAddEdit_Del();
        public formCustomerAddEdit_Del formCustomerAddEdit_del { get; set; }
        public int id_customer { get; set; }
        public FormCustomer(int ID)
        {
            InitializeComponent();
            id_customer = ID;
            if (ID != 0)
                GUI(ID);
            else

            {
                lbID.Visible = false;
                tbID.Visible = false;
                lbIDcross.Visible = false;
                tbPoint.Text = "0";
            }
        }
        private bool CheckFormatPhone(string pn)
        {
            return Regex.IsMatch(pn, "^[0-9]{10}$");
        }
        private bool CheckValidate()
        {
            //sdt
            if (tbName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                return false;
            }
            if (tbPhone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return false;
            }
            if ((tbPhone.Text.Substring(0, 1) != "0") || (!CheckFormatPhone(tbPhone.Text)))
            {
                MessageBox.Show("Vui lòng điền đúng định dạng số điện thoại. \nSố điện thoại cần bao gồm 10 số và bắt đầu bằng số 0");
                return false;
            }
            if (tbAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ");
                return false;
            }
            if (tbPoint.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm tích lũy");
                return false;
            }
            int n;
            if (!int.TryParse(tbPoint.Text, out n))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng điểm tích lũy");
                return false;
            }

            return true;
        }
        private void GUI(int ID)
        {
            BLL_DB bll = new BLL_DB();
            DTO_Customer i = bll.GetCustomer(ID);
            tbID.Text = i.customer_id.ToString();
            tbID.Enabled = false;
            tbName.Text = i.customer_name;
            dtpkBirthday.Value = i.customer_birthday;
            tbPhone.Text = i.customer_phone;
            tbAddress.Text = i.customer_address;
            tbPoint.Text = i.customer_points.ToString();

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (id_customer != 0)
            {
                DialogResult d;
                d = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xóa khách hàng", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    BLL_DB bll = new BLL_DB();
                    bll.DeleteStaff(id_customer);
                    MessageBox.Show("Xóa thành công");
                    formCustomerAddEdit_del();
                }
            }
            Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                BLL_DB bll = new BLL_DB();
                DTO_Customer i = new DTO_Customer
                {
                    customer_id = id_customer,
                    customer_name = tbName.Text,
                    customer_birthday = dtpkBirthday.Value,
                    customer_phone = tbPhone.Text,
                    customer_address = tbAddress.Text,
                    customer_points = Convert.ToInt32(tbPoint.Text),

                };
                string message = "";
                MessageBox.Show(message);
                if (bll.AddOrUpdateCustomer(i, ref message))
                {
                    MessageBox.Show(message);
                    formCustomerAddEdit_del();
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
