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
    
    public partial class mdl_enrol_otpay_coupons
    {
        public long id { get; set; }
        public long catid { get; set; }
        public string code { get; set; }
        public Nullable<long> courseid { get; set; }
        public string type { get; set; }
        public string discounttype { get; set; }
        public double value { get; set; }
        public long createtime { get; set; }
        public long lifetime { get; set; }
        public string status { get; set; }
    }
}
