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
    
    public partial class doctor_speciality
    {
        public int id { get; set; }
        public int doctorId { get; set; }
        public int specialityId { get; set; }
    
        public virtual doctor doctor { get; set; }
        public virtual speciality speciality { get; set; }
    }
}