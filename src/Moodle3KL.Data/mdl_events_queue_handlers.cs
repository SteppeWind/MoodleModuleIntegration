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
    
    public partial class mdl_events_queue_handlers
    {
        public long id { get; set; }
        public long queuedeventid { get; set; }
        public long handlerid { get; set; }
        public Nullable<long> status { get; set; }
        public string errormessage { get; set; }
        public long timemodified { get; set; }
    }
}
