//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apiwithrelationship.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class salary
    {
        public int ID { get; set; }
        public string Amount { get; set; }
        public Nullable<int> St_ID { get; set; }
    
        public virtual staff staff { get; set; }
    }
}
