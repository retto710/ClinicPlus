﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalAppWebEntities : DbContext
    {
        public FinalAppWebEntities()
            : base("name=FinalAppWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<clinicDate> clinicDates { get; set; }
        public virtual DbSet<clinicHistory> clinicHistories { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<doctor_speciality> doctor_speciality { get; set; }
        public virtual DbSet<nurse> nurses { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<speciality> specialities { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
