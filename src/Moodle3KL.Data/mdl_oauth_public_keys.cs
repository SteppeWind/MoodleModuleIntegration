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
    
    public partial class mdl_oauth_public_keys
    {
        public long id { get; set; }
        public string client_id { get; set; }
        public string public_key { get; set; }
        public string private_key { get; set; }
        public string encryption_algorithm { get; set; }
    }
}
