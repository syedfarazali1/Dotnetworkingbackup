//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Icecreamepalourmanagementsystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderDetail
    {
        public int orderDetailId { get; set; }
        public Nullable<int> Ord_id { get; set; }
        public Nullable<int> BookId { get; set; }
        public double Price { get; set; }
    
        public virtual book book { get; set; }
        public virtual Oder Oder { get; set; }
    }
}
