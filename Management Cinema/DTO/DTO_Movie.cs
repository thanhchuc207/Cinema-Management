using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Movie
    {
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public DTO_CBBMovieGenre movie_genres { get; set; }
        public string movie_description { get; set; }
        public int movie_length { get; set; }
        public System.DateTime movie_release { get; set; }
        public string movie_image { get; set; }
        public int movie_price { get; set; }
    }
}
