
namespace Inventory_System
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.AddSupplier = new System.Windows.Forms.Button();
            this.supname = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.AddBrand = new System.Windows.Forms.Button();
            this.brand = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exp_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Man_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addrow = new System.Windows.Forms.Button();
            this.Invoice = new System.Windows.Forms.Label();
            this.HSub_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalqty = new System.Windows.Forms.Label();
            this.totalqtys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Narrations = new System.Windows.Forms.TextBox();
            this.stshop = new System.Windows.Forms.RadioButton();
            this.wereshouse = new System.Windows.Forms.RadioButton();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.AddSupplier);
            this.panel5.Controls.Add(this.supname);
            this.panel5.Location = new System.Drawing.Point(1, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 60);
            this.panel5.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Supplies Name";
            // 
            // AddSupplier
            // 
            this.AddSupplier.BackColor = System.Drawing.Color.Lime;
            this.AddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplier.Location = new System.Drawing.Point(178, 14);
            this.AddSupplier.Name = "AddSupplier";
            this.AddSupplier.Size = new System.Drawing.Size(29, 38);
            this.AddSupplier.TabIndex = 1;
            this.AddSupplier.Text = "+";
            this.AddSupplier.UseVisualStyleBackColor = false;
            // 
            // supname
            // 
            this.supname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supname.FormattingEnabled = true;
            this.supname.Location = new System.Drawing.Point(0, 23);
            this.supname.Name = "supname";
            this.supname.Size = new System.Drawing.Size(176, 24);
            this.supname.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.AddBrand);
            this.panel8.Controls.Add(this.brand);
            this.panel8.Location = new System.Drawing.Point(278, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 65);
            this.panel8.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Category";
            // 
            // AddBrand
            // 
            this.AddBrand.BackColor = System.Drawing.Color.Lime;
            this.AddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBrand.Location = new System.Drawing.Point(168, 16);
            this.AddBrand.Name = "AddBrand";
            this.AddBrand.Size = new System.Drawing.Size(29, 38);
            this.AddBrand.TabIndex = 1;
            this.AddBrand.Text = "+";
            this.AddBrand.UseVisualStyleBackColor = false;
            // 
            // brand
            // 
            this.brand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand.FormattingEnabled = true;
            this.brand.Location = new System.Drawing.Point(4, 27);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(158, 24);
            this.brand.TabIndex = 7;
            // 
            // Insert
            // 
            this.Insert.Enabled = false;
            this.Insert.Location = new System.Drawing.Point(248, 104);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(205, 50);
            this.Insert.TabIndex = 80;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.PUP,
            this.Quantity,
            this.Total,
            this.Exp_Date,
            this.Man_date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1164, 246);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
           
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // PUP
            // 
            this.PUP.HeaderText = "Purchase-Unit-Price";
            this.PUP.Name = "PUP";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Exp_Date
            // 
            this.Exp_Date.HeaderText = "Expiry";
            this.Exp_Date.Name = "Exp_Date";
            this.Exp_Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Man_date
            // 
            this.Man_date.HeaderText = "Manufacture";
            this.Man_date.Name = "Man_date";
            // 
            // Addrow
            // 
            this.Addrow.Location = new System.Drawing.Point(504, 104);
            this.Addrow.Name = "Addrow";
            this.Addrow.Size = new System.Drawing.Size(205, 50);
            this.Addrow.TabIndex = 82;
            this.Addrow.Text = "Add-Row";
            this.Addrow.UseVisualStyleBackColor = true;
            this.Addrow.Click += new System.EventHandler(this.Addrow_Click);
            // 
            // Invoice
            // 
            this.Invoice.AutoSize = true;
            this.Invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice.Location = new System.Drawing.Point(954, 18);
            this.Invoice.Name = "Invoice";
            this.Invoice.Size = new System.Drawing.Size(0, 24);
            this.Invoice.TabIndex = 83;
            // 
            // HSub_Total
            // 
            this.HSub_Total.AutoSize = true;
            this.HSub_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSub_Total.Location = new System.Drawing.Point(840, 169);
            this.HSub_Total.Name = "HSub_Total";
            this.HSub_Total.Size = new System.Drawing.Size(99, 24);
            this.HSub_Total.TabIndex = 84;
            this.HSub_Total.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(947, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 85;
            // 
            // totalqty
            // 
            this.totalqty.AutoSize = true;
            this.totalqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalqty.Location = new System.Drawing.Point(500, 169);
            this.totalqty.Name = "totalqty";
            this.totalqty.Size = new System.Drawing.Size(138, 24);
            this.totalqty.TabIndex = 84;
            this.totalqty.Text = "Total Quantity";
            // 
            // totalqtys
            // 
            this.totalqtys.AutoSize = true;
            this.totalqtys.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.totalqtys.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalqtys.Location = new System.Drawing.Point(688, 169);
            this.totalqtys.Name = "totalqtys";
            this.totalqtys.Size = new System.Drawing.Size(0, 24);
            this.totalqtys.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Narrations";
            // 
            // Narrations
            // 
            this.Narrations.Location = new System.Drawing.Point(603, 18);
            this.Narrations.Name = "Narrations";
            this.Narrations.Size = new System.Drawing.Size(151, 20);
            this.Narrations.TabIndex = 87;
            // 
            // stshop
            // 
            this.stshop.AutoSize = true;
            this.stshop.Checked = true;
            this.stshop.Location = new System.Drawing.Point(603, 62);
            this.stshop.Name = "stshop";
            this.stshop.Size = new System.Drawing.Size(50, 17);
            this.stshop.TabIndex = 88;
            this.stshop.TabStop = true;
            this.stshop.Text = "Shop";
            this.stshop.UseVisualStyleBackColor = true;
            // 
            // wereshouse
            // 
            this.wereshouse.AutoSize = true;
            this.wereshouse.Location = new System.Drawing.Point(694, 62);
            this.wereshouse.Name = "wereshouse";
            this.wereshouse.Size = new System.Drawing.Size(80, 17);
            this.wereshouse.TabIndex = 88;
            this.wereshouse.Text = "Werehouse";
            this.wereshouse.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.wereshouse);
            this.Controls.Add(this.stshop);
            this.Controls.Add(this.Narrations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalqtys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalqty);
            this.Controls.Add(this.HSub_Total);
            this.Controls.Add(this.Invoice);
            this.Controls.Add(this.Addrow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddSupplier;
        private System.Windows.Forms.ComboBox supname;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddBrand;
        private System.Windows.Forms.ComboBox brand;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addrow;
        private System.Windows.Forms.Label Invoice;
        private System.Windows.Forms.Label HSub_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalqty;
        private System.Windows.Forms.Label totalqtys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Narrations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exp_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Man_date;
        private System.Windows.Forms.RadioButton stshop;
        private System.Windows.Forms.RadioButton wereshouse;
    }
}