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

namespace GUI.MyUserControls
{
    public partial class UCMoviePictureStaff : UserControl
    {
        int id;
        public delegate void LoadMovie(int id);
        public event LoadMovie GetUC;

        public UCMoviePictureStaff(int movie_id)
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            InitializeComponent();
            id = movie_id;
            txtNameMovie.Text = bll.GetNameMovie(movie_id);
            string local = bll.GetImageMovie(movie_id);
            btnImageMovie.Image = Image.FromFile(local);

        }
        private void btnImageMovie_Click_1(object sender, EventArgs e)
        {
            GetUC?.Invoke(id);
        }
    }
}
