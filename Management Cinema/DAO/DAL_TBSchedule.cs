using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBSchedule
    {
        public string GetShowTimes(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBSchedule schedule = db.TBSchedule.Where(p => p.schedule_id == schedule_id).FirstOrDefault();
                string temp = schedule.schedule_start.ToString("hh\\:mm") + " ~ " + schedule.schedule_end.ToString("hh\\:mm"); ;
                return temp;
            }
        }
        public int GetMovie_id(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int movie_id = db.TBSchedule.Where(p => p.schedule_id == schedule_id).Select(p => p.movie_id).FirstOrDefault().Value;
                return movie_id;
            }
        }
        public DateTime GetScheduleDate(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                DateTime date = db.TBSchedule.Where(p => p.schedule_id == schedule_id).Select(p => p.schedule_date).FirstOrDefault();
                return date;
            }
        }
        public int GetRoomId(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int room_id = db.TBSchedule.Where(p => p.schedule_id == schedule_id).Select(p => p.room_id).FirstOrDefault();
                return room_id;
            }
        }
        public List<DTO_TBSchedule> GetListSchedule(DateTime date, int movie_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_TBSchedule> list = new List<DTO_TBSchedule>();
                List<TBSchedule> result = db.TBSchedule.Where(p => (p.movie_id == movie_id)).ToList();
                foreach (TBSchedule i in result)
                {
                    if (i.schedule_date.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                    {
                        list.Add(new DTO_TBSchedule
                        {
                            schedule_id = i.schedule_id,
                            schedule_date = i.schedule_date,
                            schedule_start = i.schedule_start,
                            schedule_end = i.schedule_end,
                            movie_id = i.TBMovie.movie_id,
                            room_id = i.TBRoom.room_id,
                            schedule_price_percent = i.schedule_price_percent,
                            room_type = i.TBRoom.TBRoomType.room_type_name == "2D" ? true : false
                        });
                    }
                }
                return list;
            }
        }
        public DTO_TBSchedule GetScheduleDTO(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                DTO_TBSchedule result = new DTO_TBSchedule();
                TBSchedule schedule = db.TBSchedule.Where(p => p.schedule_id == schedule_id).FirstOrDefault();
                if (schedule != null)
                {
                    result.schedule_id = schedule.schedule_id;
                    result.schedule_date = schedule.schedule_date;
                    result.schedule_start = schedule.schedule_start;
                    result.schedule_end = schedule.schedule_end;
                    result.schedule_price_percent = schedule.schedule_price_percent;
                    result.movie_id = schedule.TBMovie.movie_id;
                    result.room_id = schedule.TBRoom.room_id;
                }
                return result;
            }
        }
        public int GetSchedule_PricePercent(int schedule_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int result = db.TBSchedule.Where(p => p.schedule_id == schedule_id).Select(p => p.schedule_price_percent).FirstOrDefault();
                return result;
            }
        }

        public int GetPrice(int schedule_id)
        {
            DAL_TBMovie bllMovie = new DAL_TBMovie();
            DAL_TBRoom bllRoom = new DAL_TBRoom();

            DAL_TBSchedule dal = new DAL_TBSchedule();
            DTO_TBSchedule schedule = dal.GetScheduleDTO(schedule_id);

            int price = 0;
            int movie_price = 0;
            int room_price_percent = 0;
            int schedule_price_percent = 0;

            movie_price = bllMovie.GetPrice(schedule.movie_id);
            room_price_percent = bllRoom.GetRoomPricePercent(schedule.room_id);
            schedule_price_percent = dal.GetSchedule_PricePercent(schedule.schedule_id);

            price = movie_price + movie_price * room_price_percent / 100 + movie_price * schedule_price_percent / 100;
            return price;
        }
        public List<DTO_TBSchedule> GetListSchedule(int movie_id, DateTime date, int room_type_id)
        {
            using (var db = new CINEMAEntities())
            {
                List<DTO_TBSchedule> result = new List<DTO_TBSchedule>();
                List<TBSchedule> list = db.TBSchedule.Where(p => p.is_deleted == false && p.movie_id == movie_id && p.TBRoom.room_type_id == room_type_id).ToList();
                foreach (TBSchedule schedule in list)
                {
                    if (schedule.schedule_date.ToString("dd/MM/yyyy") == date.ToString("dd/MM/yyyy"))
                    {
                        result.Add(new DTO_TBSchedule
                        {
                            schedule_id = schedule.schedule_id,
                            room_id = schedule.room_id,
                            schedule_date = schedule.schedule_date,
                            schedule_start = schedule.schedule_start,
                            schedule_end = schedule.schedule_end,
                            schedule_price_percent = schedule.schedule_price_percent,
                            movie_id = schedule.TBMovie.movie_id
                        });
                    }
                }
                return result;
            }
        }
        public List<DTO_Schedule> GetAllSchedules()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = (from s in db.TBSchedule
                             join c in db.TBMovie on s.movie_id equals c.movie_id
                             join t in db.TBRoom on s.room_id equals t.room_id
                             where s.is_deleted == false
                             where c.is_deleted == false
                             where t.is_deleted == false
                             select new DTO_Schedule
                             {
                                 schedule_id = s.schedule_id,
                                 movie = new DTO_CBBMovie { movie_id = c.movie_id, movie_name = c.movie_name },
                                 schedule_date = s.schedule_date,
                                 schedule_start = s.schedule_start,
                                 schedule_end = s.schedule_end,
                                 room = new DTO_CBBRoom { room_id = t.room_id, room_name = t.room_name, },
                                 schedule_price_percent = s.schedule_price_percent,
                             });
                return query.ToList();

            }
        }
        public List<DTO_Schedule> GetAllScheduleByRoom(int roomID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = (from s in db.TBSchedule
                             join c in db.TBMovie on s.movie_id equals c.movie_id
                             join t in db.TBRoom on s.room_id equals t.room_id
                             where s.is_deleted == false
                             where c.is_deleted == false
                             where t.is_deleted == false
                             where t.room_id == roomID
                             select new DTO_Schedule
                             {
                                 schedule_id = s.schedule_id,
                                 movie = new DTO_CBBMovie { movie_id = c.movie_id, movie_name = c.movie_name },
                                 schedule_date = s.schedule_date,
                                 schedule_start = s.schedule_start,
                                 schedule_end = s.schedule_end,
                                 room = new DTO_CBBRoom { room_id = t.room_id, room_name = t.room_name, },
                                 schedule_price_percent = s.schedule_price_percent,
                             });
                return query.ToList();
            }

        }
        public List<DTO_Schedule> GetSchedulesByMovieDateRoom(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = (from s in db.TBSchedule
                             join c in db.TBMovie on s.movie_id equals c.movie_id
                             join t in db.TBRoom on s.room_id equals t.room_id
                             where s.is_deleted == false
                             where c.is_deleted == false
                             where t.is_deleted == false
                             where (t.room_name.Contains(txt) || c.movie_name.Contains(txt) || s.schedule_date.ToString().Contains(txt))
                             select new DTO_Schedule
                             {
                                 schedule_id = s.schedule_id,
                                 movie = new DTO_CBBMovie { movie_id = c.movie_id, movie_name = c.movie_name },
                                 schedule_date = s.schedule_date,
                                 schedule_start = s.schedule_start,
                                 schedule_end = s.schedule_end,
                                 room = new DTO_CBBRoom { room_id = t.room_id, room_name = t.room_name, },
                                 schedule_price_percent = s.schedule_price_percent,
                             });
                return query.ToList();

            }
        }
        //public bool DeleteSchedule(int scheduleID)//return true khi xoa thanh cong
        //{
        //    using (CINEMAEntities db = new CINEMAEntities())
        //    {
        //        var schedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == scheduleID).FirstOrDefault();
        //        if (schedule.schedule_date < DateTime.Now) //neu ngay chieu < ngay hien tai thi xoa
        //        {
        //            schedule.is_deleted = true;
        //            db.SaveChanges();
        //            return true;
        //        }
        //        TimeSpan timeNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        //        if ((schedule.schedule_date == DateTime.Now)//neu ngay chieu = ngay hien tai
        //            && (TimeSpan.Compare(schedule.schedule_end, timeNow) == -1)) //gio ket thuc < gio hien tai thi xoa

        //        {
        //            schedule.is_deleted = true;
        //            db.SaveChanges();
        //            return true;
        //        }
        //        else //ngay chieu > ngay hien tai || ngay chieu=ngay hien tai va gio chieu>gio hien tai
        //        {
        //            var querry = db.TBSeatBooking.Where(p => p.schedule_id == scheduleID).Select(p => p).FirstOrDefault();
        //            if (querry != null) //ton tai ve da dat vao lich nay
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                schedule.is_deleted = true;
        //                db.SaveChanges();
        //                return true;
        //            }
        //        }

        //    }
        //}
        public void DeleteSchedule(int scheduleID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var schedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == scheduleID).FirstOrDefault();
                schedule.is_deleted = true;
                db.SaveChanges();
            }
        }
        public TBSchedule GetSchedule(int scheduleID)//return true khi xoa thanh cong
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var schedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == scheduleID).Select(p => p).FirstOrDefault();
                return schedule;
            }
        }
        public DTO_Schedule GetScheduleByID(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //select movie name
                var movieID = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == id)
                .Select(p => p.movie_id).FirstOrDefault();

                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == movieID)
                .Select(p => p).FirstOrDefault();
                //select room name
                var roomID = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == id)
                .Select(p => p.room_id).FirstOrDefault();

                var room = db.TBRoom.Where(p => p.is_deleted == false).Where(p => p.room_id == roomID)
                .Select(p => p).FirstOrDefault();


                var i = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == id)
                    .Select(p => p).FirstOrDefault();
                DTO_Schedule t = new DTO_Schedule()
                {
                    schedule_id = i.schedule_id,
                    schedule_date = i.schedule_date,
                    schedule_start = i.schedule_start,
                    schedule_end = i.schedule_end,
                    schedule_price_percent = i.schedule_price_percent,
                    movie = new DTO_CBBMovie { movie_id = movie.movie_id, movie_name = movie.movie_name, },
                    room = new DTO_CBBRoom { room_id = room.room_id, room_name = room.room_name, },
                };
                return t;

            }
        }
        public bool IsBooking(int scheduleID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var querry = db.TBSeatBooking.Where(p => p.schedule_id == scheduleID).Select(p => p).FirstOrDefault();
                if (querry != null) //ton tai ve da dat vao lich nay
                {
                    return true;
                }
                return false;
            }
        }
        public List<DTO_Schedule> GetListScheduleByMovie(int movie_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = (from s in db.TBSchedule
                             join c in db.TBMovie on s.movie_id equals c.movie_id
                             join t in db.TBRoom on s.room_id equals t.room_id
                             where s.is_deleted == false
                             where c.is_deleted == false
                             where t.is_deleted == false
                             where (c.movie_id == movie_id)
                             select new DTO_Schedule
                             {
                                 schedule_id = s.schedule_id,
                                 movie = new DTO_CBBMovie { movie_id = c.movie_id, movie_name = c.movie_name },
                                 schedule_date = s.schedule_date,
                                 schedule_start = s.schedule_start,
                                 schedule_end = s.schedule_end,
                                 room = new DTO_CBBRoom { room_id = t.room_id, room_name = t.room_name, },
                                 schedule_price_percent = s.schedule_price_percent,
                             });
                return query.ToList();

            }
        }
        public void UpdateScheduleEnd(int scheduleID, TimeSpan scheduleEnd)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == scheduleID).FirstOrDefault();
                s.schedule_end = scheduleEnd;
                db.SaveChanges();
            }
        }
        public List<DTO_Schedule> GetListScheduleByRoom(int room_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = (from s in db.TBSchedule
                             join c in db.TBMovie on s.movie_id equals c.movie_id
                             join t in db.TBRoom on s.room_id equals t.room_id
                             where s.is_deleted == false
                             where c.is_deleted == false
                             where t.is_deleted == false
                             where s.room_id == room_id
                             select new DTO_Schedule
                             {
                                 schedule_id = s.schedule_id,
                                 movie = new DTO_CBBMovie { movie_id = c.movie_id, movie_name = c.movie_name },
                                 schedule_date = s.schedule_date,
                                 schedule_start = s.schedule_start,
                                 schedule_end = s.schedule_end,
                                 room = new DTO_CBBRoom { room_id = t.room_id, room_name = t.room_name, },
                                 schedule_price_percent = s.schedule_price_percent,
                             });
                return query.ToList();
            }

        }
        public bool AddSchedule(DTO_Schedule i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //ktra room co schedule trong khung gio
                foreach (var item in GetListScheduleByRoom(i.room.room_id))
                {
                    if (i.schedule_date.Date == item.schedule_date.Date)
                    {
                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_start) == 0)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_start) == 1) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == -1)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == 0)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == 1)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == 0) && (TimeSpan.Compare(i.schedule_end, item.schedule_start) == 1) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == -1)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == 0) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == 0)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == 0) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == 1)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == 1) && (TimeSpan.Compare(i.schedule_start, item.schedule_end) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_start) == 1) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == -1)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == 1) && (TimeSpan.Compare(i.schedule_start, item.schedule_end) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == 0)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_start) == 1) && (TimeSpan.Compare(i.schedule_start, item.schedule_end) == -1) && (TimeSpan.Compare(i.schedule_end, item.schedule_start) == 1)) return false;

                        if ((TimeSpan.Compare(i.schedule_start, item.schedule_end) == 0) && (TimeSpan.Compare(i.schedule_end, item.schedule_end) == 1)) return false;
                    }

                }
                var s = new TBSchedule();
                s.movie_id = i.movie.movie_id;
                s.schedule_date = Convert.ToDateTime(i.schedule_date);
                s.schedule_start = i.schedule_start;
                s.schedule_end = i.schedule_end;
                s.room_id = i.room.room_id;
                s.schedule_price_percent = i.schedule_price_percent;

                db.TBSchedule.Add(s);
                db.SaveChanges();
                return true;
            }
        }
        public bool UpdateSchedule(DTO_Schedule i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //kiem tra da co ve duoc dat o lich chieu nay chua
                var seatbooking = db.TBSeatBooking.Where(p => p.is_deleted == false).Where(p => p.schedule_id == i.schedule_id).FirstOrDefault();
                if (seatbooking != null) //neu da co ve duoc dat thi k the sua
                    return false;
                else
                {
                    var s = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == i.schedule_id).FirstOrDefault();

                    s.movie_id = i.movie.movie_id;
                    s.schedule_date = Convert.ToDateTime(i.schedule_date);
                    s.schedule_start = i.schedule_start;
                    s.schedule_end = i.schedule_end;
                    s.room_id = i.room.room_id;
                    s.schedule_price_percent = i.schedule_price_percent;

                    db.SaveChanges();
                    return true;
                }


            }
        }
        public bool DeleteScheduleByID(int scheduleID)//return true khi xoa thanh cong
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var schedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == scheduleID).FirstOrDefault();
                if (schedule.schedule_date < DateTime.Now) //neu ngay chieu < ngay hien tai thi xoa
                {
                    schedule.is_deleted = true;
                    db.SaveChanges();
                    return true;
                }
                TimeSpan timeNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                if ((schedule.schedule_date == DateTime.Now)//neu ngay chieu = ngay hien tai
                    && (TimeSpan.Compare(schedule.schedule_end, timeNow) == -1)) //gio ket thuc < gio hien tai thi xoa

                {
                    schedule.is_deleted = true;
                    db.SaveChanges();
                    return true;
                }
                else //ngay chieu > ngay hien tai || ngay chieu=ngay hien tai va gio chieu>gio hien tai
                {
                    var querry = db.TBSeatBooking.Where(p => p.schedule_id == scheduleID).Select(p => p).FirstOrDefault();
                    if (querry != null) //ton tai ve da dat vao lich nay
                    {
                        return false;
                    }
                    else
                    {
                        schedule.is_deleted = true;
                        db.SaveChanges();
                        return true;
                    }
                }

            }
        }
    }
}
