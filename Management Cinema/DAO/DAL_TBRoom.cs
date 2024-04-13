using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBRoom
    {
        public List<DTO_CBBRoom> GetAllRoomNames()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBRoom.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBRoom { room_id = p.room_id, room_name = p.room_name });
                return query.ToList();
            }
        }
        public DTO_Room GetRoomByID(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_id == id)
                .Select(p => p).FirstOrDefault();

                var room_type = db.TBRoomType.Where(p => p.is_deleted == false).Where(p => p.room_type_id == s.room_type_id)
                .Select(p => p).FirstOrDefault();
                return new DTO_Room
                {
                    room_id = s.room_id,
                    room_name = s.room_name,
                    room_type = new DTO_CBBRoomType { room_type_id = room_type.room_type_id, room_type_name = room_type.room_type_name, room_type_price = room_type.room_type_price_percent },
                    room_number_of_seat = s.room_number_of_seat,
                    room_number_of_row = s.room_number_of_row,
                };
            }
        }
        public bool CheckSameRoomName(int roomID, string txt)
        {

            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_id != roomID).Where(p => p.room_name == txt).FirstOrDefault();
                if (s != null) return false; //trung, k the dung roomname=txt
                return true;
            }
        }
        public int AddRoom(DTO_Room i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBRoom();
                s.room_name = i.room_name;
                s.room_type_id = i.room_type.room_type_id;
                s.room_number_of_seat = i.room_number_of_seat;
                s.room_number_of_row = i.room_number_of_row;

                db.TBRoom.Add(s);
                db.SaveChanges();
                int x = s.room_id;
                return x;
            }
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
        public bool UpdateRoom(DTO_Room i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //ktra room co lich chieu nao co ve da dat chua
                var schedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.room_id == i.room_id).Select(p => p.schedule_id).ToList();
                foreach (var scheduleID in schedule)
                {
                    if (IsBooking(scheduleID)) return false;
                }

                var s = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_id == i.room_id).FirstOrDefault();

                s.room_name = i.room_name;
                s.room_type_id = i.room_type.room_type_id;
                s.room_number_of_seat = i.room_number_of_seat;
                s.room_number_of_row = i.room_number_of_row;

                db.SaveChanges();
                return true;

            }
        }
        public bool DeleteRoom(int roomID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //ktra co schedule o room nay k
                var schedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.room_id == roomID).FirstOrDefault();
                if (schedule != null) //co schedule o room nay
                {
                    return false;
                }
                else
                {
                    var room = db.TBRoom.Where(p => p.room_id == roomID).FirstOrDefault();
                    room.is_deleted = true;
                    db.SaveChanges();

                    var seat = db.TBSeat.Where(p => p.is_deleted == false).Where(p => p.room_id == roomID).ToList();
                    foreach (var i in seat)
                    {
                        i.is_deleted = true;
                        db.SaveChanges();
                    }
                    return true;
                }
            }
        }
        public DTO_CBBRoomType GetRoomType(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBRoomType.Where(p => p.is_deleted == false).Where(p => p.room_type_id == id)
                     .Select(p => new DTO_CBBRoomType
                     {
                         room_type_id = p.room_type_id,
                         room_type_name = p.room_type_name,
                         room_type_price = p.room_type_price_percent
                     }).FirstOrDefault();
            }
        }
        public bool CheckSameRoomTypeName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBRoomType.Where(p => p.is_deleted == false).Where(p => p.room_type_name == txt).FirstOrDefault();
                if (s != null) return false; //trung, k the dung roomname=txt
                return true;
            }

        }
        public void AddRoomType(DTO_CBBRoomType i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBRoomType();
                s.room_type_name = i.room_type_name;
                s.room_type_price_percent = i.room_type_price;

                db.TBRoomType.Add(s);
                db.SaveChanges();
            }
        }
        public void UpdateRoomType(DTO_CBBRoomType i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBRoomType.Where(p => p.is_deleted == false).Where(p => p.room_type_id == i.room_type_id).FirstOrDefault();

                s.room_type_name = i.room_type_name;
                s.room_type_price_percent = i.room_type_price;

                db.SaveChanges();
            }
        }
        public bool DeleteRoomType(int room_type_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //ktra co room nao co roomtype do k
                var room = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_type_id == room_type_id).FirstOrDefault();
                if (room != null)
                {
                    return false;
                }
                var s = db.TBRoomType.Where(p => p.room_type_id == room_type_id).FirstOrDefault();
                s.is_deleted = true;
                db.SaveChanges();
                return true;
            }
        }
        public List<DTO_CBBRoomType> GetAllRoomTypes()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBRoomType.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBRoomType { room_type_id = p.room_type_id, room_type_name = p.room_type_name, room_type_price = p.room_type_price_percent });
                return query.ToList();
            }
        }
        public List<DTO_RoomType> GetAllRoomType()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBRoomType.Where(p => p.is_deleted == false).Select(p => new DTO_RoomType
                {
                    room_type_id = p.room_type_id,
                    room_type_name = p.room_type_name,
                    room_type_price = p.room_type_price_percent,

                });
                return s.ToList();
            }
        }
        public List<DTO_CBBRoom> GetAllRoomNameByType(int id) //load button room o ucroom
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_type_id == id)
                    .Select(p => new DTO_CBBRoom { room_id = p.room_id, room_name = p.room_name });
                return query.ToList();
            }
        }
        public List<DTO_CBBRoom> GetRoomNameByTypeAndName(int id, string txt) //load button room o ucroom
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_type_id == id).Where(p => p.room_name.Contains(txt))
                    .Select(p => new DTO_CBBRoom { room_id = p.room_id, room_name = p.room_name });
                return query.ToList();
            }
        }
        public DTO_TBRoom GetRoom(int room_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                DTO_TBRoom result = new DTO_TBRoom();
                TBRoom room = db.TBRoom.Where(p => p.room_id == room_id).FirstOrDefault();
                if (room != null)
                {
                    result.room_id = room.room_id;
                    result.room_number_of_row = room.room_number_of_row;
                    result.room_name = room.room_name;
                    result.room_number_of_seat = room.room_number_of_seat;
                    result.room_type_name = room.TBRoomType.room_type_name;
                    result.room_type_price_percent = room.TBRoomType.room_type_price_percent;
                }
                return result;
            }
        }
        public int GetRoomTypeID(int room_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return (int)db.TBRoom.Where(p => p.room_id == room_id).Select(p => p.room_type_id).FirstOrDefault();
            }
        }
        public string GetNameRoom(int room_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                string result = db.TBRoom.Where(p => p.room_id == room_id).Select(p => p.room_name).FirstOrDefault();
                return result;
            }
        }
        public int GetRoomTypePricePercent(int roomType_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int result = db.TBRoomType.Where(p => p.room_type_id == roomType_id).Select(p => p.room_type_price_percent).FirstOrDefault();
                return result;
            }
        }
        public int GetRoomPricePercent(int room_id)
        {
            DAL_TBRoom dal = new DAL_TBRoom();
            int roomTypeID = dal.GetRoomTypeID(room_id);
            int price_percent = this.GetRoomTypePricePercent(roomTypeID);
            return price_percent;
        }
        public string GetRoomTypeName(int room_type_id)
        {
            using(var db = new CINEMAEntities())
            {
                string type=db.TBRoomType.Where(p=>p.is_deleted==false && p.room_type_id==room_type_id).Select(p=>p.room_type_name).FirstOrDefault();
                return type;
            }
        }
        public List<int> GetListRoomType()
        {
            using(var db = new CINEMAEntities())
            {
                List<int > list = new List<int>();
                list=db.TBRoomType.Where(p=>p.is_deleted==false).Select(p=>p.room_type_id).ToList();
                return list;
            }
        }
    }
}
