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
    
    public partial class TBSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBSchedule()
        {
            this.TBReceipt = new HashSet<TBReceipt>();
            this.TBSeatBooking = new HashSet<TBSeatBooking>();
        }
    
        public int schedule_id { get; set; }
        public System.DateTime schedule_date { get; set; }
        public System.TimeSpan schedule_start { get; set; }
        public System.TimeSpan schedule_end { get; set; }
        public int schedule_price_percent { get; set; }
        public Nullable<int> movie_id { get; set; }
        public int room_id { get; set; }
        public bool is_deleted { get; set; }
    
        public virtual TBMovie TBMovie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBReceipt> TBReceipt { get; set; }
        public virtual TBRoom TBRoom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBSeatBooking> TBSeatBooking { get; set; }
    }
}