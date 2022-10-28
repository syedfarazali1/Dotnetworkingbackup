using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace modelbinde.Models
{
    public class WebContext : DbContext
    {
  
        public WebContext()
            : base("name=WebContext")
        {
        }

 

      public virtual DbSet<upload> uploads { get; set; }
    }

    public class upload
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public HttpPostedFileBase image { get; set; }
        [NotMapped]
        public HttpPostedFileBase file { get; set; }
    }
}