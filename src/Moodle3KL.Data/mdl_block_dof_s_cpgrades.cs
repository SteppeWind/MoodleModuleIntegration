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
    
    public partial class mdl_block_dof_s_cpgrades
    {
        public long id { get; set; }
        public Nullable<long> cpassedid { get; set; }
        public Nullable<long> planid { get; set; }
        public string grade { get; set; }
        public Nullable<long> date { get; set; }
        public string notice { get; set; }
        public string typesync { get; set; }
        public Nullable<long> mdlinstance { get; set; }
        public Nullable<long> orderid { get; set; }
        public Nullable<long> teacherid { get; set; }
        public string status { get; set; }
    }
}
