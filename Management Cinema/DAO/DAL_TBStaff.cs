using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBStaff
    {
        public static int id = -1;
        public void SetStaff_id(int staff_id)
        {
            id = staff_id;
        }
        public int GetStaff_id() { return id; }
        public bool CheckLogin(string username, string password)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                string hass = BCrypt.Net.BCrypt.HashPassword(password, 10);
                TBStaff staff = db.TBStaff.Where(p => p.username == username).FirstOrDefault();
                if (staff != null)
                {
                    bool ck = BCrypt.Net.BCrypt.Verify(password, staff.pwd);
                    if (ck == false)
                    {
                        return false;
                    }
                    else
                    {
                        SetStaff_id(staff.staff_id);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public string ShowErrorLogin(string username, string password)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBStaff staff = db.TBStaff.Where(p => p.username == username).FirstOrDefault();
                if (staff != null)
                {
                    bool ck = BCrypt.Net.BCrypt.Verify(password, staff.pwd);
                    if (ck == false)
                    {
                        return "Sai mật khẩu";
                    }

                }
                else
                {
                    return "Không tìm thấy tài khoản cần tìm";
                }
                return null;
            }
        }
        public bool CheckEmail(string Email)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBStaff staff = db.TBStaff.Where(p => p.email == Email).FirstOrDefault();
                if (staff == null)
                {

                    return false;
                }
                id = staff.staff_id;
                return true;
            }

        }
        public void RePass(string txt)
        {
            string hass = BCrypt.Net.BCrypt.HashPassword(txt);
            using ( CINEMAEntities db = new CINEMAEntities())
            {
                TBStaff staff = db.TBStaff.Where(p => p.staff_id == id).FirstOrDefault();
                staff.pwd = hass;
                db.TBStaff.AddOrUpdate(staff);
                db.SaveChanges();
            }
        }
        public string GetStaffName(int staff_id)
        {
            string result = "";
            using (CINEMAEntities db = new CINEMAEntities())
            {
                result = db.TBStaff.Where(p => p.staff_id == staff_id).Select(p => p.staff_name).FirstOrDefault();

            }
            return result;
        }
        public bool CheckRole()
        {
            using(CINEMAEntities db=new CINEMAEntities())
            {
                bool check=db.TBStaff.Where(p=>p.staff_id==id).Select(p=>p.role).FirstOrDefault();
                return check;
            }
        }
        public DTO_Staff GetInforStaff()
        {
            using(CINEMAEntities db=new CINEMAEntities())
            {
                DTO_Staff staff=new DTO_Staff();
                int id_staff = this.GetStaff_id();
                TBStaff st=db.TBStaff.Where(p=>p.staff_id==id_staff).FirstOrDefault();
                if(st!=null)
                {
                    staff.staff_id = id_staff;
                    staff.staff_name=st.staff_name;
                    staff.email = st.email;
                    staff.staff_pwd = "";
                    staff.staff_phone = st.staff_phone;
                    staff.staff_birthday = st.staff_birthday;
                    staff.staff_gender = st.staff_gender;
                    staff.staff_usename = st.username;
                    staff.role = st.role;
                }
                return staff;
            }
        }
        public bool CheckPass(string pass)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int staff_id = id;
                string has = BCrypt.Net.BCrypt.HashPassword(pass, 10);
                string pwd = db.TBStaff.Where(p => p.staff_id == staff_id).Select(p => p.pwd).FirstOrDefault();
                if (pwd != null)
                {
                    bool ck = BCrypt.Net.BCrypt.Verify(pass, pwd);
                    if (ck == true)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public void SaveEmail(string email)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var staff = db.TBStaff.Find(id);
                if (staff != null)
                {
                    staff.email = email;
                    db.SaveChanges();
                }
            }
        }
        public void SavePass(string pass="",string username="")
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var staff = db.TBStaff.Find(id);
                if (staff != null)
                {
                    if (pass != "")
                    {
                        string hass = BCrypt.Net.BCrypt.HashPassword(pass);
                        staff.pwd = hass;
                    }
                    if (username!="")
                    {
                        staff.username = username;
                    }
                    db.SaveChanges();
                }
            }
        }
        public void SaveInfor(DTO_Staff inut)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBStaff staff = db.TBStaff.Find(inut.staff_id);
                if (staff != null)
                {
                    staff.email = inut.email;
                    staff.username = inut.staff_usename;
                    staff.staff_name = inut.staff_name;
                    staff.staff_gender = inut.staff_gender;
                    staff.staff_birthday = inut.staff_birthday;
                    staff.staff_phone = inut.staff_phone;
                    db.SaveChanges();
                }
            }
        }
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
        public void DeleteStaff(int ID)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p => p.staff_id == ID).FirstOrDefault();

                s.is_deleted = true;
                db.SaveChanges();
            }
        }
        public DTO_Staff GetStaff(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p => p.is_deleted == false).Where(p => p.staff_id == id)
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
                }).FirstOrDefault(); ;
                return s;
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
        public List<string> GetListEmailStaff()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBStaff.Where(p => p.is_deleted == false).Select(p => p.email).ToList();
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
    }
}
