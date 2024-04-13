using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Guna3;
using Guna3.UC;

namespace GUI.Class
{
    public class ImagePicturebox : PictureBox
    {
        public int id_movie { get; set; }
        UCMovie ucmovie { get; set; }
        public ImagePicturebox(UCMovie u,int ID, string path)
        {
            ucmovie = u;
            this.id_movie = ID;
            this.Height = 226;
            this.Width = 196;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = Image.FromFile(path);
        }
        protected override void OnDoubleClick(EventArgs e)
        {

            base.OnDoubleClick(e);
            FormMovie form = new FormMovie(id_movie);
            form.formMovieAddEdit_del += new FormMovie.FormMovieAddEdit_Del(ucmovie.GUI);
            form.Show();
        }
    }
}
