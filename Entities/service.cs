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
    
    public partial class service
    {
        public int ID { get; set; }
        public int doctorId { get; set; }
        public int clinicDateId { get; set; }
        public System.DateTime dateOfRequest { get; set; }
        public System.DateTime dateOfService { get; set; }
        public string description { get; set; }
        public bool status { get; set; }
    
        public virtual clinicDate clinicDate { get; set; }
        public virtual doctor doctor { get; set; }
    }
}
