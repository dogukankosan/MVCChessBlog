//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessProject.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Comment
    {
        public short ID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public short BlogID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<bool> CommentOkay { get; set; }
    
        public virtual Tbl_Blog Tbl_Blog { get; set; }
    }
}
