using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MovieRevenue
    {
        public int movie_id { get; set; }
       public string movie_name { get; set; }
       public int number_of_tickets { get; set; }
       public long revenue { get; set; }
    }
}
