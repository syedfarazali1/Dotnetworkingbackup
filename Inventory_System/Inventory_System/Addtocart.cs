using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Addtocart
    {
    
        public int CategoryID { get; set; }
        public int Suplier_ID { get; set; }
        public string Product_Name { get; set; }
        public int Qty { get; set; }
        public double Product_unit_price { get; set; }
        public double total { get; set; }
        public DateTime Dateofexpiry { get; set; }
        public DateTime Dateofmanufacture { get; set; }
     


    }
}
