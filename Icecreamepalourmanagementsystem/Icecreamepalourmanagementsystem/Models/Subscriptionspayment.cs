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
    
    public partial class Subscriptionspayment
    {
        public int SubpayId { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> SubId { get; set; }
        public string Date { get; set; }
    
        public virtual tblSubscription tblSubscription { get; set; }
        public virtual tbluser tbluser { get; set; }
    }
}