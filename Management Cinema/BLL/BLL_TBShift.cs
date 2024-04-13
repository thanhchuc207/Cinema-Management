using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TBShift
    {
        public string GetTimes(int id_shifttime)
        {
            DAL_TBShift TBShift = new DAL_TBShift();
            return TBShift.GetTimes(id_shifttime);
        }
        public List<DTO_Shift> GetListShift(DateTime date)
        {
            DAL_TBShift TBShift = new DAL_TBShift();
            return TBShift.GetListShift(date);
        }
    }
}
