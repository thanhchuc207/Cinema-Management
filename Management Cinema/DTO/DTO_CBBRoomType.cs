using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CBBRoomType
    {
        public int room_type_id { get; set; }
        public string room_type_name { get; set; }
        public int room_type_price { get; set; }
        public override string ToString()
        {
            return room_type_name;

        }
    }
}
