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
    public partial class customer : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public customer()
        {
            InitializeComponent();
            load();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerTable cus = new CustomerTable();
                if (CusID.Text != "")
            {
                int a = Convert.ToInt32(CusID.Text);
                var c = db.CustomerTables.Where(x => x.Customer_ID == a).FirstOrDefault();
                c.Cus_Name = name.Text;
                c.Cus_Address = add.Text;
                c.Cus_Contact = Convert.ToInt32(contact.Text);
                c.Decription = dec.Text;
                c.Area = Area.Text;
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();

            }
            else
            {

                cus.Cus_Name = name.Text;
                cus.Cus_Address = add.Text;
                cus.Decription = dec.Text;
                cus.Cus_Contact = Convert.ToInt32(contact.Text);
                cus.Area = Area.Text;
                db.CustomerTables.Add(cus);
                db.SaveChanges();
            }
            MessageBox.Show("Save");
            CusID.Text = null;
            name.Text = "";
            add.Text = "";
            dec.Text = "";
            contact.Text = "";
            Area.Text = "";
            load();
        }


        private void load()
        {
            var cus = db.CustomerTables.ToList();
            datatable.DataSource = cus;
          
        }

        private void datatable_DoubleClick(object sender, EventArgs e)
        {
            CustomerTable cus = new CustomerTable();

            var id = 0;
            id = Convert.ToInt32(datatable.CurrentRow.Cells["Customer_ID"].Value);
            cus = db.CustomerTables.Where(x => x.Customer_ID == id).FirstOrDefault();
            CusID.Text = Convert.ToString(cus.Customer_ID);
            name.Text = cus.Cus_Name ;
            add.Text = cus.Cus_Address;
            dec.Text = cus.Decription;
            contact.Text = Convert.ToString(cus.Cus_Contact);
            Area.Text = cus.Area;
        }
    }
}
