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
    
    public partial class Comment
    {
        public int cid { get; set; }
        public int pid { get; set; }
        public int uid { get; set; }
<<<<<<< HEAD
        public string comment1 { get; set; }
=======
        public string comment { get; set; }
>>>>>>> b6bf37a8880ccc2de8a13240dfbe512bf1c13afa
        public Nullable<int> upVote { get; set; }
        public Nullable<int> downVote { get; set; }
        public System.DateTime dateTime { get; set; }
    
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
