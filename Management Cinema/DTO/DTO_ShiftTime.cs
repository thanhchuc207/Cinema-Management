using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ShiftTime
    {
       public int shift_time_id { get; set; }
        public TimeSpan shift_start { get; set; }
        public TimeSpan shift_end { get; set;}
    }
}
