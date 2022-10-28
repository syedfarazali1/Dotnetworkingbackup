using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace sample.Models
{
    public class WebContext : DbContext
    {

        public WebContext()
            : base("name=WebContext")
        {
        }


        public virtual DbSet<ORDERS> ORDERs { get; set; }
    }

    public class ORDERS
    {
        [Key]

        public string ORD_NUM { get; set; }
        public string ORD_AMOUNT { get; set; }
        public string ADVANCE_AMOUNT { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ORD_DATE { get; set; }
        public string CUST_CODE { get; set; }
        public string AGENT_CODE { get; set; }
        public string ORD_DESCRIPTION { get; set; }
    }
}