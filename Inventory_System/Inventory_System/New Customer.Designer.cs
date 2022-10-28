
namespace Inventory_System
{
    partial class customer
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
            this.datatable = new System.Windows.Forms.DataGridView();
            this.dec = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Suppliername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CusID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.SuspendLayout();
            // 
            // datatable
            // 
            this.datatable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Location = new System.Drawing.Point(1, 215);
            this.datatable.Name = "datatable";
            this.datatable.Size = new System.Drawing.Size(799, 235);
            this.datatable.TabIndex = 10;
            this.datatable.DoubleClick += new System.EventHandler(this.datatable_DoubleClick);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(195, 183);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(158, 20);
            this.dec.TabIndex = 5;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(195, 76);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(158, 20);
            this.add.TabIndex = 7;
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(195, 112);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(158, 20);
            this.contact.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(195, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 20);
            this.name.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contect No";
            // 
            // Suppliername
            // 
            this.Suppliername.AutoSize = true;
            this.Suppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliername.Location = new System.Drawing.Point(29, 36);
            this.Suppliername.Name = "Suppliername";
            this.Suppliername.Size = new System.Drawing.Size(160, 24);
            this.Suppliername.TabIndex = 15;
            this.Suppliername.Text = "Customer Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CusID
            // 
            this.CusID.Location = new System.Drawing.Point(583, 42);
            this.CusID.Name = "CusID";
            this.CusID.Size = new System.Drawing.Size(158, 20);
            this.CusID.TabIndex = 9;
            this.CusID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer ID";
            this.label6.Visible = false;
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(195, 149);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(158, 20);
            this.Area.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Area";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Suppliername);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.datatable);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.add);
            this.Controls.Add(this.CusID);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datatable;
        private System.Windows.Forms.TextBox dec;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Suppliername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CusID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.Label label7;
    }
}