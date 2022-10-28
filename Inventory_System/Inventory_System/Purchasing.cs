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
    public partial class Puchasing : Form
    {


        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public Puchasing()
        {
            InitializeComponent();
            getbrands();
            getSupplier();
            load();
        }


        private void button2_Click(object sender, EventArgs e)
        {
        //    addtocart();
            load();



            if (radioButton1.Checked == true)
            {
                purchaseinsert();
                shop();
                load();
                MessageBox.Show("shop");
            }
            else
            {
                purchaseinsert();
                werehouse();
                load();
                MessageBox.Show("werehouse");
            }

            clear();
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
      

        void shop()
        {
            ShopStockTable a = new ShopStockTable();
            a.Category_ID = Convert.ToInt32(brand.SelectedValue);
            a.CurrentPurchaseUnitPrice = Convert.ToDouble(puchaseunit.Text);
            a.Description = dec.Text;
            a.ExpiryDate = Convert.ToDateTime(expiry.Text);
            a.ManufactureDate = Convert.ToDateTime(manu.Text);
            a.ProductName = PName.Text;
            a.Quantity = Convert.ToInt32(Qty.Text);
            a.SaleunitPrice = Convert.ToInt32(saleunitprice.Text);
            a.User_ID = 1;
            db.ShopStockTables.Add(a);
            db.SaveChanges();
        }
        void werehouse()
        {
            WereHouseStockTable a = new WereHouseStockTable();
            a.Category_ID = Convert.ToInt32(brand.SelectedValue);
            a.CurrentPurchaseUnitPrice = Convert.ToDouble(puchaseunit.Text);
            a.Description = dec.Text;
            a.ExpiryDate = Convert.ToDateTime(expiry.Text);
            a.ManufactureDate = Convert.ToDateTime(manu.Text);
            a.ProductName = PName.Text;
            a.Quantity = Convert.ToInt32(Qty.Text);
            a.SaleunitPrice = Convert.ToInt32(saleunitprice.Text);
            a.User_ID = 1;
            db.WereHouseStockTables.Add(a);
            db.SaveChanges();
        }
        void purchaseinsert()
        {
            PurchaseTable pur = new PurchaseTable();
            pur.Product_Name = PName.Text;
            pur.Product_unit_price = Convert.ToDouble(puchaseunit.Text);
            pur.Qty = Convert.ToInt32(Qty.Text);
            pur.CategoryID = Convert.ToInt32(brand.SelectedValue);
            pur.Suplier_ID = Convert.ToInt32(supname.SelectedValue);
            pur.User_ID = 1;
            pur.Dateofexpiry = Convert.ToDateTime(expiry.Text);
            pur.Dateofmanufacture = Convert.ToDateTime(manu.Text);
            int tt = Convert.ToInt32(Qty.Text) * Convert.ToInt32(puchaseunit.Text);
            pur.Total = Convert.ToDouble(tt);
            db.PurchaseTables.Add(pur);
            db.SaveChanges();




        }


        void addtocart()
        {
           
            Addtocart pur = new Addtocart();
            List<Addtocart> li = new List<Addtocart>();
            pur.Product_Name = PName.Text;
            pur.Product_unit_price = Convert.ToDouble(puchaseunit.Text);
            pur.Qty = Convert.ToInt32(Qty.Text);
            pur.CategoryID = Convert.ToInt32(brand.SelectedValue);
            pur.Suplier_ID = Convert.ToInt32(supname.SelectedValue);
            pur.Dateofexpiry = Convert.ToDateTime(expiry.Text);
            pur.Dateofmanufacture = Convert.ToDateTime(manu.Text);
            int tt = Convert.ToInt32(Qty.Text) * Convert.ToInt32(puchaseunit.Text);
            pur.total = Convert.ToDouble(tt);
            li.Add(pur);
            Purchasetable.DataSource = li;

        }
        void clear()
        {
            PName.Text = null;
            puchaseunit.Text = null;
            Qty.Text = null;
            manu.Text = null;
            puchaseunit.Text = null;
            saleunitprice.Text = null;
            dec.Text = null;

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PName.Text = null;
            puchaseunit.Text = null;
            Qty.Text = null;
            brand.Text = null;
            supname.Text = null;
            expiry.Text = null;
            manu.Text = null;
            puchaseunit.Text = null;
            saleunitprice.Text = null;
            dec.Text = null;



        }

        private void AddBrand_Click(object sender, EventArgs e)
        {
            Brand a = new Brand();
            a.ShowDialog();
            a.Refresh();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Sup a = new Sup();
            a.ShowDialog();
            a.Refresh();
        }
        private void load()
        {
            var a = db.PurchaseTables.ToList();
            Purchasetable.DataSource = a;
            Purchasetable.Columns["CategoryTable"].Visible = false;
            Purchasetable.Columns["SupplierTable"].Visible = false;
            Purchasetable.Columns["UserTable"].Visible = false;
            Purchasetable.Columns["SupplierInvoiceTables"].Visible = false;


        }



        private void purchasing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            customer a = new customer();
            a.ShowDialog();
            a.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory_repot a = new Inventory_repot();
            a.ShowDialog();

        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void supname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}