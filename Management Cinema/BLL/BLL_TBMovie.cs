using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBMovie
    {
        public DTO_Movie GetMovie(int id_movie)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMovie(id_movie);

        }
        public List<string> GetListImgageMovie()
        {

            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetListImgageMovie();
        }
        public string GetNameMovie(int movie_id)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetNameMovie(movie_id);
        }
        public int GetPrice(int movie_id)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetPrice(movie_id);
        }
        public List<int> GetListMovie_id()
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetListMovie_id();

        }
        public string GetImageMovie(int movie_id)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetImageMovie(movie_id);
        }
        public List<int> GetMovieByName(string name)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMovieByName(name);

        }
        public List<int> GetMovieByMovieGenres(DTO_CBBMovieGenre movie_genre)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMovieByMovieGenres(movie_genre);
        }
        public List<DTO_MovieStatitic> GetStatitics()
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetStatitics();
        }
        public List<DTO_CBBMovieGenre> GetListMovieGenre()
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetListMovieGenre();
        }
        public List<DTO_MovieStatitic> GetStatitics(string times, string item)
        {
            DAL_TBMovie bll=new DAL_TBMovie();
            return bll.GetStatitics(times, item);
        }
        public List<DTO_CBBMoviePicture> GetAllMoviePictures()
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetAllMoviePictures();
        }
        public List<DTO_CBBMoviePicture> GetMoviePicturesByName(string txt)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMoviePicturesByName(txt);
        }
        public List<DTO_CBBMovieGenre> GetAllMovieGenres()
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetAllMovieGenresName();
        }
        public bool DeleteMovie(int ID)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.DeleteMovie(ID);
        }
        public List<DTO_Movie> GetAllMovies()
        {
            List<DTO_Movie> li = new List<DTO_Movie>();
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetAllMovies();
        }
        public bool CheckSameMovie(DTO_Movie movie)
        {

            if (movie.movie_id == 0)
            {
                foreach (var i in GetAllMovies())
                {
                    if ((movie.movie_name == i.movie_name) && (movie.movie_description == i.movie_description)
                        && (movie.movie_length == i.movie_length) && (movie.movie_release == i.movie_release))
                        return false;
                }
                return true;
            }
            else
            {
                foreach (var i in GetAllMovies())
                {
                    if ((movie.movie_id != i.movie_id) && (movie.movie_name == i.movie_name) && (movie.movie_description == i.movie_description)
                        && (movie.movie_length == i.movie_length) && (movie.movie_release == i.movie_release))
                        return false;
                }
                return true;
            }
        }
        public void AddMovie(DTO_Movie i)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            dal.AddMovie(i);
        }
        public int GetMovieLength(int id)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMovieLength(id);
        }
        public bool UpdateMovie(DTO_Movie i, ref string message)
        {
            DAL_TBSchedule dalSchedule = new DAL_TBSchedule();
            DAL_TBSeatBooking dalSeatBooking = new DAL_TBSeatBooking();
            //kiem tra neu phim duoc set trong schedule va da co nguoi dat ve thi k duoc update
            foreach (var item in dalSchedule.GetListScheduleByMovie(i.movie_id))
            {
                if (dalSeatBooking.IsBooking(item.schedule_id))
                {
                    message = "Cập nhật không thành công. Tồn tại vé đã đặt ở phim này";
                    return false;
                }
            }
            //ktra neu phim duoc set trong schedule thi release < scheduledate
            foreach (var item in dalSchedule.GetListScheduleByMovie(i.movie_id))
            {
                if (i.movie_release > item.schedule_date)
                {
                    message = "Cập nhật không thành công. Tồn tại lịch chiếu có ngày chiếu xảy ra trước ngày phát hành phim";
                    return false;
                }
            }
            DAL_TBMovie dalMovie = new DAL_TBMovie();
            dalMovie.UpdateMovie(i);

            //update schedule end neu movie length thay doi
            if (i.movie_length != GetMovieLength(i.movie_id))
            {
                foreach (var item in dalSchedule.GetListScheduleByMovie(i.movie_id))
                {
                    TimeSpan newScheduleEnd = item.schedule_start.Add(new TimeSpan(0, i.movie_length + 15, 0));
                    dalSchedule.UpdateScheduleEnd(item.schedule_id, newScheduleEnd);
                }
            }
            message = "Cập nhật thành công";
            return true;
        }
        public bool AddOrUpdateMovie(DTO_Movie movie, ref string message)
        {
            if (movie.movie_id == 0)
            {
                if (CheckSameMovie(movie))
                {
                    AddMovie(movie);
                    message = "Thêm thành công";
                    return true;
                }
                else
                {
                    message = "Thêm không thành công. Phim đã tồn tại trong hệ thống";
                    return false;
                }
            }
            else
            {
                if (CheckSameMovie(movie))
                {
                    if (UpdateMovie(movie, ref message))
                        return true;
                    else return false;
                }
                else
                {
                    message = "cập nhật không thành công. Phim đã tồn tại trong hệ thống";
                    return false;
                }

            }
        }
        public DTO_CBBMovieGenre GetMovieGenre(int ID)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMovieGenre(ID);
        }
        public void UpdateMovieGenre(DTO_CBBMovieGenre i)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            dal.UpdateMovieGenre(i);
        }
        public bool CheckSameMovieGenreName(string txt)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.CheckSameMovieGenreName(txt);
        }
        public bool EditMovieGenre(DTO_CBBMovieGenre i, string movieGenreName)
        {
            if (i.movie_genre_name != movieGenreName)
            {
                if (CheckSameMovieGenreName(i.movie_genre_name))
                {
                    UpdateMovieGenre(i);
                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }

        }
        public bool AddMovieGenre(DTO_CBBMovieGenre i)
        {
            if (CheckSameMovieGenreName(i.movie_genre_name))
            {
                DAL_TBMovie dal = new DAL_TBMovie();
                dal.AddMovieGenre(i);
                return true;
            }
            else
            {
                return false;
            }

        }
        public string AddOrUpdateMovieGenre(DTO_CBBMovieGenre i, string movieGenreName)
        {
            if (i.movie_genre_id != 0)
            {
                if (EditMovieGenre(i, movieGenreName))
                {
                    return "Cập nhật thành công";
                }
                else
                    return "Đã tồn tại loại phim này. Vui lòng nhập tên khác";
            }
            else
            {
                if (AddMovieGenre(i))
                {
                    return "Thêm thành công";
                }
                else
                    return "Đã tồn tại loại phim này. Vui lòng nhập tên khác";
            }
        }
        public bool DeleteMovieGenre(int movie_genre_id)
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.DeleteMovieGenre(movie_genre_id);
        }
        public List<DTO_CBBMovie> GetMovieNamesByDate()
        {
            DAL_TBMovie dal = new DAL_TBMovie();
            return dal.GetMovieNamesByDate();
        }
    }
}
