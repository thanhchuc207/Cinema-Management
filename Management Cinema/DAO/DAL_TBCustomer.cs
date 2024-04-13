using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_TBCustomer
    {
        public List<string> GetAllCustomerPhoneNum()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBCustomer.Where(p => p.is_deleted == false).Select(p => p.customer_phone).ToList();
            }
        }
        //public List<TBCustomer> GetAllCustomers()
        //{
        //    List<TBCustomer> li = new List<TBCustomer>();
        //    using (CINEMAEntities db = new CINEMAEntities())
        //    {
        //        li = db.TBCustomer.Where(p => p.is_deleted == false)
        //        .Select(p => p).ToList();

        //    }
        //    return li;
        //}
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
        public DTO_Customer GetCustomerByID(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBCustomer.Where(p => p.is_deleted == false).Where(p => p.customer_id == id)
                .Select(p => new DTO_Customer
                {
                    customer_id = p.customer_id,
                    customer_name = p.customer_name,
                    customer_birthday = p.customer_birthday,
                    customer_address = p.customer_address,
                    customer_phone = p.customer_phone,
                    customer_points = p.customer_points,
                }).FirstOrDefault();
                return s;
            }
        }
        public List<DTO_Customer> GetAllCustomers()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var s = db.TBCustomer.Where(p => p.is_deleted == false)
                .Select(i => new DTO_Customer
                {
                    customer_id = i.customer_id,
                    customer_name = i.customer_name,
                    customer_birthday = i.customer_birthday,
                    customer_address = i.customer_address,
                    customer_phone = i.customer_phone,
                    customer_points = i.customer_points,
                });
                return s.ToList();
            }

        }
        public List<DTO_Customer> GetCustomerByNameOrID(string txt)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var query = db.TBCustomer.Where(p => p.is_deleted == false).Where(p => p.customer_name.Contains(txt) || p.customer_id.ToString().Contains(txt))
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
        public bool CheckPhone(string phone)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBCustomer customer = db.TBCustomer.Where(p => p.customer_phone == phone).FirstOrDefault();
                if (customer == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public DTO_Customer GetTBCustomerDTO(string phone)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                DTO_Customer result = new DTO_Customer();
                TBCustomer customer = db.TBCustomer.Where(p => p.customer_phone == phone).FirstOrDefault();
                if (customer != null)
                {
                    if (customer.is_deleted != true)
                    {
                        result.customer_id = customer.customer_id;
                        result.customer_name = customer.customer_name;
                        result.customer_phone = customer.customer_phone;
                        result.customer_birthday = customer.customer_birthday;
                        result.customer_address = customer.customer_address;
                    }
                }
                return result;
            }

        }
        public int GetID(string phone)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int id = db.TBCustomer.Where(p => p.customer_phone == phone).Select(p => p.customer_id).FirstOrDefault();
                return id;
            }
        }
        public int SetCustomer(DTO_Customer customerDTO)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                int id = -1;
                TBCustomer cus = new TBCustomer();
                cus.customer_points = customerDTO.customer_points;
                cus.customer_phone = customerDTO.customer_phone;
                cus.customer_name = customerDTO.customer_name;
                cus.customer_address = customerDTO.customer_address;
                cus.customer_birthday = customerDTO.customer_birthday;
                db.TBCustomer.Add(cus);
                db.SaveChanges();
                id = GetID(customerDTO.customer_phone);
                return id;
            }
        }
        public List<DTO_Customer> GetListCustomers()
        {

            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_Customer> result = new List<DTO_Customer>();
                List<TBCustomer> list = db.TBCustomer.ToList();
                foreach (TBCustomer c in list)
                {
                    result.Add(new DTO_Customer
                    {
                        customer_id = c.customer_id,
                        customer_name = c.customer_name,
                        customer_address = c.customer_address,
                        customer_birthday = c.customer_birthday,
                        customer_phone = c.customer_phone,
                    });
                }
                return result;
            }
        }
       
        public List<DTO_Customer> GetListCustomers(string name)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                List<DTO_Customer> customer = new List<DTO_Customer>();
                List<TBCustomer> list = db.TBCustomer.ToList();
                foreach (TBCustomer c in list)
                {
                    if (c.is_deleted == false && (c.customer_name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        customer.Add(new DTO_Customer
                        {
                            customer_id = c.customer_id,
                            customer_name = c.customer_name,
                            customer_address = c.customer_address,
                            customer_phone = c.customer_phone,
                            customer_birthday = c.customer_birthday
                        });
                    }
                }
                return customer;
            }
        }
        public DTO_Customer GetCustomer(int id)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                TBCustomer customer = db.TBCustomer.Where(p => p.customer_id == id).FirstOrDefault();
                DTO_Customer result = new DTO_Customer();
                if (customer != null)
                {
                    result.customer_id = customer.customer_id;
                    result.customer_name = customer.customer_name;
                    result.customer_address = customer.customer_address;
                    result.customer_birthday = customer.customer_birthday;
                    result.customer_phone = customer.customer_phone;
                }
                return result;
            }
        }
        public void SaveOrUpdate(DTO_Customer customer)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                if (customer.customer_id == -1)
                {
                    TBCustomer result = new TBCustomer();
                    result.customer_name = customer.customer_name;
                    result.customer_address = customer.customer_address;
                    result.customer_points = 0;
                    result.customer_birthday = customer.customer_birthday;
                    result.customer_phone = customer.customer_phone;
                    db.TBCustomer.Add(result);
                    db.SaveChanges();
                }
                else
                {
                    TBCustomer result = db.TBCustomer.Where(p => p.customer_id == customer.customer_id).FirstOrDefault();
                    if (result != null)
                    {
                        result.customer_name = customer.customer_name;
                        result.customer_phone = customer.customer_phone;
                        result.customer_address = customer.customer_address;
                        result.customer_points = customer.customer_points;
                        result.customer_birthday = customer.customer_birthday;
                        db.TBCustomer.AddOrUpdate(result);
                        db.SaveChanges();
                    }

                }
            }

        }
        public List<DTO_CustomerStatitic> GetListCusomerStatitic(string time, string items)
        {
            using (var db = new CINEMAEntities())
            {
                List<DTO_CustomerStatitic> list = new List<DTO_CustomerStatitic>();
                if (time == "Tháng")
                {
                    int month = int.Parse(items);

                    DateTime date = new DateTime(DateTime.Now.Year, month, 1);
                    list = db.TBCustomer
                .Join(db.TBReceipt, c => c.customer_id, r => r.customer_id, (c, r) => new { Customer = c, Receipt = r })
                .Where(cr => cr.Receipt.TBSchedule.schedule_date.Month == month && cr.Receipt.TBSchedule.schedule_date.Year == date.Year)
                .GroupBy(cr => cr.Customer.customer_name)
                .Select(g => new DTO_CustomerStatitic
                {
                    customer_name = g.FirstOrDefault().Customer.customer_name,
                    number_of_ticket = g.Sum(cr => cr.Receipt.number_of_tickets),
                    total_price = g.Sum(cr => cr.Receipt.total_price)
                })
                .OrderByDescending(result => result.total_price)
                .ToList();

                }
                else if (time == "Năm")
                {
                    int year = int.Parse(items);
                    list = db.TBCustomer
                .Join(db.TBReceipt, c => c.customer_id, r => r.customer_id, (c, r) => new { Customer = c, Receipt = r })
                .Where(cr => cr.Receipt.TBSchedule.schedule_date.Year == year)
                .GroupBy(cr => cr.Customer.customer_name)
                .Select(g => new DTO_CustomerStatitic
                {
                    customer_name = g.FirstOrDefault().Customer.customer_name,
                    number_of_ticket = g.Sum(cr => cr.Receipt.number_of_tickets),
                    total_price = g.Sum(cr => cr.Receipt.total_price)
                })
                .OrderByDescending(result => result.total_price)
                .ToList();

                }
                return list;
            }
        }


    }
}
