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
    
    public partial class nurse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nurse()
        {
            this.clinicDates = new HashSet<clinicDate>();
        }
    
        public int id { get; set; }
        public int personId { get; set; }
        public int userid { get; set; }
        public System.DateTime dateOfEnrollment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<clinicDate> clinicDates { get; set; }
        public virtual person person { get; set; }
        public virtual user user { get; set; }
    }
}
