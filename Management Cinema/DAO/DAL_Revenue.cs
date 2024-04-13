using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAL_Revenue
    {
        public List<int> GetAllYearRevenue()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                return db.TBReceipt.Select(p => p.datetime_booking.Year).Distinct().ToList();
            }
        }
        public List<DTO_MovieRevenue> GetMovieRevenue()
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
                           select (new DTO_MovieRevenue
                           {
                               movie_id = g.Key.movie_id,
                               movie_name = g.Key.movie_name,
                               number_of_tickets = g.Sum(x => x.number_of_tickets),
                               revenue = g.Sum(x => x.total_price)
                           })
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
                           where c.is_deleted == false
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
        public List<DTO_CustomerRevenue> GetCustomerRevenue()
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBCustomer on s.customer_id equals c.customer_id
                           where c.is_deleted == false
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
        public List<DTO_MovieRevenue> GetMovieRevenueByMonth(int month, int year)
        {
            using (CINEMAEntities db = new CINEMAEntities())
            {
                var item = from s in db.TBReceipt
                           join c in db.TBSchedule on s.schedule_id equals c.schedule_id
                           join t in db.TBMovie on c.movie_id equals t.movie_id
                           where s.datetime_booking.Year == year
                           where s.datetime_booking.Month == month
                           group s by
                            new
                            {
                                t.movie_id,
                                t.movie_name
                            } into g
                           select (new DTO_MovieRevenue
                           {
                               movie_id = g.Key.movie_id,
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
                           where c.is_deleted == false
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
                               movie_id = g.Key.movie_id,
                               movie_name = g.Key.movie_name,
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
                           where c.is_deleted == false
                           where s.datetime_booking.Year == year
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
    }
}
