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
    
    public partial class mdl_feedback_item
    {
        public long id { get; set; }
        public long feedback { get; set; }
        public long template { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public string presentation { get; set; }
        public string typ { get; set; }
        public short hasvalue { get; set; }
        public short position { get; set; }
        public short required { get; set; }
        public long dependitem { get; set; }
        public string dependvalue { get; set; }
        public string options { get; set; }
    }
}