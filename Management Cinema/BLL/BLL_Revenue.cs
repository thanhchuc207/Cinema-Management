using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Revenue
    {
        public List<int> GetAllYearRevenue()
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetAllYearRevenue();
        }
        public List<DTO_MovieRevenue> GetMovieRevenue()
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetMovieRevenue().OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_StaffRevenue> GetStaffRevenue()
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetStaffRevenue().OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenue()
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetCustomerRevenue().OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_MovieRevenue> GetMovieRevenueByMonth(int month, int year)
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetMovieRevenueByMonth(month, year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_StaffRevenue> GetStaffRevenueByMonth(int month, int year)
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetStaffRevenueByMonth(month, year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenueByMonth(int month, int year)
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetCustomerRevenueByMonth(month, year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_MovieRevenue> GetMovieRevenueByYear(int year)
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetMovieRevenueByYear(year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_StaffRevenue> GetStaffRevenueByYear(int year)
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetStaffRevenueByYear(year).OrderByDescending(p => p.revenue).ToList();
        }
        public List<DTO_CustomerRevenue> GetCustomerRevenueByYear(int year)
        {
            DAL_Revenue dal = new DAL_Revenue();
            return dal.GetCustomerRevenueByYear(year).OrderByDescending(p => p.revenue).ToList();
        }
    }
}
