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
    
    public partial class mdl_mnet_log
    {
        public long id { get; set; }
        public long hostid { get; set; }
        public long remoteid { get; set; }
        public long time { get; set; }
        public long userid { get; set; }
        public string ip { get; set; }
        public long course { get; set; }
        public string coursename { get; set; }
        public string module { get; set; }
        public long cmid { get; set; }
        public string action { get; set; }
        public string url { get; set; }
        public string info { get; set; }
    }
}
