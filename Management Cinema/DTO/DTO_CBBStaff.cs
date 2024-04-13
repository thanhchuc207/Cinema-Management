using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CBBStaff
    {
        public int staff_id { get; set; }
        public string staff_name { get; set; }
        public int shift_id { get; set; }
        public override string ToString()
        {
            return staff_name;
        }
    }
}
