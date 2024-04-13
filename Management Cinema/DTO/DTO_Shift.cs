using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Shift
    {
        public int shift_id { get; set; }
        public DateTime shift_date { get; set; }
        public int shifttime_id { get; set; }
        public int staff_id { get;set; }
    }
}
