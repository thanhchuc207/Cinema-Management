using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Schedule
    {
        
        public int schedule_id {  get; set; }
        public DTO_CBBMovie movie { get; set; }
        public DateTime schedule_date { get; set; }
        public TimeSpan  schedule_start { get; set; }
        public TimeSpan  schedule_end { get; set; }
        public DTO_CBBRoom room { get; set; }
        public int schedule_price_percent{ get; set; }
    }

}
