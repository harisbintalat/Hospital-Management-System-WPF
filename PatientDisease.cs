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
    
    public partial class PatientDisease
    {
        public int Id { get; set; }
        public Nullable<int> Patient_id { get; set; }
        public string Disease { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
