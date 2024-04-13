using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Staff
    {
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public System.DateTime staff_birthday { get; set; }
        public bool staff_gender { get; set; }
        public string staff_phone { get; set; }
        public string email { get; set; }
        public bool role { get; set; }
        public string staff_usename { get; set; } 
        public string staff_pwd { get; set; }
    }
}
