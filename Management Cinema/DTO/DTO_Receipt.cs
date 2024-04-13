using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Receipt
    {
        public Nullable<int> receipt_id { get; set; }
        public int number_of_tickets { get; set; }
        public int total_price { get; set; }
        public Nullable<int> customer_id { get; set; }
        public int staff_id { get; set; }
        public int schedule_id { get; set; }
        public DateTime datetime_booking { get; set; }

    }
}
