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
    
    public partial class mdl_workshop_stockcomments_old
    {
        public long id { get; set; }
        public long workshopid { get; set; }
        public long elementno { get; set; }
        public string comments { get; set; }
        public string newplugin { get; set; }
        public Nullable<long> newid { get; set; }
    }
}
