//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semester_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HMDBEntities : DbContext
    {
        public HMDBEntities()
            : base("name=HMDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientDisease> PatientDiseases { get; set; }
        public virtual DbSet<Doctor1> Doctor1 { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Lab> Labs { get; set; }
    }
}
