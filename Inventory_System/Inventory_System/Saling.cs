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
    public partial class Saling : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public Saling()
        {
            InitializeComponent();
            getbrands();
            getSupplier();
            getCustomer();
            load();
        }
        private void load()
        {
            var a = db.Customer_Sales.ToList();
            Saletable.DataSource = a;
            //  Purchasetable.Columns["PurchaseTables"].Visible = false;
        }
        void getbrands()
        {
            brand.DataSource = db.CategoryTables.ToList();
            brand.ValueMember = "CategoryID";
            brand.DisplayMember = "CategoryName";
        }
        void getSupplier()
        {
            supname.DataSource = db.SupplierTables.ToList();
            supname.ValueMember = "SupplierID";
            supname.DisplayMember = "SupplierName";
        }
        void getCustomer()
        {
            cus.DataSource = db.CustomerTables.ToList();
            cus.ValueMember = "Customer_ID";
            cus.DisplayMember = "Cus_Name";
        }
        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Sup a = new Sup();
            a.ShowDialog();
            a.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer a = new customer();
            a.ShowDialog();
            a.Refresh();
        }

        private void Sales_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
