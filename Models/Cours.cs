//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AskNLearn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cours
    {
        public Cours()
        {
            this.Documents = new HashSet<Document>();
            this.EnrolledUsers = new HashSet<EnrolledUser>();
            this.Quizes = new HashSet<Quize>();
        }
    
        public int coid { get; set; }
        public int uid { get; set; }
        public string title { get; set; }
        public string details { get; set; }
        public double price { get; set; }
        public Nullable<int> upVote { get; set; }
        public Nullable<int> downVote { get; set; }
        public System.DateTime dateTime { get; set; }
        public string thumbnail { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<EnrolledUser> EnrolledUsers { get; set; }
        public virtual ICollection<Quize> Quizes { get; set; }
    }
}
