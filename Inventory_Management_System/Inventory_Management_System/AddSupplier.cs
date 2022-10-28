using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class AddSupplier : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AddSupplier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(number.Text) && !string.IsNullOrEmpty(address.Text) && !string.IsNullOrEmpty(emailadress.Text) && !string.IsNullOrEmpty(desc.Text))
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "INSERT INTO SupplierTable([SupplierName],[ContactNo],[Address],[Email],[Decription]) VALUES (@SupplierName,@ContactNo,@Address,@Email,@Decription)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SupplierName", Name.Text);
                cmd.Parameters.AddWithValue("@ContactNo", number.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.Parameters.AddWithValue("@Email", emailadress.Text);
                cmd.Parameters.AddWithValue("@Decription", desc.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();


            }
            else
            {
                MessageBox.Show("Fill Missing Data", "Fill Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                (Name as TextBox).Clear();
                (number as TextBox).Clear();
                (address as TextBox).Clear();
                (emailadress as TextBox).Clear();
                (desc as TextBox).Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled =true;
            }
        }
    }
}
