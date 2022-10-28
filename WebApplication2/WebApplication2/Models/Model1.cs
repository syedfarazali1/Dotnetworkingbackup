using System;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2.Models
{
    public class Model1 : DbContext
    {
      
        public Model1()
            : base("name=Model1")
        {
        }

        

         public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string email { get; set; }
    }
}