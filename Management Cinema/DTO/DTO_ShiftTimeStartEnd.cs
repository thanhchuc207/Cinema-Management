using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ShiftTimeStartEnd
    {
        public int shifttime_id { get; set; }
        public TimeSpan shift_start {  get; set; }
        public TimeSpan shift_end { get; set;}
        public override string ToString()
        {
            return shift_start + " - " + shift_end;
        }
    }
}
