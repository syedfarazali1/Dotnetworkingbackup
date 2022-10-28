using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace WebApplication3.Models
{
    public class WebContext : DbContext
    {

        public WebContext()
            : base("name=dbconn")
        {

        }


        public virtual DbSet<ORDERS> ORDERs { get; set; }
        public  DbSet<Product> Products { get; set; }
        public DbSet<Custome_signin> Custome_signin { get; set; }
        public DbSet<Owner_signin> Owner_signin { get; set; }
    }

    public class Custome_signin{
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class Owner_signin{
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class ORDERS
    {
        [Key]
        public int ID { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public string audio { get; set; }
        public string video { get; set; }
        public Product products { get; set; }
    } 
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<ORDERS> ORDERS { get; set; }
    }

}