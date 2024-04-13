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

namespace GUI
{
    public partial class FormSeatType : Form
    {
        public FormSeatType()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            BLL_TBSeat bll = new BLL_TBSeat();
            dgv.DataSource = bll.GetListCBBSeatType();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                FormSeatTypeDetail f = new FormSeatTypeDetail(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value.ToString()));
                f.formSeatTypeAddEdit_del += new FormSeatTypeDetail.formSeatTypeAddEditDel(LoadDGV);
                f.Show();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
