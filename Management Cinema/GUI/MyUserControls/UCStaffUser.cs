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
    public partial class UCStaffUser : UserControl
    {
        public UCStaffUser()
        {
            InitializeComponent();
            LoadData();

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor = Color.Gray;
            }
        }
        public void LoadData()
        {
            BLL_TBCustomer bll=new BLL_TBCustomer();
            List<DTO_Customer> list = bll.GetListCustomers();
            dtvUser.DataSource = list;

        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BLL_TBCustomer bllCus=new BLL_TBCustomer();
            if (txtSearch.Text != "")
            {
                bool ck = bllCus.CheckFormatIsPhone(txtSearch.Text);
                if (ck)
                {
                    DTO_Customer cus = bllCus.GetTBCustomerDTO(txtSearch.Text);
                    if (cus != null)
                    {
                        List<DTO_Customer> result = new List<DTO_Customer>();
                        result.Add(cus);
                        dtvUser.DataSource = result;
                    }
                }
                else
                {
                    List<DTO_Customer> result = bllCus.GetListCustomers(txtSearch.Text);
                    if (result != null)
                    {
                        dtvUser.DataSource = result;
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dtvUser.CurrentRow;
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                FormEditCustomers frm = new FormEditCustomers(id);
                frm.FormClosed += new FormClosedEventHandler(ReloadDataGridView);
                frm.ShowDialog();

            }
        }
        public void ReloadDataGridView(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditCustomers frm = new FormEditCustomers();
            frm.FormClosed += new FormClosedEventHandler(ReloadDataGridView);
            frm.ShowDialog();
        }
    }
}
