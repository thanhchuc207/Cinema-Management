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
    
    public partial class TBSeatType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBSeatType()
        {
            this.TBSeat = new HashSet<TBSeat>();
        }
    
        public int seat_type_id { get; set; }
        public string seat_type_name { get; set; }
        public int seat_type_price_percent { get; set; }
        public bool is_deleted { get; set; }
        public string seat_type_color { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBSeat> TBSeat { get; set; }
    }
}