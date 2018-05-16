//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class clinicHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clinicHistory()
        {
            this.clinicDates = new HashSet<clinicDate>();
        }
    
        public int id { get; set; }
        public int patientId { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<decimal> weight { get; set; }
        public Nullable<decimal> height { get; set; }
        public string alergies { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clinicDate> clinicDates { get; set; }
        public virtual patient patient { get; set; }
    }
}