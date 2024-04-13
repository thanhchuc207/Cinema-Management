using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TBSchedule
    {
        public int schedule_id { get; set; }
        public DateTime schedule_date { get; set; }
        public TimeSpan schedule_start { get; set; }
        public TimeSpan schedule_end { get; set; }
        public int schedule_price_percent { get; set; }
        public int movie_id { get; set; }
        public int room_id { get; set; }
        public bool room_type { get; set; }

    }
}
