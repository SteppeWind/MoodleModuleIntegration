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
    
    public partial class mdl_course_format_options
    {
        public long id { get; set; }
        public long courseid { get; set; }
        public string format { get; set; }
        public long sectionid { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}