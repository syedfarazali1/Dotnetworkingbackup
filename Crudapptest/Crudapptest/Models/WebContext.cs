using System;
using System.Data.Entity;
using System.Linq;

namespace Crudapptest.Models
{
    public class WebContext : DbContext
    {
       
        public WebContext()
            : base("name=WebContext")
        {
        }

    

         public virtual DbSet<Registration> Registrations { get; set; }
    }

    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public int Contact { get; set; }
        public string adress { get; set; }
        public string Email { get; set; }
    }
}