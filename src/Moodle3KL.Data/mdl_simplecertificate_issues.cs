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
    
    public partial class mdl_simplecertificate_issues
    {
        public long id { get; set; }
        public long certificateid { get; set; }
        public long userid { get; set; }
        public string certificatename { get; set; }
        public string code { get; set; }
        public long timecreated { get; set; }
        public Nullable<long> timedeleted { get; set; }
        public short haschange { get; set; }
        public string pathnamehash { get; set; }
    }
}