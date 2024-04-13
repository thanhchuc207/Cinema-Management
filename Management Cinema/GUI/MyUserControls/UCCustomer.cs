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

namespace Guna3.UC
{
    public partial class UCCustomer : UserControl
    {
        public UCCustomer()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
           BLL_TBCustomer db = new BLL_TBCustomer();
           dataGridView1.DataSource = db.GetAllCustomers();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                
                FormCustomer form = new FormCustomer(ID);
                form.formCustomerAddEdit_del += new FormCustomer.formCustomerAddEdit_Del(LoadDGV);
                form.Show();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormCustomer form = new FormCustomer(0);
            form.formCustomerAddEdit_del += new FormCustomer.formCustomerAddEdit_Del(LoadDGV);
            form.Show();
        }

        private void tbSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if(tbSearchCustomer.Text!="")
            {
                BLL_TBCustomer bll = new BLL_TBCustomer();
                dataGridView1.DataSource=bll.GetCustomerByNameOrID(tbSearchCustomer.Text);
            }
            if (tbSearchCustomer.Text.Length==0)
            {
                LoadDGV();  
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult d;
                d = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Xóa khách hàng", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    BLL_TBCustomer bll = new BLL_TBCustomer();
                    bll.DeleteCustomer(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    MessageBox.Show("Xóa thành công");
                    LoadDGV();
                }
            }
        }
    }
}
