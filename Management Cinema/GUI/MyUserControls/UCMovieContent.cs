using BLL;
using DTO;
using GUI.Class;
using Guna.UI.WinForms;
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
    public partial class UCMovieContent : UserControl
    {
        DTO_Movie movieDTO;
        public delegate void ShowSchedule(int movie_id, DateTime date);
        public event ShowSchedule Show_Time;
        public UCMovieContent(int id_movie)
        {
            BLL_TBMovie bll =new BLL_TBMovie();
            InitializeComponent();
            movieDTO = new DTO_Movie();
            movieDTO = bll.GetMovie(id_movie);
            LoadUc();
            GUI();
            GUI_Schedule();

        }
        public void LoadUc()
        {
            pbMovieImage.Image = Image.FromFile(movieDTO.movie_image.ToString());
            lblNameMovie.Text = movieDTO.movie_name.ToString();
            lblShowGenges.Text = movieDTO.movie_genres.ToString();
            lblShowRelease.Text = movieDTO.movie_release.ToString("dd/MM/yyyy");
            lblShowLength.Text = movieDTO.movie_length.ToString() + " phút";
            lblDescription.Text= movieDTO.movie_description.ToString();
        }
        public void GUI()
        {
            pnDateMovie.AutoScroll = true;
            GunaHScrollBar hScrollBar = new GunaHScrollBar();
            hScrollBar.Dock = DockStyle.Bottom;
            hScrollBar.Visible = false; // Ẩn thanh cuộn mặc định
            hScrollBar.Minimum = 0;
            hScrollBar.Maximum = pnDateMovie.Width;
            hScrollBar.LargeChange = pnDateMovie.Width / 10;
            hScrollBar.SmallChange = pnDateMovie.Width / 20;
            pnDateMovie.Controls.Add(hScrollBar);
            int x = 20;
            DateTime dateTime = DateTime.Now.Date;

            for (int i = 0; i < 8; i++)
            {
                DateTime temp = dateTime.AddDays(i);
                DayButton btn = new DayButton(temp);
                btn.Left = x;
                btn.Top = (pnDateMovie.Height - btn.Height) / 2;
                pnDateMovie.Controls.Add(btn);
                x += btn.Width + 20;
                btn.Click += new EventHandler(DayButton_Click);
            }

        }
        public void DayButton_Click(object sender, EventArgs e)
        {
            DayButton btn = (DayButton)sender;

            int id = movieDTO.movie_id;
            Show_Time?.Invoke(movieDTO.movie_id, btn.date);
            //Show_Schedule(btn.date, id);

        }
        public void GUI_Schedule()
        {
            BLL_TBRoom room= new BLL_TBRoom();
            List<int> list=room.GetListRoomType();
            if(list.Count > 0)
            {
                int y = 20;
                foreach(int item in list)
                {
                    UCRoomType uc = new UCRoomType(item);
                    uc.Left = 0;
                    uc.Top = y;
                    pnView.Controls.Add(uc);
                    y += uc.Height + 10;
                    Show_Time += uc.ShowSchedule;
                }
            }
        }
        
        public void ShowTimeButton_Click(object sender, EventArgs e)
        {
            ShowtimeButton btn = (ShowtimeButton)sender;
            FormBookChair frm = new FormBookChair(btn.shedule_id);
            FormMainStaff frmStaff = (FormMainStaff)this.ParentForm;
            frm.ShowDialog(frmStaff);

        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            FormMainStaff frm = (FormMainStaff)this.ParentForm;
            UCMovieBooking uc = new UCMovieBooking();
            uc.ChangedUC += frm.ReloadUC;
            frm.ReloadUC(uc, this);
        }
    }
}
