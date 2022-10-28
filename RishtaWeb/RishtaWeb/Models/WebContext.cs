using System;
using System.Data.Entity;
using System.Linq;

namespace RishtaWeb.Models
{
    public class WebContext : DbContext
    {

        public WebContext()
            : base("name=WebContext")
        {
        }



     public virtual DbSet<Tbl_Profile> Tbl_Profiles { get; set; }
    }

    public partial class Tbl_Profile
    {
        public int Id { get; set; }
        public string Height_education { get; set; }
        public string Work_with { get; set; }
        public string Job_Role { get; set; }
        public string Income { get; set; }
        public string Profile_For { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Community { get; set; }
        public string DOB { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string With_Fam { get; set; }
        public string Mar_Status { get; set; }
        public string Diet { get; set; }
        public string Height { get; set; }
        public string Cast { get; set; }
        public string About_Urself { get; set; }
        public string Ph_No { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confrim_Password { get; set; }
    }
}