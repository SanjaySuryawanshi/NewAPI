//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnswerList
    {
        public int AnswerListID { get; set; }
        public string AnswerCheck1 { get; set; }
        public string AnswerCheck2 { get; set; }
        public string AnswerCheck3 { get; set; }
        public string AnswerCheck4 { get; set; }
        public Nullable<int> QuestionId { get; set; }
    
        public virtual QuestionList QuestionList { get; set; }
    }
}
