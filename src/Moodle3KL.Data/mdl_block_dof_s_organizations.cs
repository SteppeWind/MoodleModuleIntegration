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
    
    public partial class mdl_block_dof_s_organizations
    {
        public long id { get; set; }
        public string fullname { get; set; }
        public string shortname { get; set; }
        public Nullable<long> inn { get; set; }
        public Nullable<int> kpp { get; set; }
        public Nullable<long> ogrn { get; set; }
        public string bankrequisites { get; set; }
        public Nullable<long> legaladdressid { get; set; }
        public Nullable<long> currentaddressid { get; set; }
        public Nullable<long> mailingaddressid { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string additionalrequisites { get; set; }
        public string head { get; set; }
        public string posthead { get; set; }
        public string actionhead { get; set; }
    }
}