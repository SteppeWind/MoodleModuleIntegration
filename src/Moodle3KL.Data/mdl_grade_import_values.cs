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
    
    public partial class mdl_grade_import_values
    {
        public long id { get; set; }
        public Nullable<long> itemid { get; set; }
        public Nullable<long> newgradeitem { get; set; }
        public long userid { get; set; }
        public Nullable<decimal> finalgrade { get; set; }
        public string feedback { get; set; }
        public long importcode { get; set; }
        public Nullable<long> importer { get; set; }
        public Nullable<short> importonlyfeedback { get; set; }
    }
}
