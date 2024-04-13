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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormRoomDetail : Form
    {
        List<SeatButton> seats;
        public delegate void FormRoomDetail_Del();
        public FormRoomDetail_Del formRoomDetail_del; //load GUI o UCRoom
        List<string> listSeat;
        public int id_room { get; set; }
        public FormRoomDetail(int id)
        {
            listSeat = new List<string>();  
            InitializeComponent();
            id_room = id;
            GUI(id);
            LoadType();
        }

        private void LoaddCBBRoomType()
        {
            cbbRoomType.Items.Clear();
            BLL_TBRoom bll = new BLL_TBRoom();
            foreach (var i in bll.GetAllRoomTypes())
                cbbRoomType.Items.Add(i);
        }
        private void GUI(int id)
        {
            LoaddCBBRoomType();
            if (id != 0)
            {
                BLL_TBRoom bll = new BLL_TBRoom();
                DTO_Room i = bll.GetRoomByID(id);
                tbRoomName.Text = i.room_name;
                tbSeat.Text = i.room_number_of_seat.ToString();
                tbSeat.Enabled = false;
                tbRow.Text = i.room_number_of_row.ToString();
                tbRow.Enabled = false;
                cbbRoomType.Text = i.room_type.ToString();
                LoadSeatDefault();
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool CheckValidate()
        {
            if (tbRoomName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng");
                return false;
            }
            if (tbSeat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng ghế");
                return false;
            }
            if (tbSeat.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số lượng ghế");
                return false;
            }
            if (tbSeat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên số hàng ghế");
                return false;
            }
            if (tbRow.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số lượng hàng ghế");
                return false;
            }
            if (cbbRoomType.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại phòng");
                return false;
            }
            if(id_room==0)
            {
                if (pnSeat.Controls.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm ghế");
                    return false;
                }
                if (pnSeat.Controls.Count > 0)
                {
                    foreach (SeatButton btn in pnSeat.Controls)
                    {
                        if (btn.check == false)
                        {
                            return false;
                        }
                    }
                }
            }          
            return true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                List<DTO_Seat> seats = new List<DTO_Seat>();
                if(id_room==0)
                {
                    seats = GetListSeats();
                }
               
                BLL_TBRoom bll = new BLL_TBRoom();
                DTO_Room i = new DTO_Room
                {
                    room_id = id_room,
                    room_name = tbRoomName.Text,
                    room_type = (DTO_CBBRoomType)(cbbRoomType.SelectedItem),
                    room_number_of_seat = Convert.ToInt32(tbSeat.Text),
                    room_number_of_row = Convert.ToInt32(tbRow.Text),
                };
                string message = "";
                if (bll.AddOrUpdateRoom(i, ref message, seats) == false)
                {
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show(message);
                    formRoomDetail_del();
                    Close();
                }
            }
        }


        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn chắc chắn muốn xóa phòng này?", "Xóa phòng", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                BLL_TBRoom bll = new BLL_TBRoom();
                if (bll.DeleteRoom(id_room))
                {
                    MessageBox.Show("Xóa thành công");
                    formRoomDetail_del();
                }
                else
                {
                    MessageBox.Show("Không thể xóa. Tồn tại lịch chiếu ở phòng này");
                }
            }

            Close();
        }

        public void LoadSeatDefault()
        {
            if (id_room != 0)
            {
                BLL_TBRoom bllRoom = new BLL_TBRoom();
                DTO_TBRoom room = bllRoom.GetRoom(id_room);
                int sum = room.room_number_of_seat;
                int row = room.room_number_of_row;
                int col = sum / row;
                int sur = sum % row;
                int x = 20;
                int y = 20;
                int t = 65;
                int i, j;
                for (j = 1; j <= row; j++)
                {
                    for (i = 1; i <= col; i++)
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
                        SeatButton btn = new SeatButton(text, room.room_id);
                        btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
                        btn.Left = x;
                        btn.Top = y;
                        pnSeat.Controls.Add(btn);
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
                        SeatButton btn = new SeatButton(text, room.room_id);
                        btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
                        btn.Left = x;
                        btn.Top = y;
                        pnSeat.Controls.Add(btn);
                        sur--;
                    }
                    t++;
                    y += 50 + 5;
                    x = 20;
                }
            }
        }
        //public void LoadSeatDefault()
        //{
        //    if (id_room != 0)
        //    {
        //        BLL_TBRoom bllRoom=new BLL_TBRoom();
        //        DTO_TBRoom room=bllRoom.GetRoom(id_room);
        //        int sum = room.room_number_of_seat;
        //        int row = room.room_number_of_row;
        //        int col = sum / row;
        //        int sur = sum % row;
        //        int x = 20;
        //        int y = 20;
        //        int t = 65;
        //        for (int j = 1; j <= row; j++)
        //        {
        //            for (int i = 1; i <= col; i++)
        //            {
        //                char tx = Convert.ToChar(t);
        //                string text;
        //                if (i < 10)
        //                {
        //                    text = tx + "0" + i;
        //                }
        //                else
        //                {
        //                    text = tx + "" + i;
        //                }
        //                SeatButton btn = new SeatButton(text, room.room_id);
        //                btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
        //                btn.Left = x;
        //                btn.Top = y;
        //                pnSeat.Controls.Add(btn);
        //                x += 50 + 5;
        //            }
        //            t++;
        //            y += 50 + 5;
        //            x = 20;
        //        }
        //        if (sur != 0)
        //        {
        //            x = 20;
        //            for (int i = 1; i <= sur; i++)
        //            {
        //                char tx = Convert.ToChar(t);
        //                string text = tx + "" + i;
        //                SeatButton btn = new SeatButton(text, room.room_id);
        //                btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
        //                btn.Left = x;
        //                btn.Top = y;
        //                pnSeat.Controls.Add(btn);
        //                x += 50 + 5;
        //            }
        //        }
        //    }
        //}
        //public void LoadSeat()
        //{
        //    if(pnSeat.Controls.Count > 0)
        //    {
        //        pnSeat.Controls.Clear();
        //    }
        //    if(listSeat.Count > 0)
        //    {
        //        listSeat.Clear();
        //    }
        //    if (Regex.IsMatch(tbSeat.Text, @"^[0-9]") && Regex.IsMatch(tbRow.Text, @"^[0-9]") && tbSeat.Text != "" && tbRow.Text != "" && int.Parse(tbRow.Text) != 0 && int.Parse(tbSeat.Text) != 0)
        //    {
        //        int sum = int.Parse(tbSeat.Text);
        //        int row = int.Parse(tbRow.Text);
        //        int col = sum / row;
        //        int sur = sum % row;
        //        int x = 20;
        //        int y = 20;
        //        int t = 65;
        //        for (int j = 1; j <= row; j++)
        //        {
        //            for (int i = 1; i <= col; i++)
        //            {
        //                char tx = Convert.ToChar(t);
        //                string text;
        //                if (i < 10)
        //                {
        //                    text = tx + "0" + i;
        //                }
        //                else
        //                {
        //                    text = tx + "" + i;
        //                }
        //                SeatButton btn = new SeatButton(text);
        //                btn.Left = x;
        //                btn.Top = y;
        //                //btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
        //                pnSeat.Controls.Add(btn);

        //                x += 50 + 5;
        //            }
        //            t++;
        //            y += 50 + 5;
        //            x = 20;
        //        }
        //        if (sur != 0)
        //        {
        //            x = 20;
        //            for (int i = 1; i <= sur; i++)
        //            {
        //                char tx = Convert.ToChar(t);
        //                string text = tx + "" + i;
        //                SeatButton btn = new SeatButton(text);

        //                btn.Left = x;
        //                btn.Top = y;
        //                //btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
        //                pnSeat.Controls.Add(btn);
        //                x += 50 + 5;
        //            }
        //        }
        //    }



        //}
        public void LoadSeat()
        {
            if (pnSeat.Controls.Count > 0)
            {
                pnSeat.Controls.Clear();
            }
            if (listSeat.Count > 0)
            {
                listSeat.Clear();
            }
            if (Regex.IsMatch(tbSeat.Text, @"^[0-9]") && Regex.IsMatch(tbRow.Text, @"^[0-9]") && tbSeat.Text != "" && tbRow.Text != "" && int.Parse(tbRow.Text) != 0 && int.Parse(tbSeat.Text) != 0)
            {
                int sum = int.Parse(tbSeat.Text);
                int row = int.Parse(tbRow.Text);
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
                        SeatButton btn = new SeatButton(text);
                        btn.Left = x;
                        btn.Top = y;
                        btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                        pnSeat.Controls.Add(btn);

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
                        SeatButton btn = new SeatButton(text);
                        btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                        btn.Left = x;
                        btn.Top = y;
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
                //        SeatButton btn = new SeatButton(text);

                //        btn.Left = x;
                //        btn.Top = y;
                //        //btn.CheckedChanged += new EventHandler(SeatButton_CheckedChanged);
                //        pnSeat.Controls.Add(btn);
                //        x += 50 + 5;
                //    }
                //}
            }



        }
        public void SeatButton_CheckedChanged(object sender, EventArgs e)
        {
            SeatButton btn= (SeatButton)sender;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LoadSeat();
        }
        public void SeatButton_CLick(object sender, EventArgs e)
        {
            SeatButton btn = (SeatButton)sender;
            btn.isVip = true;
        }

        public void LoadType()
        {
            BLL_TBSeat bll= new BLL_TBSeat();
            List<DTO_Seat_Type> list = new List<DTO_Seat_Type>();
            list = bll.GetListSeatType();
            int x = pnType.Width / 2;
            foreach(DTO_Seat_Type t in list)
            {
                SeatButton btn = new SeatButton(t);
                btn.Left = x;
                btn.Top = 23;
                pnType.Controls.Add(btn);
                btn.Click += SeatTypeClick;
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Font = new Font("Times New Roman", 14f, FontStyle.Regular);
                lbl.ForeColor = Color.Black;
                lbl.Text = "Ghế " + t.seat_type_name;
                lbl.Left = x + btn.Width + 6;
                lbl.Top = 30;
                pnType.Controls.Add(lbl);
                x += btn.Width + lbl.Width + 30;
            }
        }
        public void SeatTypeClick(object sender, EventArgs e)
        {
            SeatButton seat= (SeatButton)sender;
            DTO_Seat_Type type= seat.seattype;
            if(pnSeat.Controls.Count > 0)
            {
                foreach (SeatButton btn in pnSeat.Controls)
                {
                    if (btn.Checked)
                    {
                        btn.Checked = false;
                        btn.FillColor = ColorTranslator.FromHtml("#"+type.seat_type_color);
                        btn.seattype=type;
                        btn.check = true;
                    }
                }
            }
        }
        public List<DTO_Seat> GetListSeats()
        {
                List<DTO_Seat> result= new List<DTO_Seat>();
                foreach(SeatButton btn in pnSeat.Controls)
                {
                result.Add(new DTO_Seat
                {
                    seat_id = -1,
                    room_id = -1,
                    seat_name = btn.Text,
                    seat_type_id=btn.seattype.seat_type_id
                    
                }) ;
                }
                return result;
            
        }

        private void tbSeat_TextChanged_1(object sender, EventArgs e)
        {
            if (tbSeat.Text != "" && tbRow.Text != "" && id_room == 0)
            {
                LoadSeat();
            }
        }

        private void tbSeat_Leave_1(object sender, EventArgs e)
        {
            LoadSeat();
        }

        private void tbRow_Leave_1(object sender, EventArgs e)
        {
            LoadSeat();
        }

        private void tbRow_TextChanged_1(object sender, EventArgs e)
        {
            if (tbSeat.Text != "" && tbRow.Text != "" && id_room == 0)
            {
                LoadSeat();
            }
        }
    }
}
