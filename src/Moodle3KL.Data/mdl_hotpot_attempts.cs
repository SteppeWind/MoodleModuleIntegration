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
    
    public partial class mdl_hotpot_attempts
    {
        public long id { get; set; }
        public long hotpotid { get; set; }
        public long userid { get; set; }
        public long starttime { get; set; }
        public long endtime { get; set; }
        public int score { get; set; }
        public int penalties { get; set; }
        public int attempt { get; set; }
        public long timestart { get; set; }
        public long timefinish { get; set; }
        public short status { get; set; }
        public long clickreportid { get; set; }
        public long timemodified { get; set; }
    }
}