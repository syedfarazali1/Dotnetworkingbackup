using Inventory_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Inventory_repot : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public Inventory_repot()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //var x = from a in db.PurchaseTables
            //where a.Product_Name == product.Text
            //group a by a.Qty into g
            //select new {  Count = g.Count() };
            

            var a = db.PurchaseTables.Where(x => x.Product_Name == product.Text).Sum(x => x.Qty);
            
            MessageBox.Show(a.ToString());
        }
    }
}
