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
    
    public partial class mdl_gradingform_guide_fillings
    {
        public long id { get; set; }
        public long instanceid { get; set; }
        public long criterionid { get; set; }
        public string remark { get; set; }
        public Nullable<short> remarkformat { get; set; }
        public decimal score { get; set; }
    }
}