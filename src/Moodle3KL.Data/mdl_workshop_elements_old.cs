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
    
    public partial class mdl_workshop_elements_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public short elementno { get; set; }
        public string description { get; set; }
        public short scale { get; set; }
        public short maxscore { get; set; }
        public short weight { get; set; }
        public double stddev { get; set; }
        public long totalassessments { get; set; }
        public string newplugin { get; set; }
        public Nullable<long> newid { get; set; }
    }
}
