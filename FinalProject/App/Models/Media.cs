//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Media
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public string Url { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<int> DeletedBy { get; set; }
    
        public virtual Staff Staff { get; set; }
        public virtual Staff Staff1 { get; set; }
    }
}
