//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace Moodle3KL.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class mdl_comdi
    {
        public long id { get; set; }
        public long course { get; set; }
        public long teacher { get; set; }
        public long type { get; set; }
        public long is_moderated_room { get; set; }
        public long max_user { get; set; }
        public long language { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public long timecreated { get; set; }
        public long timemodified { get; set; }
        public string event_id { get; set; }
        public string start { get; set; }
        public Nullable<short> opt_continuation { get; set; }
        [Column("end")]
        public long aend { get; set; }
    }
}