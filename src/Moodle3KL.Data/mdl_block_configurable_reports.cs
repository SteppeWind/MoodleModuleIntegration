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
    
    public partial class mdl_block_configurable_reports
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long ownerid { get; set; }
        public short visible { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string type { get; set; }
        public Nullable<short> pagination { get; set; }
        public string components { get; set; }
        public string export { get; set; }
        public Nullable<short> jsordering { get; set; }
        public Nullable<short> global { get; set; }
        public Nullable<long> lastexecutiontime { get; set; }
        public short cron { get; set; }
        public Nullable<short> remote { get; set; }
    }
}