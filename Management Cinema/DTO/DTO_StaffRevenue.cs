using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_StaffRevenue
    {
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public int number_of_tickets { get; set; }
        public long revenue { get; set; }
    }
}
