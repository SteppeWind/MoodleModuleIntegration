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
    
    public partial class mdl_badge
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public long usercreated { get; set; }
        public long usermodified { get; set; }
        public string issuername { get; set; }
        public string issuerurl { get; set; }
        public string issuercontact { get; set; }
        public Nullable<long> expiredate { get; set; }
        public Nullable<long> expireperiod { get; set; }
        public short type { get; set; }
        public Nullable<long> courseid { get; set; }
        public string message { get; set; }
        public string messagesubject { get; set; }
        public short attachment { get; set; }
        public short notification { get; set; }
        public short status { get; set; }
        public Nullable<long> nextcron { get; set; }
    }
}