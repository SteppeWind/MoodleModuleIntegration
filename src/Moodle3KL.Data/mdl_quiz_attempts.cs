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
    
    public partial class mdl_quiz_attempts
    {
        public long id { get; set; }
        public long quiz { get; set; }
        public long userid { get; set; }
        public int attempt { get; set; }
        public long uniqueid { get; set; }
        public string layout { get; set; }
        public long currentpage { get; set; }
        public short preview { get; set; }
        public string state { get; set; }
        public long timestart { get; set; }
        public long timefinish { get; set; }
        public long timemodified { get; set; }
        public Nullable<long> timecheckstate { get; set; }
        public Nullable<decimal> sumgrades { get; set; }
    }
}