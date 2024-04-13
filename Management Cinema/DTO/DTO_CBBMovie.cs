using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CBBMovie
    {
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public override string ToString()
        {
            return movie_name;
        }
    }
}
