//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_multishopwebapi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_User()
        {
            this.tbl_Contact = new HashSet<tbl_Contact>();
        }
    
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public string U_Email { get; set; }
        public Nullable<int> U_Age { get; set; }
        public string U_Gender { get; set; }
        public string U_cell { get; set; }
        public string U_Address { get; set; }
        public string U_Cnic { get; set; }
        public string U_Img { get; set; }
        public string U_Status { get; set; }
        public string U_UserName { get; set; }
        public string U_Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Contact> tbl_Contact { get; set; }
    }
}
