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
    
    public partial class CustomerPaymentTable
    {
        public int CustomerPaymentID { get; set; }
        public int Customer_ID { get; set; }
        public int CustomerInvoice_ID { get; set; }
        public int User_ID { get; set; }
        public int InvoiceNo { get; set; }
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double RemainingBalance { get; set; }
    }
}
