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
    
    public partial class TBReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBReceipt()
        {
            this.TBSeatBooking = new HashSet<TBSeatBooking>();
        }
    
        public int receipt_id { get; set; }
        public int number_of_tickets { get; set; }
        public int total_price { get; set; }
        public Nullable<int> customer_id { get; set; }
        public int staff_id { get; set; }
        public int schedule_id { get; set; }
        public System.DateTime datetime_booking { get; set; }
    
        public virtual TBCustomer TBCustomer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBSeatBooking> TBSeatBooking { get; set; }
        public virtual TBSchedule TBSchedule { get; set; }
        public virtual TBStaff TBStaff { get; set; }
    }
}
