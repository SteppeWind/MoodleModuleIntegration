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
    
    public partial class mdl_rating
    {
        public long id { get; set; }
        public long contextid { get; set; }
        public string component { get; set; }
        public string ratingarea { get; set; }
        public long itemid { get; set; }
        public long scaleid { get; set; }
        public long rating { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
    }
}
