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
    
    public partial class mdl_block_dof_s_aclwarrants
    {
        public long id { get; set; }
        public string linkptype { get; set; }
        public string linkpcode { get; set; }
        public long linkid { get; set; }
        public string linktype { get; set; }
        public string code { get; set; }
        public Nullable<long> parentid { get; set; }
        public string parenttype { get; set; }
        public short isdelegatable { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public Nullable<long> ownerid { get; set; }
        public Nullable<long> departmentid { get; set; }
    }
}