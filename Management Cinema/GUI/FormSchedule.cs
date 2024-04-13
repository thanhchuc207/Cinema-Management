using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna3
{
    public partial class FormSchedule : Form
    {
        public delegate void FormScheduleAddEdit_Del(int roomid);
        public FormScheduleAddEdit_Del formScheduleAddEdit_del { get; set; }//load dgv o ucschedule
        int ID { get; set; }
        public FormSchedule(int schedule_id)
        {
            InitializeComponent();
            LoadCBBMovieName();
            LoadCBBRoomName();
            ID = schedule_id;
            GUI(schedule_id);
        }
        private void LoadCBBMovieName()
        {
            BLL_TBMovie bll = new BLL_TBMovie();
            foreach (var i in bll.GetMovieNamesByDate()) //Lay ra movie co release < datetime.now
            {
                cbbMovieName.Items.Add(i);
            }

        }
        private void LoadCBBRoomName()
        {
            BLL_TBRoom bll = new BLL_TBRoom();
            foreach (var i in bll.GetAllRoomNames())
            {
                cbbRoomName.Items.Add(i);
            }
        }
        private void GUI(int schedule_id)
        {

            if (schedule_id != 0)
            {
                BLL_TBSchedule bll = new BLL_TBSchedule();

                DTO_Schedule i = bll.GetScheduleByID(schedule_id);
                cbbMovieName.Text = i.movie.ToString();
                cbbRoomName.Text = i.room.ToString();
                dtpkDate.Text = i.schedule_date.ToString();
                tbDatePrice.Text = i.schedule_price_percent.ToString();
                dtpkTime.Text = i.schedule_start.ToString();

            }
            else
                tbDatePrice.Text = "0";
        }
        private bool CheckValidate()
        {
            if (cbbMovieName.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phim");
                return false;
            }
            if (cbbRoomName.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu");
                return false;
            }
            if (tbDatePrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phụ thu theo ngày chiếu");
                return false;
            }
            if (tbDatePrice.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng phụ thu");
                return false;
            }
            if (string.Compare(dtpkDate.Value.ToShortDateString(), DateTime.Now.ToShortDateString()) == -1)
            {
                MessageBox.Show("Vui lòng tạo lịch chiếu từ ngày hôm nay trở đi");
                return false;
            }
            TimeSpan starttime = new TimeSpan(dtpkTime.Value.Hour, dtpkTime.Value.Minute, dtpkTime.Value.Second);
            if ((string.Compare(dtpkDate.Value.ToShortDateString(), DateTime.Now.ToShortDateString()) == 0)
                   && ((starttime <= DateTime.Now.TimeOfDay)))
            {
                MessageBox.Show("Vui lòng tạo lịch chiếu sau khung giờ hiện tại");
                return false;
            }
            if ((string.Compare(dtpkDate.Value.ToShortDateString(), DateTime.Now.ToShortDateString()) == 0)
                   && ((starttime < DateTime.Now.AddMinutes(30).TimeOfDay)))
            {
                MessageBox.Show("Vui lòng tạo lịch chiếu cách hiện tại ít nhất 30 phút");
                return false;
            }
            return true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                int movieID = ((DTO_CBBMovie)(cbbMovieName.SelectedItem)).movie_id;
                int hour = dtpkTime.Value.Hour; int min = dtpkTime.Value.Minute; int second = dtpkTime.Value.Second;
                TimeSpan starttime_schedule = new TimeSpan(hour, min, second);
                BLL_TBSchedule bllSchedule = new BLL_TBSchedule();
                BLL_TBMovie bllMovie = new BLL_TBMovie();
                DTO_Schedule i = new DTO_Schedule
                {
                    schedule_id = ID,
                    movie = (DTO_CBBMovie)(cbbMovieName.SelectedItem),
                    schedule_date = dtpkDate.Value,
                    schedule_start = starttime_schedule,
                    schedule_end = dtpkTime.Value.AddMinutes(bllMovie.GetMovieLength(movieID) + 15).TimeOfDay,
                    room = (DTO_CBBRoom)(cbbRoomName.SelectedItem),
                    schedule_price_percent = Convert.ToInt32(tbDatePrice.Text),

                };
                string message = "";
                if (bllSchedule.AddOrUpdateSchedule(i, ref message))
                {
                    MessageBox.Show(message);
                    formScheduleAddEdit_del(0);
                    Close();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn chắc chắn muốn xóa lịch chiếu này?", "Xóa lịch chiếu", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                BLL_TBSchedule bll = new BLL_TBSchedule();
                if (bll.DeleteScheduleByID(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    formScheduleAddEdit_del(0);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại. Tồn tại vé đã đặt ở lịch chiếu này");
                }
            }

            Close();
        }
    }
}
