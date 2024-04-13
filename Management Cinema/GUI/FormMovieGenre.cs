using BLL;
using Guna.UI2.WinForms;
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
    public partial class FormMovieGenre : Form
    {
        public FormMovieGenre()
        {
            InitializeComponent();
            LoadDGV();
        }
        private void LoadDGV()
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            datagridview1.DataSource=bll.GetAllMovieGenres();

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormMovieGenreDetail f = new FormMovieGenreDetail(0);
            f.formMovieGenreAddEdit_del += new FormMovieGenreDetail.formMovieGenreAddEdit_Del(LoadDGV);
            f.Show();
        }

        private void datagridview1_DoubleClick(object sender, EventArgs e)
        {
            if (datagridview1.SelectedRows.Count == 1)
            {
                FormMovieGenreDetail f = new FormMovieGenreDetail(Convert.ToInt32(datagridview1.CurrentRow.Cells[0].Value.ToString()));
                f.formMovieGenreAddEdit_del += new FormMovieGenreDetail.formMovieGenreAddEdit_Del(LoadDGV);
                f.Show();
            }
        }
    }
}
