using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBSeatBooking
    {
        public List<string> GetSeatBooking(int schedule_id)
        {
            DAL_TBSeatBooking dal =new DAL_TBSeatBooking();
            return dal.GetSeatBooking(schedule_id);

        }
        public string GetSeat(List<DTO_TBSeatBooking> list)
        {
            DAL_TBSeatBooking dal = new DAL_TBSeatBooking();
            return dal.GetSeat(list);
        }
        public int GetPrice(int seat_booking_id)
        {
            BLL_TBSchedule bllSchedule=new BLL_TBSchedule();
            BLL_TBMovie bllMovie = new BLL_TBMovie();
            BLL_TBSeat bllSeat = new BLL_TBSeat();
                int result = 0;
            DAL_TBSeatBooking dal = new DAL_TBSeatBooking();
            DTO_SeatBooking seat = dal.GetTBSeatBooking(seat_booking_id);
            if (seat != null)
                {
                    int schedule_price = bllSchedule.GetPrice(seat.schedule_id);
                    int movie_price = bllMovie.GetPrice(bllSchedule.GetMovie_id(seat.schedule_id));
                    int seat_per = bllSeat.GetPricePersent(seat.seat_id);
                    result = schedule_price + movie_price * seat_per / 100;
                }
                return result;


        }
        public List<DTO_TBSeatBooking> SetSeatBooking(string seat, int schedule)
        {

            DAL_TBSeatBooking dal = new DAL_TBSeatBooking();
           return  dal.SetSeatBooking(seat, schedule);
        }
        public void SaveBooking(List<DTO_TBSeatBooking> list)
        {
            DAL_TBSeatBooking dal = new DAL_TBSeatBooking();
             dal.SaveBooking(list);
        }
        public List<DTO_TBSeatBooking> GetListSeatBooking(int receipt_id)
        {
            DAL_TBSeatBooking dal = new DAL_TBSeatBooking();
            return dal.GetListSeatBooking(receipt_id);
        }
    }
}
