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
    
    public partial class mdl_grade_categories
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public Nullable<long> parent { get; set; }
        public long depth { get; set; }
        public string path { get; set; }
        public string fullname { get; set; }
        public long aggregation { get; set; }
        public long keephigh { get; set; }
        public long droplow { get; set; }
        public short aggregateonlygraded { get; set; }
        public short aggregateoutcomes { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public short hidden { get; set; }
    }
}