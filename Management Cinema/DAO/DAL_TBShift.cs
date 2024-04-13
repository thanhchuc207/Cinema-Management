using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class DAL_TBShift
    {
        public string GetTimes(int id_shifttime)
        {
            using (var db = new CINEMAEntities())
            {
                TBShifttime time = db.TBShifttime.Where(p => p.shifttime_id == id_shifttime).FirstOrDefault();
                string temp = time.shift_start.ToString("hh\\:mm") + " ~ " + time.shift_end.ToString("hh\\:mm");
                return temp;
            }
        }

        public List<DTO_Shift> GetListShift(DateTime date)
        {
            using (var db = new CINEMAEntities())
            {
                DAL_TBStaff bllStaff=new DAL_TBStaff();
                List<DTO_Shift> list = new List<DTO_Shift>();
                int id = bllStaff.GetStaff_id();
                List<TBShift> shift = db.TBShift.Where(p => (p.staff_id == id)).ToList();
                foreach (TBShift i in shift)
                {
                    string temp = i.shift_date.ToString("dd/MM/yyyy");
                    string temp2 = date.ToString("dd/MM/yyyy");
                    if (temp == temp2)
                    {
                        string text = GetTimes(i.TBShifttime.shifttime_id);
                        list.Add(new DTO_Shift
                        {
                            shift_id = i.shift_id,
                            shift_time = text,
                            staff_name = bllStaff.GetStaffName(i.staff_id),
                            shift_date = date.ToString("dd/MM/yyyy")
                        });
                    }
                }
                return list;
            }
        }
    }
}
