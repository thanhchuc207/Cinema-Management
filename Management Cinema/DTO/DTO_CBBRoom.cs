using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CBBRoom
    {
        public int room_id {  get; set; }
        public string room_name { get; set;}
        public override string ToString()
        {
            return room_name;
        }
    }
}
