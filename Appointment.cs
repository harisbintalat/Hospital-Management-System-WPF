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
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int Id { get; set; }
        public Nullable<int> doctor_id { get; set; }
        public Nullable<int> patient_id { get; set; }
        public string DoctorName { get; set; }
        public Nullable<System.DateTime> appointment_date { get; set; }
        public string appointment_details { get; set; }
    
        public virtual Doctor1 Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
