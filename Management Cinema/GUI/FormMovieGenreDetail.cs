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
    public partial class FormMovieGenreDetail : Form
    {
        public delegate void formMovieGenreAddEdit_Del();
        public formMovieGenreAddEdit_Del formMovieGenreAddEdit_del { get; set; }
        public int movie_genre_id { get; set; }
        public string movie_genre_name { get; set; }
        public FormMovieGenreDetail(int movie_genre_ID)
        {
            InitializeComponent();
            movie_genre_id = movie_genre_ID;
            if (movie_genre_ID != 0)
                GUI(movie_genre_id);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void GUI(int ID)
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            DTO_CBBMovieGenre i = bll.GetMovieGenre(ID);
            tbMovieGenre.Text = i.movie_genre_name;

            movie_genre_name = i.movie_genre_name;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbMovieGenre.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại phim");
            }
            else
            {
                BLL_TBMovie bll = new BLL_TBMovie();
                DTO_CBBMovieGenre i = new DTO_CBBMovieGenre
                {
                    movie_genre_id = movie_genre_id,
                    movie_genre_name = tbMovieGenre.Text,
                };
                MessageBox.Show(bll.AddOrUpdateMovieGenre(i, movie_genre_name));
                formMovieGenreAddEdit_del();
                Close();
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (movie_genre_id == 0) Close();
            else
            {
                BLL_TBMovie bll = new BLL_TBMovie();
                if(bll.DeleteMovieGenre(movie_genre_id))
                {
                    MessageBox.Show("Xóa thành công");
                    formMovieGenreAddEdit_del();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Tồn tại phim có chứa loại phim này");
                }
                Close();
            }
        }
    }
}
