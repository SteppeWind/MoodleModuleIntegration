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
    
    public partial class mdl_wiki_locks
    {
        public long id { get; set; }
        public long pageid { get; set; }
        public string sectionname { get; set; }
        public long userid { get; set; }
        public long lockedat { get; set; }
    }
}