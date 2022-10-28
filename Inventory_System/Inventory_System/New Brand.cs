using Inventory_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Brand : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public Brand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryTable a = new CategoryTable();

            if (catid.Text == "")
            {
                catname.Text = a.CategoryName;
                db.CategoryTables.Add(a);
                db.SaveChanges();
            }
            else
            {
                int c = Convert.ToInt32(catid.Text);
                var i = db.CategoryTables.Where(x => x.CategoryID == c).FirstOrDefault();

                i.CategoryName = catname.Text;
                i.CategoryID = Convert.ToInt32(catid.Text);
                db.Entry(i).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Updatet");

            }
            catid.Text = null;
            catname.Text = "";
            load();
        }

        private void load()
        {
            List<CategoryTable> cat = db.CategoryTables.ToList();
            datatable.DataSource = cat;
           // datatable.Columns["PurchaseTables"].Visible = false;
          //  datatable.Columns["SupplierInvoiceTables"].Visible = false;
        }

    }
}
