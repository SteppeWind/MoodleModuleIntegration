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
    
    public partial class mdl_resource
    {
        public long id { get; set; }
        public long course { get; set; }
        public string name { get; set; }
        public string intro { get; set; }
        public short introformat { get; set; }
        public short tobemigrated { get; set; }
        public short legacyfiles { get; set; }
        public Nullable<long> legacyfileslast { get; set; }
        public short display { get; set; }
        public string displayoptions { get; set; }
        public short filterfiles { get; set; }
        public long revision { get; set; }
        public long timemodified { get; set; }
    }
}
