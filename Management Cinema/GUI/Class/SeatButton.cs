using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Class
{
    public class SeatButton : Guna2Button
    {
        public bool check=false;
        public bool isVip { get; set; }
        public int seat_id { get; set; }
        public SeatButton(string st,int room_id)
        {
            BLL_TBSeat bll=new BLL_TBSeat();
            //this.Font=new Font("Arial");
            this.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.Size = new Size(50,50);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.seat_id = bll.GetIdByName(st,room_id);
            string color = bll.GetColor(seat_id);
            this.FillColor=ColorTranslator.FromHtml("#"+color);
            this.HoverState.FillColor = Color.FromArgb(22, 155, 20);
            this.HoverState.Font= new Font("Arial", 9, FontStyle.Bold);
            this.Text = st;
            this.BorderRadius = 4;
            this.BackColor = Color.Transparent;
            
        }
        public DTO_Seat_Type seattype { get; set; }
        public SeatButton(DTO_Seat_Type st)
        {
            this.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.Size = new Size(35,35);
            this.FillColor=ColorTranslator.FromHtml("#"+st.seat_type_color);
            this.BorderRadius = 4;
            this.BackColor= Color.Transparent;
            this.seattype = st;
        }
        public SeatButton(string text)
        {
            check = false;
            this.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Size = new Size(50, 50);
            this.FillColor = ColorTranslator.FromHtml("#9C9C9C");
            this.BorderRadius = 4;
            this.BackColor = Color.Transparent;
            this.HoverState.FillColor = Color.FromArgb(22, 155, 20);
            this.Text= text;
        }

    }
}
