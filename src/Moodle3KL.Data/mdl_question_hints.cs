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
    
    public partial class mdl_question_hints
    {
        public long id { get; set; }
        public long questionid { get; set; }
        public string hint { get; set; }
        public short hintformat { get; set; }
        public Nullable<short> shownumcorrect { get; set; }
        public Nullable<short> clearwrong { get; set; }
        public string options { get; set; }
    }
}