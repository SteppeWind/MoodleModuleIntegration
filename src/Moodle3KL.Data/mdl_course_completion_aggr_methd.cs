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
    
    public partial class mdl_course_completion_aggr_methd
    {
        public long id { get; set; }
        public long course { get; set; }
        public Nullable<long> criteriatype { get; set; }
        public short method { get; set; }
        public Nullable<decimal> value { get; set; }
    }
}