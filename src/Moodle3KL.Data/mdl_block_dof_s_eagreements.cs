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
    
    public partial class mdl_block_dof_s_eagreements
    {
        public long id { get; set; }
        public Nullable<long> personid { get; set; }
        public string num { get; set; }
        public string numpass { get; set; }
        public Nullable<long> date { get; set; }
        public Nullable<long> begindate { get; set; }
        public Nullable<long> enddate { get; set; }
        public Nullable<long> departmentid { get; set; }
        public string status { get; set; }
        public string notice { get; set; }
        public Nullable<long> adddate { get; set; }
    }
}