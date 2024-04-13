using BLL;
using GUI;
using GUI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3.UC
{
    public partial class UCMovie : UserControl
    {
        public UCMovie()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            //toa do gan cho hang panel tren
            panel1.Controls.Clear();
            int x1 = 20;
            int y1 = 55;

            BLL_TBMovie bll = new BLL_TBMovie();
            int countPiture = 1;
            foreach (var item in bll.GetAllMoviePictures())
            {
                Panel panel = new Panel();
                panel.Height = 226;
                panel.Width = 196;

                if (countPiture == 5)
                {
                    countPiture = 1;
                    x1 = 20; y1 += 265;
                    panel.Location = new Point(x1, y1);
                    x1 += 250;
                }
                else
                {
                    panel.Location = new Point(x1, y1);
                    x1 += 250;
                }
                panel.Visible = true;
                panel1.Controls.Add(panel);


                int id_movie = item.id_movie;
                string path = item.path_image;
                ImagePicturebox img = new ImagePicturebox(this,id_movie, path);
                
                panel.Controls.Add(img);
                countPiture++;
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {

            FormMovie form = new FormMovie( 0);
            form.formMovieAddEdit_del += new FormMovie.FormMovieAddEdit_Del(GUI);
            form.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            GUI();
        }



        private void tbSearchMovie_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchMovie.Text != "")
            {
                panel1.Controls.Clear();
                int x1 = 40;
                int y1 = 5;

                int x2 = 40;
                int y2 = 240;
                BLL_TBMovie bll = new BLL_TBMovie();
                int countPiture = 0;
                foreach (var item in bll.GetMoviePicturesByName(tbSearchMovie.Text))
                {
                    Panel panel = new Panel();
                    panel.Height = 226;
                    panel.Width = 196;
                    if (countPiture % 2 == 0)
                    {
                        panel.Location = new Point(x1, y1);
                        x1 += 250;
                    }
                    else
                    {
                        panel.Location = new Point(x2, y2);
                        x2 += 250;
                    }
                    panel.Visible = true;
                    panel1.Controls.Add(panel);


                    int id_movie = item.id_movie;
                    string path = item.path_image;
                    ImagePicturebox img = new ImagePicturebox(this, id_movie, path);

                    panel.Controls.Add(img);
                    countPiture++;
                }
            }

            if (tbSearchMovie.Text.Length == 0)
            {
                GUI();
            }
        }

        private void btMovieGenre_Click(object sender, EventArgs e)
        {
            FormMovieGenre f = new FormMovieGenre();
            f.Show();
        }
    }
}
