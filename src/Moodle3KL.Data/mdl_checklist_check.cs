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
    
    public partial class mdl_checklist_check
    {
        public long id { get; set; }
        public long item { get; set; }
        public long userid { get; set; }
        public long usertimestamp { get; set; }
        public short teachermark { get; set; }
        public long teachertimestamp { get; set; }
        public Nullable<long> teacherid { get; set; }
    }
}
