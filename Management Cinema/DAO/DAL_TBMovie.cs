
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBMovie
    {
        public List<DTO_CBBMovieGenre> GetAllMovieGenresName()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBMovieGenres.Where(p => p.is_deleted == false)
                    .Select(p => new DTO_CBBMovieGenre { movie_genre_id = p.movie_genres_id, movie_genre_name = p.movie_genres });
                return query.ToList();
            }
        }
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
        public int GetMovieLength(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == id).FirstOrDefault();
                return movie.movie_length;
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
                foreach (var i in listIDSchedule) //xoa cac schedule co movie muon xoa
                {
                    var s = db.TBSchedule.Where(p => p.is_deleted == false).Where(p => p.schedule_id == i).FirstOrDefault();
                    s.is_deleted = true;
                    db.SaveChanges();
                }
                //xoa movie
                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_id == ID).FirstOrDefault();
                movie.is_deleted = true;
                db.SaveChanges();
                return true;//xoa thanh cong
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
        public bool CheckSameMovieGenreName(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBMovieGenres.Where(p => p.is_deleted == false).Where(p => p.movie_genres == txt).FirstOrDefault();
                if (s != null) return false; //trung, k the dung roomname=txt
                return true;
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
        public bool DeleteMovieGenre(int moviegenreID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var movie = db.TBMovie.Where(p => p.is_deleted == false).Where(p => p.movie_genres_id == moviegenreID).FirstOrDefault();
                if (movie != null)
                {
                    return false;
                }

                var s = db.TBMovieGenres.Where(p => p.movie_genres_id == moviegenreID).FirstOrDefault();
                s.is_deleted = true;
                db.SaveChanges();
                return true;
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

        public List<string> GetListImgageMovie()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<string> list = db.TBMovie.Select(p => p.movie_image).ToList();
                return list;
            }

        }

        public string GetNameMovie(int movie_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                string result = db.TBMovie.Where(p => p.movie_id == movie_id).Select(p => p.movie_name).FirstOrDefault().ToString();
                if (result != null)
                {
                    return result;
                }
                return "";
            }
        }
        public int GetPrice(int movie_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int result = db.TBMovie.Where(p => p.movie_id == movie_id).Select(p => p.movie_price).FirstOrDefault();
                return result;
            }
        }
        public List<int> GetListMovie_id()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<int> list = db.TBMovie.Where(p => p.is_deleted == false).Select(p => p.movie_id).ToList();

                return list;
            }

        }
        public string GetImageMovie(int movie_id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                string result = db.TBMovie.Where(p => p.movie_id == movie_id).Select(p => p.movie_image).FirstOrDefault();
                return result;
            }
        }
        public List<int> GetMovieByName(string name)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<int> list = new List<int>();
                List<TBMovie> movies = db.TBMovie.ToList();
                foreach (TBMovie movie in movies)
                {
                    if (movie.movie_name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        list.Add(movie.movie_id);
                    }
                }
                return list;
            }

        }
        public List<int> GetMovieByMovieGenres(DTO_CBBMovieGenre movie_genre)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<int> list = new List<int>();
                List<TBMovie> movies = db.TBMovie.Where(p => p.TBMovieGenres.movie_genres == movie_genre.movie_genre_name).ToList();
                foreach (TBMovie movie in movies)
                {
                    if (movie.is_deleted == false)
                    {
                        list.Add(movie.movie_id);
                    }
                }
                return list;
            }
        }
        public List<DTO_MovieStatitic> GetStatitics()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_MovieStatitic> list = new List<DTO_MovieStatitic>();
                var query = from movie in db.TBMovie
                            join schedule in db.TBSchedule
                            on movie.movie_id equals schedule.movie_id
                            join receipt in db.TBReceipt on schedule.schedule_id equals receipt.schedule_id
                            group receipt by new
                            {
                                movie.movie_id,
                                movie.movie_name
                            } into g
                            select new DTO_MovieStatitic
                            {
                                movie_name = g.Key.movie_name,
                                number_of_ticket = g.Sum(x => x.number_of_tickets),
                                total_price = g.Sum(x => x.total_price)
                            };
                list = query.ToList();

                return list;
            }
        }
        public List<DTO_CBBMovieGenre> GetListMovieGenre()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_CBBMovieGenre> result = new List<DTO_CBBMovieGenre>();
                List<TBMovieGenres> list = db.TBMovieGenres.ToList();
                foreach (var item in list)
                {
                    if (item.is_deleted == false)
                    {
                        result.Add(new DTO_CBBMovieGenre
                        {
                            movie_genre_id = item.movie_genres_id,
                            movie_genre_name = item.movie_genres
                        });
                    }
                }
                return result;
            }

        }
        public List<DTO_MovieStatitic> GetStatitics(string times, string item)
        {
            using (var db = new CINEMAEntities())
            {
                List<DTO_MovieStatitic> list = new List<DTO_MovieStatitic>();
                if (times == "Năm")
                {
                    int year = int.Parse(item);
                    var result = db.TBMovie
                .Join(db.TBSchedule,
                    movie => movie.movie_id,
                    schedule => schedule.movie_id,
                    (movie, schedule) => new { movie, schedule }).Join(db.TBReceipt, schedule => schedule.schedule.schedule_id,
                    receipt => receipt.schedule_id, (schedule, receipt) => new { schedule, receipt }).Where(m => m.schedule.schedule.schedule_date.Year == year).GroupBy(m => m.schedule.movie.movie_name)
                    .Select(g => new DTO_MovieStatitic
                    {
                        movie_name = g.Key,
                        number_of_ticket = g.Sum(x => x.receipt.number_of_tickets),
                        total_price = g.Sum(x => x.receipt.total_price)
                    }).OrderByDescending(m => m.total_price).ToList();
                    list = result.ToList();
                }
                if (times == "Tháng")
                {
                    int month = int.Parse(item);
                    DateTime date = new DateTime(DateTime.Now.Year, month, 1);
                    var result = db.TBMovie
                .Join(db.TBSchedule,
                    movie => movie.movie_id,
                    schedule => schedule.movie_id,
                    (movie, schedule) => new { movie, schedule }).Join(db.TBReceipt, schedule => schedule.schedule.schedule_id,
                    receipt => receipt.schedule_id, (schedule, receipt) => new { schedule, receipt }).Where(m => (m.schedule.schedule.schedule_date.Month == month && m.schedule.schedule.schedule_date.Year == date.Year)).GroupBy(m => m.schedule.movie.movie_name)
                    .Select(g => new DTO_MovieStatitic
                    {
                        movie_name = g.Key,
                        number_of_ticket = g.Sum(x => x.receipt.number_of_tickets),
                        total_price = g.Sum(x => x.receipt.total_price)
                    }).OrderByDescending(m => m.total_price).ToList();
                    list = result.ToList();
                }
                return list;
            }
        }



    }
}
