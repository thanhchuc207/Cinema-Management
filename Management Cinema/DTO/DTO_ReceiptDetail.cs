using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ReceiptDetail
    {
        public int receipt_id { get; set; }
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public DateTime datetimebooking { get; set; }
        public string movie_name { get; set; }
        public TimeSpan schedule_start { get; set; }
        public DateTime schedule_date { get; set; }
        public string room_name { get; set; }
        public int number_of_tickets { get; set; }
        public int movie_price { get; set; }
        public int total { get; set; }
    }
}
