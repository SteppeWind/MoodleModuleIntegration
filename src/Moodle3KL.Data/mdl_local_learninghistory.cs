//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Moodle3KL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class mdl_local_learninghistory
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public Nullable<decimal> finalgrade { get; set; }
        public Nullable<decimal> completion { get; set; }
        public Nullable<long> begindate { get; set; }
        public Nullable<long> enddate { get; set; }
        public string status { get; set; }
        public Nullable<long> lastupdate { get; set; }
        public string enroltype { get; set; }
        public Nullable<long> previd { get; set; }
        public Nullable<short> graderestored { get; set; }
    }
}