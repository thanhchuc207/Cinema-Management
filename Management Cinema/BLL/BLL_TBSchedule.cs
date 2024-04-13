using DAL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBSchedule
    {
       
        public string GetShowTimes(int schedule_id)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetShowTimes(schedule_id);   
        }
        public int GetMovie_id(int schedule_id)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetMovie_id(schedule_id);
        }
        public DateTime GetScheduleDate(int schedule_id)
        {

            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetScheduleDate(schedule_id);
        }
        public int GetRoomId(int schedule_id)
        {

            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetRoomId(schedule_id);
        }
        public List<DTO_TBSchedule> GetListSchedule(DateTime date, int movie_id)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetListSchedule(date, movie_id);


        }
        public DTO_TBSchedule GetScheduleDTO(int schedule_id)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetScheduleDTO(schedule_id);
        }
        public int GetSchedule_PricePercent(int schedule_id)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetSchedule_PricePercent(schedule_id) ;
        }
        public int GetPrice(int schedule_id)
        {
           DAL_TBSchedule dal = new DAL_TBSchedule() ;
            return dal.GetPrice(schedule_id) ;
        }
        public List<DTO_TBSchedule> GetListSchedule(int movie_id, DateTime date, int room_type_id)
        {
            DAL_TBSchedule dal=new DAL_TBSchedule();
            return dal.GetListSchedule(movie_id, date, room_type_id) ;
        }

        public List<DTO_Schedule> GetAllSchedules()
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetAllSchedules().OrderBy(p=>p.schedule_date).ToList();
        }
        public List<DTO_Schedule> GetAllScheduleByRoom(int roomID)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetAllScheduleByRoom(roomID).OrderBy(p=>p.schedule_date).ToList();
        }
        public List<DTO_Schedule> GetSchedulesByMovieDateRoom(string txt)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetSchedulesByMovieDateRoom(txt);

        }
        public bool DeleteSchedule(int scheduleID)
        {
            TimeSpan timeNow = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DAL_TBSchedule dal = new DAL_TBSchedule();
            var schedule = dal.GetSchedule(scheduleID);
            if (schedule.schedule_date < DateTime.Now) //neu ngay chieu < ngay hien tai thi xoa
            {
                dal.DeleteSchedule(scheduleID);
                return true;
            }
            else
                if ((schedule.schedule_date == DateTime.Now)//neu ngay chieu = ngay hien tai
                    && (TimeSpan.Compare(schedule.schedule_end, timeNow) == -1)) //gio ket thuc < gio hien tai thi xoa
            {
                dal.DeleteSchedule(scheduleID);
                return true;
            }
            else //ngay chieu > ngay hien tai || ngay chieu=ngay hien tai va gio chieu>gio hien tai
            {
                if (dal.IsBooking(scheduleID) == false)
                {
                    dal.DeleteSchedule(scheduleID);
                    return true;
                }
                return false;
            }
        }
        public DTO_Schedule GetSchedule(int id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetSchedule(id);

        }
        public DTO_Schedule GetScheduleByID(int id)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.GetScheduleByID(id);

        }
        public bool AddOrUpdateSchedule(DTO_Schedule i, ref string txt)
        {
            if (i.schedule_id == 0)
            {
                DAL_DB dal = new DAL_DB();
                //kiem tra movie release < schedule_date
                if (i.schedule_date <= dal.GetMovieRelease(i.movie.movie_id))
                {
                    txt = "Thêm lịch chiếu không thành công. Vui lòng chọn ngày chiếu sau ngày phát hành phim";
                    return false;
                }
                if (AddSchedule(i))
                {
                    txt = "Thêm lịch chiếu thành công";
                    return true;
                }
                else
                {
                    txt = "Trùng lịch chiếu ở phòng này. Vui lòng chọn khung giờ khác hoặc phòng chiếu khác";
                    return false;
                }
            }
            else
            {
                DAL_DB dal = new DAL_DB();
                //kiem tra movie release < schedule_date
                if (i.schedule_date <= dal.GetMovieRelease(i.movie.movie_id))
                {
                    txt = "Cập nhật lịch chiếu không thành công. Vui lòng chọn ngày chiếu sau ngày phát hành phim";
                    return false;
                }
                if (UpdateSchedule(i))
                {
                    txt = "Cập nhật thông tin thành công";
                    return true;
                }
                else
                {
                    txt = "Không thể thay đổi thông tin. Tồn tại vé đã đặt ở lịch chiếu này";
                    return false;
                }
            }
        }
        public bool AddSchedule(DTO_Schedule i)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.AddSchedule(i);
        }
        public bool UpdateSchedule(DTO_Schedule i)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.UpdateSchedule(i);
        }
        public bool DeleteScheduleByID(int scheduleID)
        {
            DAL_TBSchedule dal = new DAL_TBSchedule();
            return dal.DeleteScheduleByID(scheduleID);
        }
    }
}
