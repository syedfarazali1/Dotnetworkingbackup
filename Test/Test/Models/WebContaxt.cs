using System;
using System.Data.Entity;
using System.Linq;

namespace Test.Models
{
    public class WebContaxt : DbContext
    {

        public WebContaxt()
            : base("name=WebContaxt")
        {
        }


  public virtual DbSet<Registration> Registrations { get; set; }
    }

    public class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
        public int Contact { get; set; }
    }
}