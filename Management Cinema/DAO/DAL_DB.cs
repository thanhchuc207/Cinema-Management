using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class DAL_DB
    {
        //customer
        #region 
        public List<TBCustomer> GetAllCustomers()
        {
            List<TBCustomer> li = new List<TBCustomer>();
            using (CINEMAEntities db = new CINEMAEntities())
            {
                li = db.TBCustomer.Where(p => p.is_deleted == false)
                .Select(p => p).ToList();

            }
            return li;
        }
        public List<DTO_Customer> GetCustomerByName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBCustomer.Where(p => p.is_deleted == false).Where(p => p.customer_name.Contains(txt))
                    .Select(p => new DTO_Customer
                    {
                        customer_id = p.customer_id,
                        customer_name = p.customer_name,
                        customer_birthday = p.customer_birthday,
                        customer_address = p.customer_address,
                        customer_phone = p.customer_phone,
                        customer_points = p.customer_points,
                    });
                return query.ToList();
            }
        }
        public TBCustomer GetCustomer(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBCustomer.Where(p => p.is_deleted == false).Where(p => p.customer_id == id)
                .Select(p => p).FirstOrDefault();
            }
        }
        public List<string> GetAllCustomerPhoneNum()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBCustomer.Where(p => p.is_deleted == false).Select(p => p.customer_phone).ToList();
            }
        }
        #endregion

        //staff
        #region
        public List<TBStaff> GetAllStaffs()
        {
            List<TBStaff> li = new List<TBStaff>();
            using (CINEMAEntities db = new CINEMAEntities())
            {
                li = db.TBStaff.Where(p => p.is_deleted == false)
                .Select(p => p).ToList();
            }
            return li.ToList();
        }
        public List<DTO_Staff> GetStaffByName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBStaff.Where(p => p.is_deleted == false)
                    .Where(p => p.staff_name.Contains(txt))
                    .Select(p => new DTO_Staff
                    {
                        staff_id = p.staff_id,
                        staff_name = p.staff_name,
                        staff_birthday = p.staff_birthday,
                        staff_gender = p.staff_gender,
                        staff_phone = p.staff_phone,
                        email = p.email,
                        role = p.role,
                        staff_usename = p.username,
                        staff_pwd = p.pwd,
                    });
                return query.ToList();
            }
        }

        public TBStaff GetStaff(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBStaff.Where(p => p.is_deleted == false).Where(p => p.staff_id == id)
                .Select(p => p).FirstOrDefault(); ;
            }
        }
        public List<string> GetListEmailStaff()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p=>p.is_deleted==false).Select(p=>p.email).ToList();
                return s;
            }
        }
        public List<string> GetListPhoneStaff()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p => p.is_deleted == false).Select(p => p.staff_phone).ToList();
                return s;
            }
        }
        #endregion

        //CBB
        #region
        public List<DTO_CBBMovieGenre> GetAllMovieGenresName()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBMovieGenres.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBMovieGenre { movie_genre_id = p.movie_genres_id, movie_genre_name = p.movie_genres });
                return query.ToList();
            }
        }
        public List<DTO_CBBMovie> GetAllMovieNames()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBMovie.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBMovie { movie_id = p.movie_id, movie_name = p.movie_name });

                return query.ToList();
            }
        }
        public List<DTO_CBBMovie> GetMovieNamesByDate() //Lay ra movie co release < datetime.now
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_release < DateTime.Now)
                    .Select(p => new DTO_CBBMovie { movie_id = p.movie_id, movie_name = p.movie_name });

                return query.ToList();
            }
        }
        public List<DTO_CBBMoviePicture> GetAllMoviePictures()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBMovie.Where(p => p.is_deleted == false)
                     .Select(p => new DTO_CBBMoviePicture { id_movie = p.movie_id, path_image = p.movie_image });
                return query.ToList();
            }
        }
        public List<DTO_CBBMoviePicture> GetMoviePicturesByName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_name.Contains(txt))
                    .Select(p => new DTO_CBBMoviePicture { id_movie = p.movie_id, path_image = p.movie_image });

                return query.ToList();
            }
        }
        public List<DTO_CBBRoom> GetAllRoomNames()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBRoom.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBRoom { room_id = p.room_id, room_name = p.room_name });
                return query.ToList();
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
        public List<DTO_CBBRoomType> GetAllRoomTypes()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBRoomType.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBRoomType { room_type_id = p.room_type_id, room_type_name = p.room_type_name, room_type_price = p.room_type_price_percent });
                return query.ToList();
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
        #endregion

        //movie
        #region
        public List<DTO_Movie> GetAllMovies()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = (from s in db.TBMovie
                             join c in db.TBMovieGenres on s.movie_genres_id equals c.movie_genres_id
                             select new DTO_Movie
                             {
                                 movie_id = s.movie_id,
                                 movie_name = s.movie_name,
                                 movie_genres = new DTO_CBBMovieGenre { movie_genre_id = c.movie_genres_id, movie_genre_name = c.movie_genres, },
                                 movie_description = s.movie_description,
                                 movie_length = s.movie_length,
                                 movie_release = s.movie_release,
                                 movie_image = s.movie_image,
                                 movie_price = s.movie_price,
                             });
                return query.ToList();
            }
        }
        public DTO_Movie GetMovie(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var movieGenreID = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == id)
                .Select(p => p.movie_genres_id).FirstOrDefault();

                var movieGenre = db.TBMovieGenres.Where(p => p.is_deleted == false).Where(p => p.movie_genres_id == movieGenreID)
                .Select(p => p).FirstOrDefault();

                var i = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == id)
                    .Select(p => p).FirstOrDefault();
                return new DTO_Movie()
                {
                    movie_id = i.movie_id,
                    movie_name = i.movie_name,
                    movie_genres = new DTO_CBBMovieGenre { movie_genre_id = movieGenre.movie_genres_id, movie_genre_name = movieGenre.movie_genres },
                    movie_description = i.movie_description,
                    movie_length = i.movie_length,
                    movie_release = i.movie_release,
                    movie_image = i.movie_image,
                    movie_price = i.movie_price,
                };

            }
        }
        public int GetMovieLength(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == id).FirstOrDefault();
                return movie.movie_length;
            }
        }
        public DTO_CBBMovieGenre GetMovieGenre(int ID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBMovieGenres.Where(p => p.is_deleted == false).Where(p => p.movie_genres_id == ID).Select(p => new DTO_CBBMovieGenre
                {
                    movie_genre_id = p.movie_genres_id,
                    movie_genre_name = p.movie_genres,
                }).FirstOrDefault();

            }
        }
        public DateTime GetMovieRelease(int movieID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == movieID).FirstOrDefault();
                return movie.movie_release;
            }
        }
        public bool DeleteMovieGenre(int moviegenreID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var movie = db.TBMovie.Where(p=>p.is_deleted==false).Where(p=>p.movie_genres_id==moviegenreID).FirstOrDefault();
                if(movie == null)
                {
                    return false;
                }

                var s = db.TBMovieGenres.Where(p => p.movie_genres_id == moviegenreID).FirstOrDefault();
                s.is_deleted = true;
                db.SaveChanges();
                return true;
            }
        }
        #endregion

        //schedule
        #region
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
        public DTO_Schedule GetSchedule(int id)
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
                             where ( c.movie_id==movie_id)
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
        
        #endregion
        //room
        public DTO_Room GetRoom(int id)
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
                var s = db.TBRoom.Where(p => p.is_deleted == false).Where(p=>p.room_id!=roomID).Where(p => p.room_name == txt).FirstOrDefault();
                if (s != null) return false; //trung, k the dung roomname=txt
                return true;
            }
        }
        public bool CheckSameMovieGenreName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBMovieGenres.Where(p => p.is_deleted == false).Where(p => p.movie_genres == txt).FirstOrDefault();
                if (s != null) return false; //trung, k the dung roomname=txt
                return true;
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
        public bool CheckSameRoomTypeName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBRoomType.Where(p => p.is_deleted == false).Where(p => p.room_type_name == txt).FirstOrDefault();
                if (s != null) return false; //trung, k the dung roomname=txt
                return true;
            }

        }
        //shift
        //--------------------------------------------------------------------------------------------
        public void UpdateMovie(DTO_Movie i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBMovie.Where(p => p.movie_id == i.movie_id).FirstOrDefault();
                s.movie_name = i.movie_name;
                s.movie_genres_id = i.movie_genres.movie_genre_id;
                s.movie_description = i.movie_description;
                s.movie_length = i.movie_length;
                s.movie_release = i.movie_release;
                s.movie_image = i.movie_image;
                s.movie_price = i.movie_price;
                db.SaveChanges();
            }


        }
        public void AddMovie(DTO_Movie i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBMovie();
                s.movie_name = i.movie_name;
                s.movie_genres_id = i.movie_genres.movie_genre_id;
                s.movie_description = i.movie_description;
                s.movie_length = i.movie_length;
                s.movie_release = i.movie_release;
                s.movie_price = i.movie_price;
                s.movie_image = i.movie_image;
                s.is_deleted = false;

                db.TBMovie.Add(s);
                db.SaveChanges();
            }
        }

        public bool DeleteMovie(int ID)//return false khi k xoa duoc
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                //lau ra list schedule co movie muon xoa
                var listIDSchedule = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.movie_id == ID).Select(p => p.schedule_id);

                //kiem tra co ton tai seatbooking o schedule do khong
                foreach (var i in listIDSchedule)
                {
                    var querry = db.TBSeatBooking.Where(p => p.schedule_id == i).Select(p => p.seat_booking_id).FirstOrDefault();
                    if (querry != null) return false; //ton tai
                }
                //khong ton tai
                foreach (var i in listIDSchedule) //xoa mem cac schedule co movie muon xoa
                {
                    var s = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == i).FirstOrDefault();
                    s.is_deleted = true;
                    db.SaveChanges();
                }
                //xoa mem movie
                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == ID).FirstOrDefault();
                movie.is_deleted = true;
                db.SaveChanges();
                return true;//xoa thanh cong
            }
        }
        public void AddMovieGenre(DTO_CBBMovieGenre i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBMovieGenres();
                s.movie_genres = i.movie_genre_name;

                db.TBMovieGenres.Add(s);
                db.SaveChanges();
            }
        }
        public void UpdateMovieGenre(DTO_CBBMovieGenre i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBMovieGenres.Where(p => p.is_deleted == false).Where(p => p.movie_genres_id == i.movie_genre_id).FirstOrDefault();
                s.movie_genres = i.movie_genre_name;
                db.SaveChanges();
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
        public List<DateTime> GetDate(DTO_Schedule i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DateTime> time = new List<DateTime>();
                foreach (var item in GetListScheduleByRoom(i.room.room_id))
                {
                    if (DateTime.Compare(i.schedule_date.Date, item.schedule_date.Date) == 0)
                        time.Add(item.schedule_date);


                }
                time.Add(i.schedule_date);
                return time;
            }
        }
        public List<TimeSpan> GetTime(DTO_Schedule i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<TimeSpan> time = new List<TimeSpan>();
                foreach (var item in GetListScheduleByRoom(i.room.room_id))
                {
                    if (DateTime.Compare(i.schedule_date.Date, item.schedule_date.Date) == 0)
                    {
                        time.Add(item.schedule_start);
                        time.Add(item.schedule_end);
                    }
                    else
                    {

                    }

                }
                time.Add(i.schedule_start);
                time.Add(i.schedule_end);
                return time;
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
        public bool DeleteSchedule(int scheduleID)//return true khi xoa thanh cong
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

        public int AddRoomReturnID(DTO_Room i)
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

                return s.room_id;
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
        public void AddStaff(DTO_Staff i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBStaff();
                s.staff_name = i.staff_name;
                s.staff_birthday = i.staff_birthday;
                s.staff_gender = i.staff_gender;
                s.staff_phone = i.staff_phone;
                s.email = i.email;
                s.role = i.role;
                s.username = i.staff_usename;
                s.pwd = i.staff_pwd;

                db.TBStaff.Add(s);
                db.SaveChanges();
            }
        }
        public void UpdateStaff(DTO_Staff i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p => p.is_deleted == false).Where(p => p.staff_id == i.staff_id).FirstOrDefault();

                s.staff_name = i.staff_name;
                s.staff_birthday = i.staff_birthday;
                s.staff_gender = i.staff_gender;
                s.staff_phone = i.staff_phone;
                s.email = i.email;
                s.role = i.role;

                db.SaveChanges();
            }
        }
        public void DeleteStaff(int ID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p => p.staff_id == ID).FirstOrDefault();

                s.is_deleted = true;
                db.SaveChanges();
            }
        }
        public void AddCustomer(DTO_Customer i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = new TBCustomer();
                s.customer_name = i.customer_name;
                s.customer_birthday = i.customer_birthday;
                s.customer_address = i.customer_address;
                s.customer_phone = i.customer_phone;
                s.customer_points = i.customer_points;

                db.TBCustomer.Add(s);
                db.SaveChanges();
            }
        }
        public void UpdateCustomer(DTO_Customer i)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBCustomer.Where(p => p.is_deleted == false).Where(p => p.customer_id == i.customer_id).FirstOrDefault();

                s.customer_name = i.customer_name;
                s.customer_birthday = i.customer_birthday;
                s.customer_address = i.customer_address;
                s.customer_phone = i.customer_phone;
                s.customer_points = i.customer_points;

                db.SaveChanges();
            }
        }
        public void DeleteCustomer(int ID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBCustomer.Where(p => p.customer_id == ID).FirstOrDefault();

                s.is_deleted = true;
                db.SaveChanges();
            }
        }
      
        //revenue
        public List <DTO_MovieRevenue> GetMovieRevenue()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                         join c in db.TBSchedule on s.schedule_id equals c.schedule_id
                         join t in db.TBMovie on c.movie_id equals t.movie_id
                         group s by 
                          new
                         {
                            t.movie_id,
                            t.movie_name
                         } into g
                         select( new DTO_MovieRevenue
                         {
                             movie_id=g.Key.movie_id,
                             movie_name = g.Key.movie_name,
                              number_of_tickets = g.Sum(x=>x.number_of_tickets),
                              revenue = g.Sum(x=>x.total_price)
                         } )                      
                         ;
                return item.ToList();   
            }
        }
        public List<DTO_StaffRevenue> GetStaffRevenue()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBStaff on s.staff_id equals c.staff_id
                           where c.is_deleted==false
                           group s by
                            new
                            {
                                c.staff_id,
                                c.staff_name
                            } into g
                           select (new DTO_StaffRevenue
                           {
                               staff_id= g.Key.staff_id,
                               staff_name = g.Key.staff_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenue()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBCustomer on s.customer_id equals c.customer_id
                           where c.is_deleted==false
                           group s by
                            new
                            {
                                c.customer_id,
                                c.customer_name
                            } into g
                           select (new DTO_CustomerRevenue
                           {
                               customer_id = g.Key.customer_id,
                               customer_name = g.Key.customer_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_MovieRevenue> GetMovieRevenueByMonth(int month,int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBSchedule on s.schedule_id equals c.schedule_id
                           join t in db.TBMovie on c.movie_id equals t.movie_id
                           where s.datetime_booking.Year == year
                           where s.datetime_booking.Month==month                          
                           group s by
                            new
                            {
                                t.movie_id,
                                t.movie_name
                            } into g
                           select (new DTO_MovieRevenue
                           {
                               movie_id=g.Key.movie_id,
                               movie_name = g.Key.movie_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_StaffRevenue> GetStaffRevenueByMonth(int month, int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBStaff on s.staff_id equals c.staff_id
                           where c.is_deleted==false
                           where s.datetime_booking.Year == year
                           where s.datetime_booking.Month == month
                           group s by
                            new
                            {
                                c.staff_id,
                                c.staff_name
                            } into g
                           select (new DTO_StaffRevenue
                           {
                               staff_id = g.Key.staff_id,
                               staff_name = g.Key.staff_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenueByMonth(int month, int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBCustomer on s.customer_id equals c.customer_id
                           where c.is_deleted == false
                           where s.datetime_booking.Year == year
                           where s.datetime_booking.Month == month
                           group s by
                            new
                            {
                                c.customer_id,
                                c.customer_name
                            } into g
                           select (new DTO_CustomerRevenue
                           {
                               customer_id = g.Key.customer_id,
                               customer_name = g.Key.customer_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_MovieRevenue> GetMovieRevenueByYear(int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBSchedule on s.schedule_id equals c.schedule_id
                           join t in db.TBMovie on c.movie_id equals t.movie_id
                           where s.datetime_booking.Year == year
                           group s by
                            new
                            {
                                t.movie_id,
                                t.movie_name
                            } into g
                           select (new DTO_MovieRevenue
                           {
                               movie_id=g.Key.movie_id,
                               movie_name = g.Key.movie_name ,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_StaffRevenue> GetStaffRevenueByYear(int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBStaff on s.staff_id equals c.staff_id
                           where c.is_deleted==false
                           where s.datetime_booking.Year == year
                           group s by
                            new
                            {
                                c.staff_id,
                                c.staff_name
                            } into g
                           select (new DTO_StaffRevenue
                           {
                               staff_id=g.Key.staff_id,
                               staff_name = g.Key.staff_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenueByYear(int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBCustomer on s.customer_id equals c.customer_id
                           where c.is_deleted == false
                           where s.datetime_booking.Year == year
                           group s by
                            new
                            {
                                c.customer_id,
                                c.customer_name
                            } into g
                           select (new DTO_CustomerRevenue
                           {
                               customer_id = g.Key.customer_id,
                               customer_name = g.Key.customer_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
                         ;
                return item.ToList();
            }
        }
        public List<int> GetAllYearRevenue()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBReceipt.Select(p=>p.datetime_booking.Year).Distinct().ToList();
            }
        }
    }

}
