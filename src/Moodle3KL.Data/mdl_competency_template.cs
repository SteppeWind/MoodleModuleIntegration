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
    
    public partial class mdl_competency_template
    {
        public long id { get; set; }
        public string shortname { get; set; }
        public long contextid { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public short visible { get; set; }
        public Nullable<long> duedate { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public Nullable<long> usermodified { get; set; }
    }
}
