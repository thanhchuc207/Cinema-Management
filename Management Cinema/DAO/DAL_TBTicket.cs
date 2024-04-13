using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBTicket
    {
        public List<DTO_Ticket> GetListTickets(int receipt_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_Ticket> result = new List<DTO_Ticket>();

                DAL_TBSeatBooking dalSeatBooking = new DAL_TBSeatBooking();
                List<DTO_TBSeatBooking> Seats = dalSeatBooking.GetListSeatBooking(receipt_id);
                foreach (DTO_TBSeatBooking s in Seats)
                {
                    int temp = s.seat_booking_id.GetValueOrDefault();
                    DAL_TBSeat dalSeat = new DAL_TBSeat();
                    DAL_TBSchedule dalSchedule = new DAL_TBSchedule();
                    DAL_TBMovie dalMovie = new DAL_TBMovie();
                    result.Add(new DTO_Ticket
                    {
                        seat_name = dalSeat.GetSeatName(s.seat_id),
                        room_name = dalSeat.GetRoomName(s.seat_id),
                        schedule_date = dalSchedule.GetScheduleDate(s.schedule_id),
                        movie_name = dalMovie.GetNameMovie(dalSchedule.GetMovie_id(s.schedule_id)),
                        ticket_id = s.seat_booking_id.GetValueOrDefault(),
                        schedule_time = dalSchedule.GetShowTimes(s.schedule_id),
                        price = dalSeatBooking.GetPrice(temp),
                        receipt_id = s.receipt_id
                    });
                }
                return result;
            }
        }

    }
}
