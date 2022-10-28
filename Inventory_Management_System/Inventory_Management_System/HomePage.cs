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
    public partial class HomePage : Form
    {

        #region design

        private void Registration_MouseClick(object sender, MouseEventArgs e)
        {
            reportmanu.Visible = false;


            SalesManu.Visible = false;
            puchasemanu.Visible = false;
            if (Manu1.Visible == true)
            {
                Manu1.Visible = false;
            }
            else
            {
                Manu1.Visible = true;
            }
        }
        private void puchases_MouseCaptureChanged(object sender, EventArgs e)
        {
            reportmanu.Visible = false;


            SalesManu.Visible = false;
            Manu1.Visible = false;
            if (puchasemanu.Visible == true)
            {
                puchasemanu.Visible = false;
            }
            else
            {
                puchasemanu.Visible = true;
            }

        }



        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            puchasemanu.Visible = false;
            Manu1.Visible = false;
            reportmanu.Visible = false;

            if (SalesManu.Visible == true)
            {
                SalesManu.Visible = false;
            }
            else
            {
                SalesManu.Visible = true;
            }
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            puchasemanu.Visible = false;
            Manu1.Visible = false;


        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            puchasemanu.Visible = false;


        }
        private void product_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesManu.Visible = false;
            reportmanu.Visible = false;
            puchasemanu.Visible = false;


        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            SalesManu.Visible = false;
            Manu1.Visible = false;
            puchasemanu.Visible = false;
            reportmanu.Visible = false;


        }

        private void Reports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SalesManu.Visible = false;
            Manu1.Visible = false;
            puchasemanu.Visible = false;

            if (reportmanu.Visible == true)
            {
                reportmanu.Visible = false;
            }
            else
            {
                reportmanu.Visible = true;
            }
        }

        private void PurchaseReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void purchase_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 a = new Form2();
            a.Show();


        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

      
        #endregion
        public HomePage()
        {
            InitializeComponent();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sale a = new Sale();
            a.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSupplier a = new AddSupplier();
            a.Show();
        }
    }
}
