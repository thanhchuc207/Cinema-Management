using DAL;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBCustomer
    {
        public List<DTO_Customer> GetAllCustomers()
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetAllCustomers();
        }
        public List<DTO_Customer> GetCustomerByNameOrID(string txt)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetCustomerByNameOrID(txt);
        }
        public bool CheckPhone(string phone)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.CheckPhone(phone);
        }
        public DTO_Customer GetTBCustomerDTO(string phone)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetTBCustomerDTO(phone);
        }
        public int GetID(string phone)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetID(phone);
        }
        public int SetCustomer(DTO_Customer customerDTO)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.SetCustomer(customerDTO);
        }
        public List<DTO_Customer> GetListCustomers()
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetListCustomers();

        }
        public bool CheckFormatIsPhone(string i)
        {
            return Regex.IsMatch(i, @"^[0-9]{10}$");
        }
        public bool CheckFormatAddress(string i)
        {
            return Regex.IsMatch(i, @"^[a-zA-Z0-9, /]*$");
        }
        public bool CheckFormatName(string i)
        {
            return Regex.IsMatch(i, @"^[a-zA-Z ]*$");
        }
        public bool CheckFormatBirday(DateTime dt)
        {
            if (dt.Date >= DateTime.Now.Date) return false;
            return true;
        }
        public List<DTO_Customer> GetListCustomers(string name)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetListCustomers(name);
        }
        public DTO_Customer GetCustomer(int id)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetCustomer(id);
        }
        public void SaveOrUpdate(DTO_Customer customer)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
             dal.SaveOrUpdate(customer);
        }
        public List<DTO_CustomerStatitic> GetListCusomerStatitic(string time, string items)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetListCusomerStatitic(time, items);
        }
        public void DeleteCustomer(int ID)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            dal.DeleteCustomer(ID);
        }
        public DTO_Customer GetCustomerByID(int customer_id)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            return dal.GetCustomerByID(customer_id);
        }
        public bool CheckSamePhoneNumCustomer(string phoneNum, int customerID)
        {
            DAL_DB dal = new DAL_DB();
            if (customerID == 0)
            {
                foreach (var item in dal.GetAllCustomerPhoneNum())
                {
                    if (string.Compare(item, phoneNum) == 0) return false;
                }
            }
            else
            {
                foreach (var item in dal.GetAllCustomers())
                {
                    if ((customerID != item.customer_id) && (phoneNum == item.customer_phone)) return false;
                }
            }
            return true;
        }
        public void UpdateCustomer(DTO_Customer i)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            dal.UpdateCustomer(i);
        }
        public void AddCustomer(DTO_Customer i)
        {
            DAL_TBCustomer dal = new DAL_TBCustomer();
            dal.AddCustomer(i);
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
    }
}
