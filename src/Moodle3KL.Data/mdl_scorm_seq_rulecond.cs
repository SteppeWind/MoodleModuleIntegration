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
    
    public partial class mdl_scorm_seq_rulecond
    {
        public long id { get; set; }
        public long scoid { get; set; }
        public long ruleconditionsid { get; set; }
        public string refrencedobjective { get; set; }
        public double measurethreshold { get; set; }
        public string @operator { get; set; }
        public string cond { get; set; }
    }
}
