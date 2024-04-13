using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Seat_Type
    {
        public int seat_type_id { get; set; }
        public string seat_type_name { get; set; }
        public int seat_type_price_percent { get; set; }
        public string seat_type_color { get; set; }
    }
}
