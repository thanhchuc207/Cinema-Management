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
    public partial class UCStaff : UserControl
    {
        public UCStaff()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            BLL_TBStaff db = new BLL_TBStaff();
            datagridView1.DataSource = db.GetAllStaffs();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (datagridView1.SelectedRows.Count == 1)
            {
                int ID = Convert.ToInt32(datagridView1.CurrentRow.Cells[0].Value);
                FormStaffEdit form = new FormStaffEdit(ID);
                form.formStaffEdit_del += new FormStaffEdit.formStaffEdit_Del(LoadDGV);
                form.Show();
                LoadDGV();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormStaffAdd form = new FormStaffAdd();
            form.formStaffEdit_del += new FormStaffAdd.formStaffAdd_Del(LoadDGV);
            form.Show();
            LoadDGV();
        }

        private void tbSearchStaff_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchStaff.Text !="")
            {
                BLL_TBStaff db = new BLL_TBStaff();
                datagridView1.DataSource = db.GetStaffByName(tbSearchStaff.Text);
            }
            if (tbSearchStaff.Text.Length == 0)
                LoadDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (datagridView1.SelectedRows.Count == 1)
            {
                DialogResult d;
                d = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Xóa nhân viên", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    BLL_TBStaff bll = new BLL_TBStaff();
                    if (bll.DeleteStaff(Convert.ToInt32(datagridView1.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tài khoản này");
                    }
                }
            }
                
        }

        private void datagridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (datagridView1.Columns[e.ColumnIndex].Name == "staff_gender" && e.Value != null)
            {
                bool genderValue = (bool)e.Value;
                e.Value = genderValue ? "Nữ" : "Nam";
                e.FormattingApplied = true; 
            }
            if (datagridView1.Columns[e.ColumnIndex].Name == "Role" && e.Value != null)
            {
                bool roleValue = (bool)e.Value;
                e.Value = roleValue ? "Quản lý" : "Nhân viên";
                e.FormattingApplied = true;
            }
        }
    }
}
