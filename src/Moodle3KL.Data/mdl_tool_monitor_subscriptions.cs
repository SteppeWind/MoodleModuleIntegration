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
    
    public partial class mdl_tool_monitor_subscriptions
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long ruleid { get; set; }
        public long cmid { get; set; }
        public long userid { get; set; }
        public long timecreated { get; set; }
        public long lastnotificationsent { get; set; }
        public long inactivedate { get; set; }
    }
}