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
    public partial class FormRoomType : Form
    {
        public delegate void FormRoomType_Del();
        public FormRoomType_Del formRoomType_del { get; set; }
        public FormRoomType()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            BLL_TBRoom bll = new BLL_TBRoom();
            guna2DataGridView1.DataSource = bll.GetAllRoomType();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormRoomTypeDetail f = new FormRoomTypeDetail(0);
            f.formRoomTyprAddEdit_del += new FormRoomTypeDetail.formRoomTypeAddEdit_Del(LoadDGV);
            f.Show();
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(guna2DataGridView1.SelectedRows.Count ==1) 
            {
                FormRoomTypeDetail f = new FormRoomTypeDetail(Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value.ToString()));
                f.formRoomTyprAddEdit_del += new FormRoomTypeDetail.formRoomTypeAddEdit_Del(LoadDGV);
                f.Show();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            formRoomType_del();
            Close();
        }
    }
}
