using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBSeatBooking
    {
        public DTO_SeatBooking GetTBSeatBooking(int seat_booking_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBSeatBooking sb= db.TBSeatBooking.Where(p=>p.seat_booking_id==seat_booking_id).FirstOrDefault();
                DTO_SeatBooking seat=new DTO_SeatBooking();
                seat.schedule_id = sb.TBSchedule.schedule_id;
                seat.seat_id = sb.seat_id;
                seat.seat_booking_id=sb.seat_booking_id;
                seat.receipt_id = sb.receipt_id;

               return  seat;
            }
                
        }
        public List<string> GetSeatBooking(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<string> list = new List<string>();
                List<TBSeatBooking> temp = db.TBSeatBooking.Where(p => p.schedule_id == schedule_id).ToList();
                foreach (TBSeatBooking b in temp)
                {
                    string result = b.TBSeat.seat_name;
                    list.Add(result);
                }
                return list;
            }

        }
        public string GetSeat(List<DTO_TBSeatBooking> list)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                DAL_TBSeat dal = new DAL_TBSeat();
                string result = "";
                foreach (DTO_TBSeatBooking b in list)
                {
                    result += dal.GetSeatName(b.seat_id) + " ";
                }
                return result;
            }

        }
        public List<DTO_TBSeatBooking> SetSeatBooking(string seat, int schedule)
        {
            DAL_TBSchedule dalSchedule =new DAL_TBSchedule();
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int room_id = dalSchedule.GetRoomId(schedule);
                List<DTO_TBSeatBooking> list = new List<DTO_TBSeatBooking>();
                List<string> temp = seat.Split(' ').ToList();
                foreach (string i in temp)
                {
                    DAL_TBSeat dal = new DAL_TBSeat();
                    list.Add(new DTO_TBSeatBooking
                    {
                        seat_id = dal.GetSeat_id(i, room_id),
                        schedule_id = schedule,

                    });
                }
                return list;
            }

        }
        public void SaveBooking(List<DTO_TBSeatBooking> list)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                foreach (DTO_TBSeatBooking b in list)
                {
                    TBSeatBooking result = new TBSeatBooking
                    {
                        seat_id = b.seat_id,
                        receipt_id = b.receipt_id,
                        schedule_id = b.schedule_id,
                        is_deleted = false,

                    };
                    db.TBSeatBooking.Add(result);
                    db.SaveChanges();
                }
            }
        }
        public List<DTO_TBSeatBooking> GetListSeatBooking(int receipt_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_TBSeatBooking> list = new List<DTO_TBSeatBooking>();
                List<TBSeatBooking> result = db.TBSeatBooking.Where(p => p.receipt_id == receipt_id && p.is_deleted == false).ToList();
                foreach (TBSeatBooking i in result)
                {
                    list.Add(new DTO_TBSeatBooking
                    {
                        seat_booking_id = i.seat_booking_id,
                        receipt_id = i.receipt_id,
                        seat_id = i.seat_id,
                        schedule_id = i.TBSchedule.schedule_id,
                    });
                }
                return list;
            }
        }

        public int GetPrice(int seat_booking_id)
        {
            DAL_TBSchedule bllSchedule = new DAL_TBSchedule();
            DAL_TBMovie bllMovie = new DAL_TBMovie();
            DAL_TBSeat bllSeat = new DAL_TBSeat();
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
        public bool IsBooking(int scheduleID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var seatbooking = db.TBSeatBooking.Where(p => p.is_deleted == false).Where(p => p.schedule_id == scheduleID).FirstOrDefault();
                if (seatbooking == null) return false; //chua co ve dat
                else return true;
            }
        }
    }
}
