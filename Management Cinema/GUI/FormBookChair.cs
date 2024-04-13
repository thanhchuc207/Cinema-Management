using BLL;
using DTO;
using GUI.Class;
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
    public partial class FormBookChair : Form
    {
        public int price { get; set; }
        DTO_TBSchedule temp;
        DTO_Movie movieDTO;
        DTO_TBRoom roomDTO;
        List<DTO_TBSeatBooking> list;

        public FormBookChair()
        {
            InitializeComponent();
        }
        public FormBookChair(int schedule_id)
        {
            InitializeComponent();
            BLL_TBSchedule bllSchedule = new BLL_TBSchedule();
            BLL_TBMovie bllMovie= new BLL_TBMovie();
            BLL_TBRoom bllRoom=new BLL_TBRoom();
            temp = bllSchedule.GetScheduleDTO(schedule_id);
            movieDTO = bllMovie.GetMovie(temp.movie_id);
            roomDTO = bllRoom.GetRoom(temp.room_id);

            LoadSeat(roomDTO, temp);
            lblViewMovie.Text = movieDTO.movie_name;
            lblViewDate.Text = temp.schedule_date.ToString("dd/MM/yyyy");
            lblViewSchedule.Text = temp.schedule_start.ToString("hh\\:mm") + " ~ " + temp.schedule_end.ToString("hh\\:mm");
            lblViewRoom.Text = roomDTO.room_name;
            lblViewSeat.Text = "";
            lblViewSumOfSeat.Text = 0.ToString();
            price = bllSchedule.GetPrice(temp.schedule_id);
            lblViewPrice.Text = price.ToString();
            lblViewSumOfPrice.Text = 0 + "";
            GUISeatType();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();

        }
        public void CloseForm()
        {
            this.Close();
        }
        public void LoadSeat(DTO_TBRoom room, DTO_TBSchedule schedule)
        {
            BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
            List<string> list = bllSeatBooking.GetSeatBooking(schedule.schedule_id);

            int sum = room.room_number_of_seat;
            int row = room.room_number_of_row;
            //int midx = (pnSeat.Width / 2) - 40 / 2;

            int col = sum / row;
            int sur = sum % row;
            int x = 20;
            int y = 20;
            int t = 65;
            for (int j = 1; j <= row; j++)
            {
                for (int i = 1; i <= col; i++)
                {
                    char tx = Convert.ToChar(t);
                    string text;
                    if (i < 10)
                    {
                        text = tx + "0" + i;
                    }
                    else
                    {
                        text = tx + "" + i;
                    }
                    BLL_TBSeat bllSeat = new BLL_TBSeat();

                    SeatButton btn = new SeatButton(text, roomDTO.room_id);
                    btn.Left = x;
                    btn.Top = y;
                    btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                    pnSeat.Controls.Add(btn);
                    bool ck = list.Contains(btn.Text);
                    if (ck == true)
                    {
                        btn.Enabled = false;
                    }
                    x += 50 + 5;
                }
                if (sur != 0)
                {
                    char tx = Convert.ToChar(t);
                    int temp = col + 1;
                    string text;
                    if (temp < 10)
                    {
                        text = tx + "0" + temp;
                    }
                    else
                    {
                        text = tx + "" + temp;
                    }
                    SeatButton btn = new SeatButton(text, roomDTO.room_id);
                    btn.Left = x;
                    btn.Top = y;
                    btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                    pnSeat.Controls.Add(btn);
                    sur--;
                }
                t++;
                y += 50 + 5;
                x = 20;
            }
            //if (sur != 0)
            //{
            //    x = 20;
            //    for (int i = 1; i <= sur; i++)
            //    {
            //        char tx = Convert.ToChar(t);
            //        string text = tx + "" + i;
            //        SeatButton btn = new SeatButton(text, roomDTO.room_id);
            //        btn.Left = x;
            //        btn.Top = y;
            //        btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
            //        pnSeat.Controls.Add(btn);
            //        x += 50 + 5;
            //    }
            //    }
        }
        //public void LoadSeat(DTO_TBRoom room, DTO_TBSchedule schedule)
        //{
        //    BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
        //    List<string> list = bllSeatBooking.GetSeatBooking(schedule.schedule_id);

        //    int sum = room.room_number_of_seat;
        //    int row = room.room_number_of_row;
        //    //int midx = (pnSeat.Width / 2) - 40 / 2;

        //    int col = sum / row;
        //    int sur = sum % row;
        //    int x = 20;
        //    int y = 20;
        //    int t = 65;
        //    for (int j = 1; j <= row; j++)
        //    {
        //        for (int i = 1; i <= col; i++)
        //        {
        //            char tx = Convert.ToChar(t);
        //            string text;
        //            if (i < 10)
        //            {
        //                text = tx + "0" + i;
        //            }
        //            else
        //            {
        //                text = tx + "" + i;
        //            }
        //            BLL_TBSeat bllSeat = new BLL_TBSeat();

        //            SeatButton btn = new SeatButton(text,roomDTO.room_id);
        //            btn.Left = x;
        //            btn.Top = y;
        //            btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
        //            pnSeat.Controls.Add(btn);
        //            bool ck = list.Contains(btn.Text);
        //            if (ck == true)
        //            {
        //                btn.Enabled = false;
        //            }
        //            x += 50 + 5;
        //        }
        //        t++;
        //        y += 50 + 5;
        //        x = 20;
        //    }
        //    if (sur != 0)
        //    {
        //        x = 20;
        //        for (int i = 1; i <= sur; i++)
        //        {
        //            char tx = Convert.ToChar(t);
        //            string text = tx + "" + i;
        //            SeatButton btn = new SeatButton(text, roomDTO.room_id);
        //            btn.Left = x;
        //            btn.Top = y;
        //            btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
        //            pnSeat.Controls.Add(btn);
        //            x += 50 + 5;
        //        }
        //        }
        //    }
        private void SeatButton_CheckedChanged(object sender, EventArgs e)
        {
            BLL_TBSeat bllSeat = new BLL_TBSeat();
            SeatButton btn = (SeatButton)sender;
            if (btn.Checked == true)
            {
                string text = btn.Text;
                lblViewSeat.Text += text + " ";
                int s = int.Parse(lblViewSumOfSeat.Text);
                s++;
                lblViewSumOfSeat.Text = s.ToString();
                int sum = int.Parse(lblViewSumOfPrice.Text);
                int seat_per = bllSeat.GetPricePersent(btn.seat_id);
                sum += price + movieDTO.movie_price * seat_per / 100;
                lblViewSumOfPrice.Text = sum.ToString();
            }
            else
            {
                string text = btn.Text;
                int index = lblViewSeat.Text.IndexOf(text);
                if (index != -1)
                {
                    lblViewSeat.Text = lblViewSeat.Text.Remove(index, btn.Text.Length + 1);
                }
                int s = int.Parse(lblViewSumOfSeat.Text);
                s--;
                lblViewSumOfSeat.Text = s.ToString();
                int sum = int.Parse(lblViewSumOfPrice.Text);
                int seat_per = bllSeat.GetPricePersent(btn.seat_id);
                sum -= price + movieDTO.movie_price * seat_per / 100;
                lblViewSumOfPrice.Text = sum.ToString();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            BLL_TBStaff bllStaff = new BLL_TBStaff();
            DTO_Receipt result = new DTO_Receipt();
            result.staff_id = bllStaff.GetId();
            result.schedule_id = temp.schedule_id;
            result.number_of_tickets = int.Parse(lblViewSumOfSeat.Text);
            result.total_price = int.Parse(lblViewSumOfPrice.Text);

            if (lblViewSeat.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ghế đặt");
                return;
            }
            BLL_TBSeatBooking bllSeatBooking = new BLL_TBSeatBooking();
            List<DTO_TBSeatBooking> list = bllSeatBooking.SetSeatBooking(lblViewSeat.Text.TrimEnd(), temp.schedule_id);
            FormPayment form = new FormPayment(result, list);
            form.ShowDialog(this);

        }

        private void FormBookChair_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMainStaff frm = this.Owner as FormMainStaff;
            if (frm != null)
            {
                frm.LoadForm();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GUISeatType()
        {
            BLL_TBSeat bllSeat= new BLL_TBSeat();
            List<DTO_Seat_Type> list = bllSeat.GetListSeatType();
            int x = pnType.Width / 2;
            foreach(DTO_Seat_Type item in list)
            {
                SeatButton btn = new SeatButton(item);
                btn.Left = x;
                btn.Top = 7;
                pnType.Controls.Add(btn);
                Label lbl=new Label();
                lbl.AutoSize= true;
                lbl.Font = new Font("Times New Roman", 15f, FontStyle.Regular);
                lbl.ForeColor= Color.Black;
                lbl.Text = "Ghế " + item.seat_type_name;
                lbl.Left = x + btn.Width + 6;
                lbl.Top = 14;
                pnType.Controls.Add(lbl);
                x += btn.Width +lbl.Width+ 30;

            }
        }

       
    }
}
