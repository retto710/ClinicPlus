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
    
    public partial class clinicDate
    {
        public int id { get; set; }
        public int clinicHistorytId { get; set; }
        public int doctorId { get; set; }
        public int nurseId { get; set; }
        public System.DateTime dateOfRequest { get; set; }
        public System.DateTime dateOfAppointment { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
        public Nullable<decimal> weight { get; set; }
        public Nullable<decimal> height { get; set; }
        public string alergies { get; set; }
    
        public virtual doctor doctor { get; set; }
        public virtual nurse nurse { get; set; }
        public virtual clinicHistory clinicHistory { get; set; }
        public virtual service service { get; set; }
    }
}
