using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CBBRole
    {
        public bool role_id {  get; set; }
        public string role_name { get; set; }
        public override string ToString()
        {
            return role_name;
        }
    }
}
