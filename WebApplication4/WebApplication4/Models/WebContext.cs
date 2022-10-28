using System;
using System.Data.Entity;
using System.Linq;

namespace WebApplication4.Models
{
    public class WebContext : DbContext
    {

        public WebContext()
            : base("name=WebContext")
        {
        }


    public  DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}