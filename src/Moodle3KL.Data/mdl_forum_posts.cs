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
    
    public partial class mdl_forum_posts
    {
        public long id { get; set; }
        public long discussion { get; set; }
        public long parent { get; set; }
        public long userid { get; set; }
        public long created { get; set; }
        public long modified { get; set; }
        public short mailed { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public short messageformat { get; set; }
        public short messagetrust { get; set; }
        public string attachment { get; set; }
        public short totalscore { get; set; }
        public long mailnow { get; set; }
    }
}
