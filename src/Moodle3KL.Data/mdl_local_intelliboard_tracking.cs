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
    
    public partial class mdl_local_intelliboard_tracking
    {
        public long id { get; set; }
        public Nullable<long> userid { get; set; }
        public Nullable<long> courseid { get; set; }
        public string page { get; set; }
        public Nullable<long> param { get; set; }
        public Nullable<long> visits { get; set; }
        public Nullable<long> timespend { get; set; }
        public Nullable<long> firstaccess { get; set; }
        public Nullable<long> lastaccess { get; set; }
        public string useragent { get; set; }
        public string useros { get; set; }
        public string userlang { get; set; }
        public string userip { get; set; }
    }
}
