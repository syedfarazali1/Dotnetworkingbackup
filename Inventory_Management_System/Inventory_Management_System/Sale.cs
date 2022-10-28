using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            data();
        }

        void data()
        {
            Salegridview.ColumnCount = 10;
            Salegridview.Columns[0].Name = "SR NO";
            Salegridview.Columns[1].Name = "Product";
            Salegridview.Columns[2].Name = "Qty";
            Salegridview.Columns[3].Name = "Per-Unit";
            Salegridview.Columns[4].Name = "Customer-Name";
            Salegridview.Columns[5].Name = "Stock-Area";
            Salegridview.Columns[6].Name = "Action";
            Salegridview.Columns[7].Name = "Brand";
            Salegridview.Columns[8].Name = "Comments";
            Salegridview.Columns[9].Name = "User-Name";

        }
    }
}
