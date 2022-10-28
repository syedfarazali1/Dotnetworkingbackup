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
    public partial class Form2 : Form
    {
      public  int SupplierIDs = 0;
      public  int CategoryIDs = 0;
      public  int UserIDs = 0;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form2()
        {
            InitializeComponent();
            data();
            GetItem();
            GetSupplier();
        }

        void data()
        {
            Purchasedgridview.ColumnCount = 13;
            Purchasedgridview.Columns[0].Name = "SR NO";
            Purchasedgridview.Columns[1].Name = "Product";
            Purchasedgridview.Columns[2].Name = "Qty";
            Purchasedgridview.Columns[3].Name = "Per-Unit";
            Purchasedgridview.Columns[4].Name = "Total";
            Purchasedgridview.Columns[5].Name = "Selling-Price";
            Purchasedgridview.Columns[6].Name = "Stock-Area";
            Purchasedgridview.Columns[6].Name = "Action";
            Purchasedgridview.Columns[7].Name = "Manufacture";
            Purchasedgridview.Columns[8].Name = "Expiry";
            Purchasedgridview.Columns[9].Name = "Brand";
            Purchasedgridview.Columns[10].Name = "Suplier-Name";
            Purchasedgridview.Columns[11].Name = "Comments";
            Purchasedgridview.Columns[12].Name = "User-Name";

        }
        void GetItem()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM CategoryTable ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string item_name = dr.GetString(1);
                brand.Items.Add(item_name);
            }
            con.Close();

        }
        void GetSupplier()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM SupplierTable";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string item_name = dr.GetString(1);
                supname.Items.Add(item_name);
            }
            con.Close();

        }

        void getsupplierID()
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT SupplierID FROM SupplierTable where SupplierName = @name";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", supname.SelectedItem.ToString());
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                int price = Convert.ToInt32(data.Rows[0]["SupplierID"]);
            }
        }  
        void getconmapanyID()
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT SupplierID FROM SupplierTable where SupplierName = @name";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@name", supname.SelectedItem.ToString());
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count > 0)
            {
                int price = Convert.ToInt32(data.Rows[0]["SupplierID"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      public void selectSupplierIDs()
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(puchaseunit.Text) && !string.IsNullOrEmpty(dec.Text) && !string.IsNullOrEmpty(brand.Text) && !string.IsNullOrEmpty(supname.Text) && !string.IsNullOrEmpty(saleunitprice.Text))
            {
                SqlConnection con2 = new SqlConnection(cs);
                string query3 = "SELECT SupplierID FROM SupplierTable where SupplierName = @SupplierName";
                SqlCommand cmd2 = new SqlCommand(query3, con2);
                cmd2.Parameters.AddWithValue("@SupplierName", supname.SelectedItem.ToString());
                SqlDataAdapter SupplierID = new SqlDataAdapter(cmd2);           
                SupplierIDs = Convert.ToInt32(SupplierID);
            }

        }
        public void selectCategoryIDs()
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(puchaseunit.Text) && !string.IsNullOrEmpty(dec.Text) && !string.IsNullOrEmpty(brand.Text) && !string.IsNullOrEmpty(supname.Text) && !string.IsNullOrEmpty(saleunitprice.Text))
            {
                SqlConnection con3 = new SqlConnection(cs);
                string query4 = "SELECT CategoryID FROM CategoryTable where CategoryName = @CategoryName";
                SqlCommand cmd3 = new SqlCommand(query4, con3);
                cmd3.Parameters.AddWithValue("@CategoryName", brand.SelectedItem.ToString());
                SqlDataAdapter CategoryID = new SqlDataAdapter(cmd3);
                 CategoryIDs = Convert.ToInt32(CategoryID);
            }

        }  
        public void selectUserIDs()
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(puchaseunit.Text) && !string.IsNullOrEmpty(dec.Text) && !string.IsNullOrEmpty(brand.Text) && !string.IsNullOrEmpty(supname.Text) && !string.IsNullOrEmpty(saleunitprice.Text))
            {
                SqlConnection con4 = new SqlConnection(cs);
                string query5 = "SELECT UserID FROM UserTable where UserName = @UserName";
                SqlCommand cmd5 = new SqlCommand(query5, con4);
                cmd5.Parameters.AddWithValue("@UserName", Username.Text);
                SqlDataAdapter UserID = new SqlDataAdapter(cmd5);
                 UserIDs = Convert.ToInt32(UserID);
            }

        }
        //public void selectInvoiceNO()
        //{
        //    if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(puchaseunit.Text) && !string.IsNullOrEmpty(dec.Text) && !string.IsNullOrEmpty(brand.Text) && !string.IsNullOrEmpty(supname.Text) && !string.IsNullOrEmpty(saleunitprice.Text))
        //    {
        //        SqlConnection con4 = new SqlConnection(cs);
        //        string query5 = "SELECT UserID FROM UserTable where UserName = @UserName";
        //        SqlCommand cmd5 = new SqlCommand(query5, con4);
        //        cmd5.Parameters.AddWithValue("@UserName", Username.Text);
        //        SqlDataAdapter UserID = new SqlDataAdapter(cmd5);
        //        var UserIDs = UserID;
        //    }

        //}
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Name.Text) && !string.IsNullOrEmpty(puchaseunit.Text) && !string.IsNullOrEmpty(dec.Text) && !string.IsNullOrEmpty(brand.Text) && !string.IsNullOrEmpty(supname.Text)&& !string.IsNullOrEmpty(saleunitprice.Text))
            {
                //selectSupplierIDs();
                //GetSupplier();
                //selectUserIDs();
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM SupplierTable";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string item_name = dr.GetString(1);
                    supname.Items.Add(item_name);
                }
                con.Close();
            


                SqlConnection con1 = new SqlConnection(cs);
                string query2 = "INSERT INTO PurchaseTable(Product_Name,User_ID,Suplier_ID,Qty,Product_unit_price,Total,CategoryID)VALUES( @Product_Name ,@User_ID,@Suplier_ID,@Qty,@Product_unit_price,@Total,@catID)";
                SqlCommand cmd1 = new SqlCommand(query2, con1);
                cmd1.Parameters.AddWithValue("@Product_Name", Name.Text);
                cmd1.Parameters.AddWithValue("@User_ID", a=DbContext);
                cmd1.Parameters.AddWithValue("@Suplier_ID", SupplierIDs);
                cmd1.Parameters.AddWithValue("@Qty", Qty.Text);
                cmd1.Parameters.AddWithValue("@Product_unit_price", puchaseunit.Text);
                var total = Convert.ToInt32(Qty.Text) * Convert.ToInt32(puchaseunit.Text);
                cmd1.Parameters.AddWithValue("@Total", total);
                cmd1.Parameters.AddWithValue("@catID", CategoryIDs);
                
                
                con.Open();
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not", "Not", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();


            }
            else
            {
                MessageBox.Show("Fill Missing Data", "Fill Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //    (Name as TextBox).Clear();
            //(number as TextBox).Clear();
            //(address as TextBox).Clear();
            //(emailadress as TextBox).Clear();
            //(desc as TextBox).Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

