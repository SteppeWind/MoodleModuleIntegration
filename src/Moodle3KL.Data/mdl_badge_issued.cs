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
    
    public partial class mdl_badge_issued
    {
        public long id { get; set; }
        public long badgeid { get; set; }
        public long userid { get; set; }
        public string uniquehash { get; set; }
        public long dateissued { get; set; }
        public Nullable<long> dateexpire { get; set; }
        public short visible { get; set; }
        public Nullable<long> issuernotified { get; set; }
    }
}
