using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLL_TBStaff
    {
        public static int id = -1;
        public static int pass = -1;

        public void SetStaff_id(int staff_id)
        {
            id = staff_id;
        }
        public int GetId()
        {
            DAL_TBStaff staff = new DAL_TBStaff();

            return staff.GetStaff_id();
        }
        public bool CheckLogin(string username, string password)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.CheckLogin(username, password);
        }
        public string ShowErrorLogin(string username, string password)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.ShowErrorLogin(username, password);

        }
        public bool CheckEmail(string Email)
        {

            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.CheckEmail(Email);
        }
        public bool CheckPass(int check)
        {
            if (pass == check)
            {
                return true;
            }
            return false;
        }
        public void SetPass()
        {
            Random rand = new Random();
            pass = rand.Next(1000, 10000);
        }
        public void SendEmail(string Email)
        {
            var fromAddress = new MailAddress("hdtkcnp2412@gmail.com");
            var toAddress = new MailAddress(Email);
            const string fromPassword = "ucbtyuopeziedtgf";
            const string subject = "Gửi mã xác nhận đổi mật khẩu";
            string body = "Mã xác nhận cho bạn là: " + pass.ToString();

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public void RePass(string txt)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            dal.RePass(txt);


        }
        public string GetStaffName(int staff_id)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.GetStaffName(staff_id);
        }
        public bool CheckRole()
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.CheckRole();
        }
        public DTO_Staff GetInforStaff()
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.GetInforStaff();
        }
        public bool CheckPass(string pass)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.CheckPass(pass);
        }
        public void SaveEmail(string email)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            dal.SaveEmail(email);
        }
        public void SavePass(string pass="", string username = "")
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            dal.SavePass(pass, username);
        }
        public void SaveInfor(DTO_Staff inut)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            dal.SaveInfor(inut);
        }
        public bool CheckFormatPass(string userName)
        {
            return Regex.IsMatch(userName, @"^[a-zA-Z0-9]{1,16}$");
        }
        public bool CheckFormatNameStaff(string name)
        {
            return Regex.IsMatch(name, "^[a-zA-Z\\s]+$");
        }
        public bool CheckFormatPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{10}$");
        }
        public bool CheckFormatEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
        }
        public bool CheckFormatUserName(string userName)
        {
            return Regex.IsMatch(userName, @"^[a-zA-Z0-9]{1,16}$");
        }
        public bool CheckFormatBirthday(DateTime date)
        {
            if (date.Date >= DateTime.Now.Date) return false;
            return true;
        }
        public List<DTO_StaffView> GetAllStaffs()
        {
            List<DTO_StaffView> li = new List<DTO_StaffView>();
            DAL_TBStaff dal = new DAL_TBStaff();
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
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.GetStaffByName(txt);
        }
        public bool DeleteStaff(int ID)
        {
            if (ID == GetId())
            {
                return false;
            }
            DAL_TBStaff dal = new DAL_TBStaff();
            dal.DeleteStaff(ID);
            return true;
        }
        public DTO_Staff GetStaff(int staff_id)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            return dal.GetStaff(staff_id);
        }
        public bool AddStaff(DTO_Staff i, ref string message)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            if (CheckSameEmailStaff(i.email, i.staff_id) == false)
            {
                message = "Thêm không thành công. Email này đã được đăng ký trong hệ thống";
                return false;
            }
            if (CheckSamePhoneStaff(i.staff_phone, i.staff_id) == false)
            {
                message = "Thêm không thành công. Số điện thoại này đã được đăng ký trong hệ thống";
                return false;
            }
            dal.AddStaff(i);
            message = "Thêm thành công";
            return true;
        }
        public bool CheckSameEmailStaff(string email, int staffID)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
            if (staffID == 0)
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
                foreach (var item in dal.GetAllStaffs())
                {
                    if ((item.staff_id != staffID) && (item.email == email))
                        return false;
                }
                return true;
            }
        }
        public bool CheckSamePhoneStaff(string phone, int staffID)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
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
                    {
                        
                        return false;
                    }
                       
                }
                return true;
            }
        }
        public bool UpdateStaff(DTO_Staff i, ref string message)
        {
            DAL_TBStaff dal = new DAL_TBStaff();
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
    }
}
