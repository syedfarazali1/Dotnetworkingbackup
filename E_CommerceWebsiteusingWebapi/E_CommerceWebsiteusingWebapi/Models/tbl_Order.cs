//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_CommerceWebsiteusingWebapi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Order
    {
        public int Ord_Id { get; set; }
        public string Ord_Date { get; set; }
        public string Ord_Quantity { get; set; }
        public string Ord_Status { get; set; }
        public Nullable<int> Ord_CardNumber { get; set; }
        public Nullable<int> Pro_Id { get; set; }
        public Nullable<int> Ord_Bill { get; set; }
        public string Cus_Address { get; set; }
        public Nullable<int> U_Id { get; set; }
    
        public virtual tbl_Product tbl_Product { get; set; }
    }
}
