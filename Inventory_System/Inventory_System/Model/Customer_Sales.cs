//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory_System.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_Sales
    {
        public Nullable<int> Sale_ID { get; set; }
        public int Product_ID { get; set; }
        public string User { get; set; }
        public Nullable<int> Customer_ID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<double> Product_unit_price { get; set; }
        public Nullable<double> Total { get; set; }
    }
}
