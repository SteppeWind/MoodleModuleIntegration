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
    
    public partial class mdl_enrol_otpay
    {
        public long id { get; set; }
        public string paymentid { get; set; }
        public string externalpaymentid { get; set; }
        public long instanceid { get; set; }
        public long enrolmentid { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public Nullable<double> amount { get; set; }
        public string currency { get; set; }
        public string type { get; set; }
        public string paymethod { get; set; }
        public string status { get; set; }
        public Nullable<long> enrolmentstartdate { get; set; }
        public Nullable<long> enrolmentenddate { get; set; }
        public long createdate { get; set; }
        public long timemodified { get; set; }
        public string options { get; set; }
    }
}