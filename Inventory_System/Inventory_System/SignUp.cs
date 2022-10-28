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
    public partial class SignUp : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public SignUp()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (FName.Text != "" && email.Text != "" && contact.Text != "" && password.Text != "" && usname.Text != "")
            {
                UserTable a = new UserTable();
                a.FullName = name.Text;
                a.Email = email.Text;
                a.ContactNo = contact.Text;
                a.Password = password.Text;
                a.UserName = usname.Text;
                db.UserTables.Add(a);
                db.SaveChanges();
                MessageBox.Show("Registered");
                name.Text = "";
                email.Text = "";
                contact.Text = "";
                password.Text = "";
                usname.Text = "";
            }
            else
            {
                MessageBox.Show("Please Fill ");

            }
        }
    }
}
