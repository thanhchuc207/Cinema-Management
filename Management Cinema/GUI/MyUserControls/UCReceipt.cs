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
    public partial class UCReceipt : UserControl
    {
        public UCReceipt()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            BLL_TBReceipt bll = new BLL_TBReceipt();
            dgv.DataSource = bll.GetListReceipt();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            int customerID = 0;
            if (dgv.CurrentRow.Cells["customer_id"].Value != null) customerID = Convert.ToInt32(dgv.CurrentRow.Cells["customer_id"].Value);
            if (dgv.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells["receipt_id"].Value);
                FormReceiptDetail form = new FormReceiptDetail(id, customerID);
                form.Show();
            }
        }

        private void tbSearchSchedule_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchSchedule.Text != "")
            {
                BLL_TBReceipt bll = new BLL_TBReceipt();
                dgv.DataSource = bll.GetListReceiptByCustomerStaffReceiptDatetimebooking(tbSearchSchedule.Text);
            }

            if (tbSearchSchedule.Text.Length == 0)
                LoadDGV();
        }
    }
}
