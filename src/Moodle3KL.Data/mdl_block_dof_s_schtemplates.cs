//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace Moodle3KL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class mdl_block_dof_s_schtemplates
    {
        public long id { get; set; }
        public Nullable<long> cstreamid { get; set; }
        public Nullable<short> daynum { get; set; }
        public Nullable<short> dayvar { get; set; }
        public string type { get; set; }
        [Column("begin")]
        public Nullable<long> abegin { get; set; }
        public Nullable<long> duration { get; set; }
        public string place { get; set; }
        public string form { get; set; }
        public Nullable<long> departmentid { get; set; }
        public string status { get; set; }
        public double salfactor { get; set; }
    }
}
