using DAL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DB
    {
        //get
        public List<DateTime> GetDate(DTO_Schedule i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetDate(i);
        }
        public List<TimeSpan> GetTime(DTO_Schedule i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetTime(i);
        }
        public List<DTO_Customer> GetAllCustomers()
        {
            List<DTO_Customer> li = new List<DTO_Customer>();
            DAL_DB dal = new DAL_DB();
            foreach (var i in dal.GetAllCustomers())
            {
                li.Add(new DTO_Customer()
                {
                    customer_id = i.customer_id,
                    customer_name = i.customer_name,
                    customer_birthday = i.customer_birthday,
                    customer_address = i.customer_address,
                    customer_phone = i.customer_phone,
                    customer_points = i.customer_points,
                });
            }
            return li;
        }
        public List<DTO_Customer> GetCustomerByName(string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetCustomerByName(txt);
        }
        public DTO_Customer GetCustomer(int customer_id)
        {
            DTO_Customer i = new DTO_Customer();
            DAL_DB dal = new DAL_DB();
            TBCustomer tBCustomer = dal.GetCustomer(customer_id);
            i.customer_id = tBCustomer.customer_id;
            i.customer_name = tBCustomer.customer_name;
            i.customer_birthday = tBCustomer.customer_birthday;
            i.customer_address = tBCustomer.customer_address;
            i.customer_phone = tBCustomer.customer_phone;
            i.customer_points = tBCustomer.customer_points;
            return i;
        }
        public List<DTO_StaffView> GetAllStaffs()
        {
            List<DTO_StaffView> li = new List<DTO_StaffView>();
            DAL_DB dal = new DAL_DB();
            foreach (var i in dal.GetAllStaffs())
            {
                li.Add(new DTO_StaffView()
                {
                    staff_id = i.staff_id,
                    staff_name = i.staff_name,
                    staff_birthday = i.staff_birthday,
                    staff_gender = i.staff_gender,
                    staff_phone = i.staff_phone,
                    email = i.email,
                    role = i.role,
                    staff_usename = i.username,

                });
            }
            return li;

        }
        public List<DTO_Staff> GetStaffByName(string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetStaffByName(txt);
        }
        public DTO_Staff GetStaff(int staff_id)
        {
            DTO_Staff i = new DTO_Staff();
            DAL_DB dal = new DAL_DB();
            TBStaff tBStaff = dal.GetStaff(staff_id);
            i.staff_id = tBStaff.staff_id;
            i.staff_name = tBStaff.staff_name;
            i.staff_birthday = tBStaff.staff_birthday;
            i.staff_gender = tBStaff.staff_gender;
            i.staff_phone = tBStaff.staff_phone;
            i.email = tBStaff.email;
            i.role = tBStaff.role;
            i.staff_usename = tBStaff.username;
            i.staff_pwd = tBStaff.pwd;

            return i;
        }
        public List<DTO_Movie> GetAllMovies()
        {
            List<DTO_Movie> li = new List<DTO_Movie>();
            DAL_DB dal = new DAL_DB();
            return dal.GetAllMovies();
        }

        public DTO_Movie GetMovie(int movie_id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovie(movie_id);
        }
        public List<DTO_CBBMoviePicture> GetAllMoviePictures()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllMoviePictures();
        }
        public List<DTO_CBBMoviePicture> GetMoviePicturesByName(string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMoviePicturesByName(txt);
        }
        public List<DTO_Schedule> GetAllSchedules()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllSchedules();
        }
        public List<DTO_CBBMovieGenre> GetAllMovieGenres()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllMovieGenresName();
        }
        public DTO_CBBMovieGenre GetMovieGenre(int ID)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovieGenre(ID);
        }
        public List<DTO_CBBRoom> GetAllRoomNames()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllRoomNames();
        }
        public DTO_Schedule GetSchedule(int id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetSchedule(id);

        }
        public List<DTO_Schedule> GetListScheduleByRoom(int room_id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetListScheduleByRoom(room_id);
        }
        public List<DTO_Schedule> GetAllScheduleByRoom(int roomID)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllScheduleByRoom(roomID);
        }
        public List<DTO_Schedule> GetSchedulesByMovieDateRoom(string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetSchedulesByMovieDateRoom(txt);

        }
        public List<DTO_CBBMovie> GetAllMovieNames()
        {

            DAL_DB dal = new DAL_DB();
            return dal.GetAllMovieNames();
        }
        public int GetMovieLength(int id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovieLength(id);
        }
        public List<DTO_CBBMovie> GetMovieNamesByDate()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovieNamesByDate();
        }
        public List<DTO_CBBRoomType> GetAllRoomTypes()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllRoomTypes();
        }
        public List<DTO_CBBRoom> GetAllRoomNameByType(int id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllRoomNameByType(id);
        }

        public List<DTO_CBBRoom> GetRoomNameByTypeAndName(int id, string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetRoomNameByTypeAndName(id, txt);
        }
        public DTO_Room GetRoom(int id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetRoom(id);
        }
        public bool CheckSameRoomName(int roomID, string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.CheckSameRoomName(roomID,txt);
        }
        public bool CheckSameMovieGenreName(string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.CheckSameMovieGenreName(txt);
        }
        public DTO_CBBRoomType GetRoomType(int id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetRoomType(id);
        }
        public List<DTO_RoomType> GetAllRoomType()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllRoomType();
        }
        public bool CheckSameRoomTypeName(string txt)
        {
            DAL_DB dal = new DAL_DB();
            return dal.CheckSameRoomTypeName(txt);
        }
        //set----------------------------------------------------------------------------------------
        public bool CheckSameMovie(DTO_Movie movie)
        {

            if(movie.movie_id==0)
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
                    if ((movie.movie_id!=i.movie_id)&&(movie.movie_name == i.movie_name) && (movie.movie_description == i.movie_description)
                        && (movie.movie_length == i.movie_length) && (movie.movie_release == i.movie_release))
                        return false;
                }
                return true;
            }
        }
        public bool AddOrUpdateMovie(DTO_Movie movie,ref string message)
        {
            if(movie.movie_id==0)
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
                    if(UpdateMovie(movie,ref message))
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
        public bool UpdateMovie(DTO_Movie i, ref string message)
        {
            DAL_DB dal = new DAL_DB();
            //kiem tra neu phim duoc set trong schedule va da co nguoi dat ve thi k duoc update
            foreach(var item in dal.GetListScheduleByMovie(i.movie_id))
            {
                if(dal.IsBooking(item.schedule_id))
                {
                    message = "Cập nhật không thành công. Tồn tại vé đã đặt ở phim này";
                    return false;
                }
            }
            //ktra neu phim duoc set trong schedule thi release < scheduledate
            foreach(var item in dal.GetListScheduleByMovie(i.movie_id))
            {
                if(i.movie_release> item.schedule_date)
                {
                    message = "Cập nhật không thành công. Tồn tại lịch chiếu có ngày chiếu xảy ra trước ngày phát hành phim";
                    return false;
                }
            }
            
            dal.UpdateMovie(i);

            //update schedule end neu movie length thay doi
            if (i.movie_length!= GetMovieLength(i.movie_id))
            {
                foreach (var item in dal.GetListScheduleByMovie(i.movie_id))
                {
                    TimeSpan newScheduleEnd = item.schedule_start.Add(new TimeSpan(0, i.movie_length + 15, 0));
                    dal.UpdateScheduleEnd(item.schedule_id, newScheduleEnd);
                }
            }           
            message = "Cập nhật thành công";
            return true;
        }
        public void AddMovie(DTO_Movie i)
        {
            DAL_DB dal = new DAL_DB();
            dal.AddMovie(i);
        }
        public bool DeleteMovie(int ID)
        {
            DAL_DB dal = new DAL_DB();
            return dal.DeleteMovie(ID);
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
                UpdateMovieGenre(i);
                return true;
            }

        }
        public bool AddMovieGenre(DTO_CBBMovieGenre i)
        {
            if (CheckSameMovieGenreName(i.movie_genre_name))
            {
                DAL_DB dal = new DAL_DB();
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
            DAL_DB dal = new DAL_DB();
            return dal.DeleteMovieGenre(movie_genre_id);
        }
        public bool UpdateMovieGenre(DTO_CBBMovieGenre i)
        {
            DAL_DB dal = new DAL_DB();
            dal.UpdateMovieGenre(i);
            if (CheckSameMovieGenreName(i.movie_genre_name))
            {
                UpdateMovieGenre(i);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddOrUpdateSchedule(DTO_Schedule i, ref string txt)
        {
            if (i.schedule_id == 0)
            {
                DAL_DB dal = new DAL_DB();
                //kiem tra movie release < schedule_date
                if(i.schedule_date<=dal.GetMovieRelease(i.movie.movie_id))
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
        public bool UpdateSchedule(DTO_Schedule i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.UpdateSchedule(i);
        }
        public bool AddSchedule(DTO_Schedule i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.AddSchedule(i);
        }
        public bool DeleteSchedule(int scheduleID)
        {
            DAL_DB dal = new DAL_DB();
            return dal.DeleteSchedule(scheduleID);
        }
        public bool UpdateRoom(DTO_Room i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.UpdateRoom(i);
        }
        public int AddRoom(DTO_Room i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.AddRoom(i);
        }
        public bool AddOrUpdateRoom(DTO_Room i, ref string txt,List<DTO_Seat> seats)
        {
            if (i.room_id == 0)
            {
                if (CheckSameRoomName(i.room_id,i.room_name))
                {
                    int room_id=AddRoom(i);
                    foreach(DTO_Seat seat in seats)
                    {
                        seat.room_id = room_id;
                    }
                    txt = "Thêm thành công";
                    BLL_TBSeat bllSeat = new BLL_TBSeat();
                    bllSeat.AddListSeat(seats);
                    return true;
                }
                else
                {
                    txt = "Trùng tên phòng. Vui lòng chọn tên khác";
                    return false;
                }

            }
            else
            {
                if (CheckSameRoomName(i.room_id, i.room_name))
                {
                    if (UpdateRoom(i))
                    {
                        txt = "Cập nhật thành công";
                        return true;
                    }
                    else
                    {
                        txt = "Không thể thay đổi thông tin. Tồn tại vé đã đặt ở phòng này";
                        return false;
                    }
                }
                else
                {
                    txt = "Trùng tên phòng. Vui lòng chọn tên khác";
                    return false;
                }
            }
        }
        public bool AddOrUpdateRoomType(DTO_CBBRoomType i, string roomTypeName, ref string txt)
        {
            if (i.room_type_id == 0)
            {
                if (CheckSameRoomTypeName(i.room_type_name))
                {
                    AddRoomType(i);
                    txt = "Thêm thành công";
                    return true;
                }
                else
                {
                    txt = "Đã tồn tại loại phòng này. Vui lòng nhập tên khác";
                    return false;
                }
            }
            else
            {
                if (i.room_type_name != roomTypeName)
                {
                    if (CheckSameRoomTypeName(i.room_type_name))
                    {
                        UpdateRoomType(i);
                        txt = "Cập nhật thành công";
                        return true;
                    }
                    else
                    {
                        txt = "Đã tồn tại loại phòng này. Vui lòng nhập tên khác";
                        return false;
                    }
                }
                else
                {
                    UpdateRoomType(i);
                    txt = "Cập nhật thành công";
                    return true;
                }
            }
        }
        public int AddRoomReturnID(DTO_Room i)
        {
            DAL_DB dal = new DAL_DB();
            return dal.AddRoomReturnID(i);
        }
        public void AddRoomType(DTO_CBBRoomType i)
        {
            DAL_DB dal = new DAL_DB();
            dal.AddRoomType(i);
        }
        public void UpdateRoomType(DTO_CBBRoomType i)
        {
            DAL_DB dal = new DAL_DB();
            dal.UpdateRoomType(i);
        }
        public bool DeleteRoomType(int room_type_id)
        {
            DAL_DB dal = new DAL_DB();
            return dal.DeleteRoomType(room_type_id);
        }
        public bool DeleteRoom(int roomID)
        {
            DAL_DB dal = new DAL_DB();
            return dal.DeleteRoom(roomID);
        }
        public bool CheckSameEmailStaff(string email, int staffID)
        {
            DAL_DB dal = new DAL_DB();
            if(staffID==0)
            {
                foreach (var item in dal.GetListEmailStaff())
                {
                    if (item == email)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                foreach(var item in dal.GetAllStaffs())
                {
                    if((item.staff_id!=staffID)&&(item.email==email))
                        return false;
                }
                return true;
            }
        }
        public bool CheckSamePhoneStaff(string phone, int staffID)
        {
            DAL_DB dal = new DAL_DB();
            if (staffID == 0)
            {
                foreach (var item in dal.GetListPhoneStaff())
                {
                    if (item == phone)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                foreach (var item in dal.GetAllStaffs())
                {
                    if ((item.staff_id != staffID) && (item.staff_phone == phone))
                        return false;
                }
                return true;
            }
        }
        public bool UpdateStaff(DTO_Staff i, ref string message)
        {
            DAL_DB dal = new DAL_DB();
            if (CheckSameEmailStaff(i.email, i.staff_id) == false)
            {
                message = "Cập nhật không thành công. Email này đã được đăng ký trong hệ thống";
                return false;
            }
            if (CheckSamePhoneStaff(i.staff_phone, i.staff_id) == false)
            {
                message = "Cập nhật không thành công. Số điện thoại này đã được đăng ký trong hệ thống";
                return false;
            }
            dal.UpdateStaff(i);
            message = "Cập nhật thành công";
            return true;
        }
        public bool AddStaff(DTO_Staff i, ref string message)
        {
            DAL_DB dal = new DAL_DB();
            if(CheckSameEmailStaff(i.email,i.staff_id)==false)
                {
                    message = "Thêm không thành công. Email này đã được đăng ký trong hệ thống";
                    return false;
                }
            if (CheckSamePhoneStaff(i.staff_phone,i.staff_id)==false)
                {
                    message = "Thêm không thành công. Số điện thoại này đã được đăng ký trong hệ thống";
                    return false;
                }
            dal.AddStaff(i);
            message = "Thêm thành công";
            return true;
        }
        public void DeleteStaff(int ID)
        {
            DAL_DB dal = new DAL_DB();
            dal.DeleteStaff(ID);
        }
        public bool CheckSamePhoneNumCustomer(string phoneNum, int customerID)
        {
            DAL_DB dal = new DAL_DB();
            if(customerID==0)
            {
                foreach (var item in dal.GetAllCustomerPhoneNum())
                {
                    if (string.Compare(item, phoneNum) == 0) return false;
                }
            }
            else
            {
                foreach(var item in dal.GetAllCustomers())
                {
                    if((customerID!=item.customer_id) &&(phoneNum==item.customer_phone)) return false;
                }
            }
            return true;
        }
        public bool AddOrUpdateCustomer(DTO_Customer i, ref string txt)
        {
            //checksamephonenum
            if (CheckSamePhoneNumCustomer(i.customer_phone, i.customer_id))
            {
                if (i.customer_id == 0)
                {
                    AddCustomer(i);
                    txt = "Thêm thành công";
                    return true;
                }
                else
                {
                    UpdateCustomer(i);
                    txt = "Cập nhật thành công";
                    return true;
                }
            }
            else
            {
                txt = "Số điện thoại này đã được đăng ký. Vui lòng nhập số điện thoại khác";
                return false;
            }

        }
        public void UpdateCustomer(DTO_Customer i)
        {
            DAL_DB dal = new DAL_DB();
            dal.UpdateCustomer(i);
        }
        public void AddCustomer(DTO_Customer i)
        {
            DAL_DB dal = new DAL_DB();
            dal.AddCustomer(i);

        }
        public void DeleteCustomer(int ID)
        {
            DAL_DB dal = new DAL_DB();
            dal.DeleteCustomer(ID);
        }
      
        public List<DTO_MovieRevenue> GetMovieRevenue()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovieRevenue().OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_StaffRevenue> GetStaffRevenue()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetStaffRevenue().OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenue()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetCustomerRevenue().OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_MovieRevenue> GetMovieRevenueByMonth(int month, int year)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovieRevenueByMonth(month, year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_StaffRevenue> GetStaffRevenueByMonth(int month, int year)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetStaffRevenueByMonth(month, year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenueByMonth(int month, int year)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetCustomerRevenueByMonth(month, year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_MovieRevenue> GetMovieRevenueByYear(int year)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetMovieRevenueByYear(year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_StaffRevenue> GetStaffRevenueByYear(int year)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetStaffRevenueByYear(year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenueByYear(int year)
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetCustomerRevenueByYear(year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<int> GetAllYearRevenue()
        {
            DAL_DB dal = new DAL_DB();
            return dal.GetAllYearRevenue();
        }
    }
}
