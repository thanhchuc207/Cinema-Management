//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBMovie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBMovie()
        {
            this.TBSchedule = new HashSet<TBSchedule>();
        }
    
        public int movie_id { get; set; }
        public string movie_name { get; set; }
        public int movie_genres_id { get; set; }
        public string movie_description { get; set; }
        public int movie_length { get; set; }
        public System.DateTime movie_release { get; set; }
        public int movie_price { get; set; }
        public bool is_deleted { get; set; }
        public string movie_image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBSchedule> TBSchedule { get; set; }
        public virtual TBMovieGenres TBMovieGenres { get; set; }
    }
}
