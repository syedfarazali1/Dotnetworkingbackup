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
    public partial class Form2 : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();

        private DateTimePicker dateTimePicker;

        public Form2()
        {
            InitializeComponent();
            getbrands();
            getSupplier();
            load();
            getinvoice();

        }


        #region Dropdown
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
        #endregion

        #region deletebutton
        public void load()
        {
            DataGridViewButtonColumn abtn = new DataGridViewButtonColumn();
            abtn.HeaderText = "Delete";
            abtn.Text = "Delete";
            abtn.Name = "dbtn";
            abtn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(abtn);


        }

        #endregion

        #region InsertButton
        private void Insert_Click(object sender, EventArgs e)
        {
            Insert.Enabled = false;
            supname.Enabled = true;
            brand.Enabled = true;
            stshop.Enabled = true;
            wereshouse.Enabled = true;
            purchase();

        }
        #endregion

        #region purchase
        void purchase()
        {

            string product = ""; int qty = 0; int PUP = 0; int Total = 0; int flag = 0; DateTime exp; DateTime manu;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value == null || dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null || supname.SelectedValue == null || brand.SelectedValue == null || Narrations.Text == null || dataGridView1.Rows[i].Cells[4].Value == null || dataGridView1.Rows[i].Cells[5].Value == null)
                {
                    MessageBox.Show("Please check info");
                    flag = 1;
                }

            }
            if (flag == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {


                    product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    PUP = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    exp = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                    manu = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value);
                    Total = qty * PUP;
                    dataGridView1.Rows[i].Cells[3].Value = Total;
                    PurchaseTable ass = new PurchaseTable();
                    ass.Product_Name = product;
                    ass.Product_unit_price = PUP;
                    ass.Qty = qty;
                    ass.Total = Total;
                    ass.Suplier_ID = Convert.ToInt32(supname.SelectedValue);
                    ass.CategoryID = Convert.ToInt32(brand.SelectedValue);
                    ass.Dateofexpiry = exp;
                    ass.Dateofmanufacture = manu;
                    ass.User_ID = 1;

                    db.PurchaseTables.Add(ass);
                    db.SaveChanges();

                }
                MessageBox.Show("success");
                InvoiceRecord();

            }

        }
        #endregion

        #region InvoiceRecord
        void InvoiceRecord()
        {


            string product = ""; int qty = 0; int PUP = 0; int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null || dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null || supname.SelectedValue == null || brand.SelectedValue == null || Narrations.Text == null)
                {

                    MessageBox.Show("Please Fill full info");

                }
                else
                {
                    product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    PUP = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                    Total = qty * PUP;
                    dataGridView1.Rows[i].Cells[3].Value = Total;
                    SupplierInvoiceTable ass = new SupplierInvoiceTable();
                    ass.Description = Narrations.Text;
                    ass.InvoiceDate = DateTime.Now;
                    ass.Invoice_No = db.PurchaseTables.Max(x => x.Sup_Invoice_ID);
                    ass.Supplier_ID = Convert.ToInt32(supname.SelectedValue);
                    ass.TotalAmount = Convert.ToInt32(label2.Text);
                    ass.User_ID = 1;
                    ass.Tittle = "check krna he";
                    db.SupplierInvoiceTables.Add(ass);
                    db.SaveChanges();
                    MessageBox.Show("Invoice INSEERTED");
                    Invoicedetails();
                 

                }

            }
        }
        #endregion

        #region Invoicedetails
        void Invoicedetails()
        {

            string product = ""; int qty = 0; int PUP = 0; int Total = 0; int flag = 0; DateTime exp; DateTime manu;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value == null || dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null || supname.SelectedValue == null || brand.SelectedValue == null || Narrations.Text == null || dataGridView1.Rows[i].Cells[4].Value == null || dataGridView1.Rows[i].Cells[5].Value == null)
                {
                    MessageBox.Show("Please check info");
                    flag = 1;
                }

            }
            if (flag == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {


                    product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    PurchaseTable purchaseTable = db.PurchaseTables.Where(x => x.Product_Name == product).FirstOrDefault();
                    PUP = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    exp = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                    manu = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value);
                    Total = qty * PUP;
                    dataGridView1.Rows[i].Cells[3].Value = Total;
                    SupplierInvoiceDetailsTable ass = new SupplierInvoiceDetailsTable();
                    ass.Product_ID = purchaseTable.Sup_Invoice_ID;
                    ass.SupplierInvoice_ID = db.SupplierInvoiceTables.Max(x => x.SupplierInvoiceID);
                    ass.PuchaseQty = qty;
                    ass.PuchaseUnitPrice = PUP;
                    db.SupplierInvoiceDetailsTables.Add(ass);
                    db.SaveChanges();

                }
                MessageBox.Show("Invoicedetails");
                if (stshop.Checked == true)
                {
                    Shop();

                }
                else
                {
                    werehouse();

                }
                clear();
            }

        }
        #endregion

        #region addrow
        private void Addrow_Click(object sender, EventArgs e)
        {
            Insert.Enabled = true;
            dataGridView1.Rows.Add(1);
            dataGridView1.Enabled = true;
            supname.Enabled = false;
            brand.Enabled = false;
            stshop.Enabled = false;
            wereshouse.Enabled = false;
            label2.Text = "";
            totalqtys.Text = "";


        }

        #endregion

        #region DeleteRow
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("Are you show you want to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int row = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(row);
                }

                if (dataGridView1.Rows.Count > 0)
                {
                    Insert.Enabled = true;
                }

                else
                {
                    Insert.Enabled = false;
                }
            }

            if (e.ColumnIndex == 4)
            {
                dateTimePicker = new DateTimePicker();
                dataGridView1.Controls.Add(dateTimePicker);
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                Rectangle rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                dateTimePicker.CloseUp += new EventHandler(datetimepicker_closeup);
                dateTimePicker.TextChanged += new EventHandler(datetimepicker_textchanged);
                dateTimePicker.Visible = true;
            }
            if (e.ColumnIndex == 5)
            {
                dateTimePicker = new DateTimePicker();
                dataGridView1.Controls.Add(dateTimePicker);
                dateTimePicker.Format = DateTimePickerFormat.Custom;
                Rectangle rectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                dateTimePicker.CloseUp += new EventHandler(datetimepicker_closeup);
                dateTimePicker.TextChanged += new EventHandler(datetimepicker_textchanged);
                dateTimePicker.Visible = true;
            }
        }

        private void datetimepicker_textchanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = dateTimePicker.Text.ToString();

        }
        private void datetimepicker_closeup(object sender, EventArgs e)
        {
            dateTimePicker.Visible = false;

        }
        #endregion

        #region ClearGridview
        void clear()
        {
            supname.Text = null;
            brand.Text = null;
            Narrations.Text = null;

            dataGridView1.Rows.Clear();

        }

        #endregion

        #region Invoiceno
        void getinvoice()
        {

            int inv = db.SupplierInvoiceTables.Max(x => x.SupplierInvoiceID);
            int k = inv + 1;
            string a = "Invoice # " + k.ToString();
            Invoice.Text = a;
        }

        #endregion

        #region total/subtotal
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            int qty = 0; int PUP = 0; int Total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                PUP = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                Total = qty * PUP;
                dataGridView1.Rows[i].Cells[3].Value = Total;
            }
            // Sub Total
            label2.Text = (from DataGridViewRow row in dataGridView1.Rows
                           where row.Cells[4].FormattedValue.ToString() != string.Empty
                           select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();

            // Total Quantity
            totalqtys.Text = (from DataGridViewRow row in dataGridView1.Rows
                              where row.Cells[2].FormattedValue.ToString() != string.Empty
                              select Convert.ToInt32(row.Cells[2].FormattedValue)).Sum().ToString();


        }




        #endregion

        #region Shop
        void Shop()
        {

            string product = ""; int qty = 0; int PUP = 0; int Total = 0; int flag = 0; DateTime exp; DateTime manu;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value == null || dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null || supname.SelectedValue == null || brand.SelectedValue == null || Narrations.Text == null || dataGridView1.Rows[i].Cells[4].Value == null || dataGridView1.Rows[i].Cells[5].Value == null)
                {
                    MessageBox.Show("Please check info");
                    flag = 1;
                }

            }
            if (flag == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {


                    product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    PUP = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    exp = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                    manu = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value);
                    Total = qty * PUP;
                    dataGridView1.Rows[i].Cells[3].Value = Total;
                    ShopStockTable ass = new ShopStockTable();
                    ass.ProductName = product;
                    ass.Quantity = qty;
                    ass.SaleunitPrice = 0;
                    ass.ManufactureDate = manu;
                    ass.ExpiryDate = exp;
                    ass.Description = Narrations.Text;
                    ass.CurrentPurchaseUnitPrice = PUP;
                    ass.Category_ID = Convert.ToInt32(brand.SelectedValue);
                    ass.User_ID = 1;
                    db.ShopStockTables.Add(ass);
                    db.SaveChanges();

                }
                MessageBox.Show("ShopStockTables");

            }

        }
        #endregion

        #region werehouse
        void werehouse()
        {

            string product = ""; int qty = 0; int PUP = 0; int Total = 0; int flag = 0; DateTime exp; DateTime manu;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (dataGridView1.Rows[i].Cells[0].Value == null || dataGridView1.Rows[i].Cells[1].Value == null || dataGridView1.Rows[i].Cells[2].Value == null || supname.SelectedValue == null || brand.SelectedValue == null || Narrations.Text == null || dataGridView1.Rows[i].Cells[4].Value == null || dataGridView1.Rows[i].Cells[5].Value == null)
                {
                    MessageBox.Show("Please check info");
                    flag = 1;
                }

            }
            if (flag == 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {


                    product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    PUP = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                    qty = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    exp = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                    manu = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value);
                    Total = qty * PUP;
                    dataGridView1.Rows[i].Cells[3].Value = Total;
                    WereHouseStockTable ass = new WereHouseStockTable();
                    ass.ProductName = product;
                    ass.Quantity = qty;
                    ass.SaleunitPrice = 0;
                    ass.ManufactureDate = manu;
                    ass.ExpiryDate = exp;
                    ass.Description = Narrations.Text;
                    ass.CurrentPurchaseUnitPrice = PUP;
                    ass.Category_ID = Convert.ToInt32(brand.SelectedValue);
                    ass.User_ID = 1;
                    db.WereHouseStockTables.Add(ass);
                    db.SaveChanges();

                }
                MessageBox.Show("WereHouseStockTables");

            }

        }
        #endregion

    
     
    }






}

