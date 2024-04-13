using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Ticket
    {
        public int ticket_id { get; set; }
        public string movie_name { get; set; }
        public DateTime schedule_date { get; set; }
        public string schedule_time { get; set; }
        public string room_name { get; set; }
        public string seat_name { get; set; }
        public int receipt_id { get; set; }
        public int price { get; set; }

    }
}
