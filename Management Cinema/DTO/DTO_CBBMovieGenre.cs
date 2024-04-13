using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CBBMovieGenre
    {
        public int movie_genre_id { get; set; }
        public string movie_genre_name { get; set; }
        public override string ToString()
        {
            return movie_genre_name;
        }
    }
}
