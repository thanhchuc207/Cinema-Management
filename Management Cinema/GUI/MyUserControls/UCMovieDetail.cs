using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI.MyUserControls
{
    public partial class UCMovieDetail : UserControl
    {
        public int id_movie { get; set; }
        public string path_movie { get; set; }
        public DTO_Movie dto_movie 
        {
            get
            {
                return new DTO_Movie
                {
                    movie_id = id_movie,
                    movie_name = tbMovieName.Text,
                    movie_genres = (DTO_CBBMovieGenre)(cbbMovieGenre.SelectedItem),
                    movie_description = tbDescription.Text,
                    movie_length = Convert.ToInt32(tbLength.Text),
                    movie_release = Convert.ToDateTime(tbDate.Text),
                    movie_image = path_movie,
                    movie_price = Convert.ToInt32(tbPrice.Text),  
                };
            }
            private set
            {}
        }
        private void LoadCBBMovieGenre()
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            foreach (var i in bll.GetAllMovieGenres())
                cbbMovieGenre.Items.Add(i);
        }
        public UCMovieDetail(int ID)
        {
            id_movie = ID;
            InitializeComponent();
            LoadCBBMovieGenre();
            if (ID != 0)
                GUI(ID);
        }
        private void GUI(int ID)
        {
            BLL_TBMovie db = new BLL_TBMovie();
            DTO_Movie i = db.GetMovie(ID);
            tbMovieName.Text = i.movie_name.ToString();
            cbbMovieGenre.Text = i.movie_genres.ToString();
            tbDate.Text = i.movie_release.ToString("yyyy-MM-dd");
            tbLength.Text = i.movie_length.ToString();
            tbPrice.Text = i.movie_price.ToString();
            tbDescription.Text=i.movie_description.ToString();

            string path = i.movie_image.ToString();
            MoviePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Image img = Image.FromFile(path);
            MoviePicture.Image = img; 
        }

        private void MoviePicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            path_movie = openFileDialog1.FileName;
            MoviePicture.Image=Image.FromFile(path_movie);
        }
    }
}
