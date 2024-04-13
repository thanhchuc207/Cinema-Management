using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Room
    {
        public int room_id { get; set; }
        public string room_name { get; set; }
        public DTO_CBBRoomType room_type { get; set; }
        public int room_number_of_seat { get; set; }
        public int room_number_of_row { get; set; }
    }
}
