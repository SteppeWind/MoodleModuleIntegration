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
    
    public partial class mdl_scale
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public long userid { get; set; }
        public string name { get; set; }
        public string scale { get; set; }
        public string description { get; set; }
        public short descriptionformat { get; set; }
        public long timemodified { get; set; }
    }
}