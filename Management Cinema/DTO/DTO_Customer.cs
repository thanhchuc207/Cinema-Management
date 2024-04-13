using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public DateTime customer_birthday { get; set; }
        public string customer_address { get; set; }
        public string customer_phone { get; set; }
        public int customer_points { get; set; } 
    }
}
