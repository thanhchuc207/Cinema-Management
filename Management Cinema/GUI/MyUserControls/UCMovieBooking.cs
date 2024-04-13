
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyUserControls
{
    public partial class UCMovieBooking : UserControl
    {
        public event myDel ChangedUC;
       
        public UCMovieBooking()
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            InitializeComponent();
            LoadSeat(bll.GetListMovie_id());
            SetCBB();
            cbbGenges.SelectedIndex = 0;

        }
        public void LoadSeat(List<int> movies)
        {
            if(pnMovie.Controls.Count > 0)
            {
                pnMovie.Controls.Clear();
            }
           
            int x = 20, y = 20, i = 0;
            foreach (int movie in movies)
            {
                UCMoviePictureStaff uc = new UCMoviePictureStaff(movie);
                if (i == 3)
                {
                    x = 20;
                    y += uc.Height + 20;
                    i = 0;
                }
                uc.Location = new Point(x, y);
                uc.GetUC += LoadUC;
                pnMovie.Controls.Add(uc);
                x += uc.Width + 20;
                i++;
            }
        }
        public void LoadUC(int id)
        {
            UCMovieContent uc = new UCMovieContent(id);
            ChangedUC?.Invoke(uc, this);
        }

        private void gunaLineTextBox1_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm phim")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            BLL_TBMovie bllMovie = new BLL_TBMovie();
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm phim";
                txtSearch.ForeColor = Color.Gray;
            }
            else
            {
                pnMovie.Controls.Clear();
                List<int> list = bllMovie.GetMovieByName(txtSearch.Text);
                LoadSeat(list);
            }

        }

        
        public void SetCBB()
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            List<DTO_CBBMovieGenre> list = new List<DTO_CBBMovieGenre>();
            list.Add(new DTO_CBBMovieGenre
            {
                movie_genre_id = -1,
                movie_genre_name = "The Loai",
                
            });
            List<DTO_CBBMovieGenre> temp = bll.GetListMovieGenre();
            foreach(DTO_CBBMovieGenre item in temp)
            {
                list.Add(item);
            }
            cbbGenges.DataSource = list;

        }

        private void cbbGenges_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Tìm kiếm phim";
            BLL_TBMovie bll = new BLL_TBMovie();
            if (cbbGenges.SelectedIndex == 0)
            {
                LoadSeat(bll.GetListMovie_id());
            }
            else
            {
                int i = ((DTO_CBBMovieGenre)cbbGenges.SelectedItem).movie_genre_id;
                DTO_CBBMovieGenre genre = cbbGenges.SelectedItem as DTO_CBBMovieGenre;
                LoadSeat(bll.GetMovieByMovieGenres(genre));

            }

        }

        

        private void UCMovieBooking_Load(object sender, EventArgs e)
        {
            BLL_TBMovie bllMovie= new BLL_TBMovie();
            LoadSeat(bllMovie.GetListMovie_id());
            SetCBB();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                BLL_TBMovie bll = new BLL_TBMovie();
                pnMovie.Controls.Clear();
                List<int> list = bll.GetMovieByName(txtSearch.Text);
                LoadSeat(list);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BLL_TBMovie bllMovie = new BLL_TBMovie();
            LoadSeat(bllMovie.GetListMovie_id());
            SetCBB();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                BLL_TBMovie bll = new BLL_TBMovie();
                pnMovie.Controls.Clear();
                List<int> list = bll.GetMovieByName(txtSearch.Text);
                LoadSeat(list);
            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            cbbGenges.SelectedIndex = 0;
        }
        public void ClearPanel()
        {
            while(pnMovie.Controls.Count > 0)
            {
                Control c = pnMovie.Controls[0];
                pnMovie.Controls.RemoveAt(0);
                c.Dispose();
            }
        }
    }
}
