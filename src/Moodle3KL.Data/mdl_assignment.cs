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
    
    public partial class mdl_assignment
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public string assignmenttype { get; set; }
        public short resubmit { get; set; }
        public short preventlate { get; set; }
        public short emailteachers { get; set; }
        public Nullable<long> var1 { get; set; }
        public Nullable<long> var2 { get; set; }
        public Nullable<long> var3 { get; set; }
        public Nullable<long> var4 { get; set; }
        public Nullable<long> var5 { get; set; }
        public long maxbytes { get; set; }
        public long timedue { get; set; }
        public long timeavailable { get; set; }
        public long grade { get; set; }
        public long timemodified { get; set; }
    }
}