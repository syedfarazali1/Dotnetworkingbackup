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
    public partial class Sup : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public Sup()
        {
            InitializeComponent();
            load();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SupplierTable sup = new SupplierTable();
            if (supid.Text != "")
            {
                int a = Convert.ToInt32(supid.Text);
                var s = db.SupplierTables.Where(x => x.SupplierID == a).FirstOrDefault();
                
                s.SupplierName = Supname.Text;
                s.Email = email.Text;
                s.ContactNo = Convert.ToInt32(Contact.Text);
                s.Decription = dec.Text;
                s.Address = Address.Text;
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();

            }
            else
            {

                sup.SupplierName = Supname.Text;
                sup.Email = email.Text;
                sup.ContactNo = Convert.ToInt32(Contact.Text);
                sup.Decription = dec.Text;
                sup.Address = Address.Text;
                db.SupplierTables.Add(sup);
                db.SaveChanges();
            }
            MessageBox.Show("Save");
            supid.Text = null;
            Supname.Text = "";
            email.Text = "";
            Contact.Text = "";
            dec.Text = "";
            Address.Text = "";
            load();
        }

        private void load()
        {
            List<SupplierTable> sup = db.SupplierTables.ToList();
            datatable.DataSource = sup;
            datatable.Columns["PurchaseTables"].Visible = false;
            datatable.Columns["SupplierInvoiceTables"].Visible = false;
        }

        private void Suppliesr_Load(object sender, EventArgs e)
        {

        }

        private void datatable_DoubleClick(object sender, EventArgs e)
        {

            if (datatable.CurrentRow != null)
            {
                SupplierTable sup = new SupplierTable();

                var id = 0;
                id = Convert.ToInt32(datatable.CurrentRow.Cells["SupplierID"].Value);
                sup = db.SupplierTables.Where(x => x.SupplierID == id).FirstOrDefault();
                Supname.Text = sup.SupplierName;
                email.Text = sup.Email;
                Contact.Text = sup.ContactNo.ToString();
                dec.Text = sup.Decription;
                Address.Text = sup.Address;
                supid.Text = sup.SupplierID.ToString();
            }

        }
    }
}
