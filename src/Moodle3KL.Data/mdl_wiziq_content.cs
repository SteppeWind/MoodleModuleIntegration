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
    
    public partial class mdl_wiziq_content
    {
        public long id { get; set; }
        public Nullable<long> course { get; set; }
        public Nullable<long> wiziqid { get; set; }
        public long type { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public Nullable<long> parentid { get; set; }
        public Nullable<long> prevparentid { get; set; }
        public string path { get; set; }
        public Nullable<long> userid { get; set; }
        public long uploadtime { get; set; }
        public Nullable<long> contentid { get; set; }
        public Nullable<long> old_content_id { get; set; }
        public Nullable<short> cid_change_status { get; set; }
        public Nullable<long> status { get; set; }
        public long wcid { get; set; }
    }
}
