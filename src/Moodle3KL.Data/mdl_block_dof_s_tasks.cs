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
    
    public partial class mdl_block_dof_s_tasks
    {
        public long id { get; set; }
        public long parentid { get; set; }
        public long assignedpersonid { get; set; }
        public long purchaserpersonid { get; set; }
        public string title { get; set; }
        public string about { get; set; }
        public string solution { get; set; }
        public long date { get; set; }
        public Nullable<long> actualdate { get; set; }
        public Nullable<long> deadlinedate { get; set; }
        public string status { get; set; }
    }
}