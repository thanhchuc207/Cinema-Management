using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class DAL_TBSeat
    {
        public void AddSeatType(DTO_Seat_Type i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBSeatType();
                s.seat_type_name = i.seat_type_name;
                s.seat_type_price_percent = i.seat_type_price_percent;
                s.seat_type_color = i.seat_type_color;
                s.is_deleted = false;
                db.TBSeatType.Add(s);
                db.SaveChanges();
            }
        }
        public void UpdateSeatType(DTO_Seat_Type i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBSeatType.Where(p => p.seat_type_id == i.seat_type_id).FirstOrDefault();
                s.seat_type_name = i.seat_type_name;
                s.seat_type_price_percent = i.seat_type_price_percent;
                s.seat_type_color = i.seat_type_color;
                db.SaveChanges();
            }
        }
        public DTO_Seat_Type GetSeatType(int ID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBSeatType.Where(p => p.seat_type_id == ID)
                    .Select(p => new DTO_Seat_Type
                    {
                        seat_type_id = p.seat_type_id,
                        seat_type_name = p.seat_type_name,
                        seat_type_price_percent = p.seat_type_price_percent,
                        seat_type_color = p.seat_type_color
                    }).FirstOrDefault();
                return s;
            }
        }
        public List<DTO_CBBSeatType> GetListCBBSeatType()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBSeatType.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBSeatType
                    {
                        seattypeID = p.seat_type_id,
                        seattypeName = p.seat_type_name,
                    });
                return s.ToList();
            }
        }
        public bool DeleteSeatType(int ID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBSeat.Where(p => p.is_deleted == false).Where(p => p.seat_type_id == ID).FirstOrDefault();
                if (s != null) return false;
                else
                {
                    var t = db.TBSeatType.Where(p => p.seat_type_id == ID).FirstOrDefault();
                    t.is_deleted = true;
                    return true;
                }
            }
        }
        public string GetSeatType(string seat_name, int room_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBSeat seat = db.TBSeat.Where(p => (p.seat_name == seat_name && p.room_id == room_id)).FirstOrDefault();
                if (seat != null)
                {
                    if (seat.TBSeatType.seat_type_name == "VIP")
                    {
                        return "VIP";
                    }
                    else
                    {
                        return "Regular";
                    }
                }
                else
                {
                    return "";
                }
            }
        }
        public string GetSeatName(int seat_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                string result = db.TBSeat.Where(p => p.seat_id == seat_id).Select(p => p.seat_name).FirstOrDefault();
                return result;

            }
        }
        public string GetRoomName(int seat_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                string result = db.TBSeat.Where(p => p.seat_id == seat_id).Select(p => p.TBRoom.room_name).FirstOrDefault().ToString();
                return result;
            }
        }
        public int GetSeat_id(string seat_name, int room_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int id = db.TBSeat.Where(p => p.seat_name == seat_name && p.room_id == room_id).Select(p => p.seat_id).FirstOrDefault();
                return id;
            }
        }
        public int GetPricePersent(int seat_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int result = db.TBSeat.Where(p => p.seat_id == seat_id && p.is_deleted==false).Select(p => p.TBSeatType.seat_type_price_percent).FirstOrDefault();
                return result;
            }
        }
        public int GetPricePersent(bool isVip)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                if (isVip)
                {
                    TBSeatType seatType = db.TBSeatType.Where(p => p.seat_type_name.ToString() == "VIP").FirstOrDefault();
                    if (seatType != null)
                    {
                        return seatType.seat_type_price_percent;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    TBSeatType seatType = db.TBSeatType.Where(p => p.seat_type_name.ToString() == "Regular").FirstOrDefault();
                    if (seatType != null)
                    {
                        return seatType.seat_type_price_percent;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
        public void AddListSeat(List<DTO_Seat> list)
        {
            using (var db = new CINEMAEntities())
            {
                List<TBSeat> seats = new List<TBSeat>();
                foreach (DTO_Seat it in list)
                {
                    TBSeat seat = new TBSeat();
                    seat.is_deleted = false;
                    seat.seat_name = it.seat_name;
                    seat.room_id = it.room_id;
                    seat.seat_type_id=it.seat_type_id;
                    seats.Add(seat);
                }
                db.TBSeat.AddRange(seats);
                db.SaveChanges();
            }

        }
        public List<DTO_Seat_Type> GetListSeatType()
        {
            using(var db = new CINEMAEntities())
            {
                List<DTO_Seat_Type> result=new List<DTO_Seat_Type>();
                List<TBSeatType> list = db.TBSeatType.Where(p => p.is_deleted == false).ToList();
                foreach(TBSeatType seatType in list)
                {
                    result.Add(new DTO_Seat_Type
                    {
                        seat_type_id=seatType.seat_type_id,
                        seat_type_color=seatType.seat_type_color,
                        seat_type_name=seatType.seat_type_name,
                        seat_type_price_percent=seatType.seat_type_price_percent
                    });
                }
                return result;
            }
        }
        public int GetIdByName(string name,int room_id)
        {
            using(var db=new CINEMAEntities())
            {
                int id=db.TBSeat.Where(p=>p.is_deleted==false && p.room_id==room_id && p.seat_name==name).Select(p=>p.seat_id).FirstOrDefault();
                return id;
            }
        }
        public string GetColor(int id)
        {
            using (var db = new CINEMAEntities())
            {
                string color = db.TBSeat.Where(p => p.is_deleted == false && p.seat_id==id).Select(p => p.TBSeatType.seat_type_color).FirstOrDefault();
                return color;
            }
        }
    }
}
