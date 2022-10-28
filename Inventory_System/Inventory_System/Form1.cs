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
    public partial class Form1 : Form
    {
        Inventory_Management_systemEntities db = new Inventory_Management_systemEntities();
        public Form1()
        {
            InitializeComponent();
        }

        public void Login_Click(object sender, EventArgs e)
        {

            var result = db.UserTables.Where(x => x.UserName == Usname.Text && x.Password == pass.Text).FirstOrDefault();
            if (result != null)
            {
                string uname = Username.Text;


            }
        }


    }
}


