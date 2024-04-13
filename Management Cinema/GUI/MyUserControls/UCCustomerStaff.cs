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
    public partial class UCCustomerStaff : UserControl
    {
        public UCCustomerStaff()
        {
            InitializeComponent();
            LoadDGV();
        }
        public void LoadDGV()
        {
            BLL_TBCustomer db = new BLL_TBCustomer();
            dataGridView1.DataSource = db.GetAllCustomers();

        }
        public void ReloadDataGridView(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormEditCustomer frm = new FormEditCustomer();
            frm.FormClosed += new FormClosedEventHandler(ReloadDataGridView);
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                FormEditCustomer frm = new FormEditCustomer(id);
                frm.FormClosed += new FormClosedEventHandler(ReloadDataGridView);
                frm.ShowDialog();

            }
        }

        private void tbSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchCustomer.Text != "")
            {
                BLL_TBCustomer bll = new BLL_TBCustomer();
                dataGridView1.DataSource = bll.GetCustomerByNameOrID(tbSearchCustomer.Text);
            }
            if (tbSearchCustomer.Text.Length == 0)
            {
                LoadDGV();
            }
        }
    }
}
