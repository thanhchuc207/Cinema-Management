using BLL;
using DTO;
using GUI.MyUserControls;
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

namespace Guna3
{

    public partial class FormMovie : Form
    {
        public delegate void FormMovieAddEdit_Del();
        public FormMovieAddEdit_Del formMovieAddEdit_del { get; set; }
        int ID { get; set; }
        string path_movie { get; set; }
        public FormMovie(int id_movie)
        {
            InitializeComponent();
            LoadCBBMovieGenre();
            ID = id_movie;
            if (id_movie != 0)
                GUI2(id_movie);
        }
        private void LoadCBBMovieGenre()
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            foreach (var i in bll.GetAllMovieGenres())
                cbbMovieGenre.Items.Add(i);
        }
        private void GUI2(int id_movie)
        {
            BLL_TBMovie db = new BLL_TBMovie();
            DTO_Movie i = db.GetMovie(id_movie);
            tbMovieName.Text = i.movie_name.ToString();
            cbbMovieGenre.Text = i.movie_genres.ToString();
            guna2DateTimePicker1.Text = i.movie_release.ToString("yyyy-MM-dd");
            tbLength.Text = i.movie_length.ToString();
            
            tbPrice.Text = i.movie_price.ToString();
            try
            {
                double flPrice = double.Parse(i.movie_price.ToString().Replace(",", ""));
                tbPrice.Text = flPrice.ToString("0,00.##");
                tbPrice.Select(tbPrice.TextLength, 0);
            }
            catch (Exception e2)
            {
            }

            tbDescription.Text = i.movie_description.ToString();

            path_movie = i.movie_image.ToString();
            MoviePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            Image img = Image.FromFile(path_movie);
            MoviePicture.Image = img;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult d;
                d = MessageBox.Show("Bạn chắc chắn muốn xóa phim này?", "Xóa phim", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    BLL_TBMovie bll = new BLL_TBMovie();
                    if (bll.DeleteMovie(ID))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Tồn tại vé đã đặt ở phim này");
                    }
                    formMovieAddEdit_del();
                }
            }
            Close();
        }
        private bool CheckInfor()
        {
            if (tbMovieName.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên phim");
                return false;
            }
            if (cbbMovieGenre.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại phim");
                return false;
            }
            if (tbLength.Text == "")
            {
                MessageBox.Show("Vui lòng điền thời lượng phim");
                return false;
            }
            if (tbLength.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng thời lượng phim");
                return false;
            }
            if (Convert.ToInt32(tbLength.Text) < 1)
            {
                MessageBox.Show("Vui lòng nhập thời lượng phim dài hơn 0 phút");
                return false;
            }
            if (tbPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá vé");
                return false;
            }
            char[] t = tbPrice.Text.ToCharArray();
            string price = "";
            for (int j = 0; j < t.Length; j++)
            {
                if ((t[j] >= '0' && t[j] <= '9'))
                {
                    price += t[j];
                }
                else
                    if (t[j].ToString() != ".")
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng giá tiền");
                    return false;
                }
            }
            if (price.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng giá tiền");
                return false;
            }
            if (Convert.ToInt32(price) < 1)
            {
                MessageBox.Show("Vui lòng nhập giá tiền lớn hơn 0");
                return false;
            }
            if (path_movie == null)
            {
                MessageBox.Show("Vui lòng chọn poster phim");
                return false;
            }
            if (tbDescription.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả phim");
                return false;
            }
            return true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckInfor())
            {
                char[] t = tbPrice.Text.ToCharArray();
                string price = "";
                for (int j = 0; j < t.Length; j++)
                {
                    if (t[j] >= '0' && t[j] <= '9')
                    {
                        price += t[j];
                    }
                }
                BLL_TBMovie bll = new BLL_TBMovie();
                DTO_Movie i = new DTO_Movie
                {
                    movie_id = ID,
                    movie_name = tbMovieName.Text,
                    movie_genres = (DTO_CBBMovieGenre)(cbbMovieGenre.SelectedItem),
                    movie_description = tbDescription.Text,
                    movie_length = Convert.ToInt32(tbLength.Text),
                    movie_release = Convert.ToDateTime(guna2DateTimePicker1.Text),
                    movie_image = path_movie,
                    movie_price = Convert.ToInt32(price),
                };
                string message = "";
                if(bll.AddOrUpdateMovie(i,ref message))
                {
                    MessageBox.Show(message);
                    formMovieAddEdit_del();
                }
                else
                {
                    MessageBox.Show(message);
                }
                Close();

            }
        }

        private void MoviePicture_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                path_movie = openFileDialog1.FileName;
                MoviePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                MoviePicture.Image = Image.FromFile(path_movie);

            }
            catch (System.IO.FileNotFoundException e1)
            {
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbPrice_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double flPrice = double.Parse(tbPrice.Text.Replace(",", ""));
                tbPrice.Text = flPrice.ToString("0,00.##");
                tbPrice.Select(tbPrice.TextLength, 0);
            }
            catch (Exception e2)
            {
            }
        }
    }
}
