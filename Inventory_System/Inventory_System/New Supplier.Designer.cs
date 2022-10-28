
namespace Inventory_System
{
    partial class Sup
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
            this.label1 = new System.Windows.Forms.Label();
            this.Suppliername = new System.Windows.Forms.Label();
            this.Supname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dec = new System.Windows.Forms.TextBox();
            this.datatable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.supid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Suppliers";
            // 
            // Suppliername
            // 
            this.Suppliername.AutoSize = true;
            this.Suppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliername.Location = new System.Drawing.Point(12, 76);
            this.Suppliername.Name = "Suppliername";
            this.Suppliername.Size = new System.Drawing.Size(149, 24);
            this.Suppliername.TabIndex = 1;
            this.Suppliername.Text = "Supplier Name";
            // 
            // Supname
            // 
            this.Supname.Location = new System.Drawing.Point(195, 76);
            this.Supname.Name = "Supname";
            this.Supname.Size = new System.Drawing.Size(158, 20);
            this.Supname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contect No";
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(195, 111);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(158, 20);
            this.Contact.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(195, 147);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(158, 20);
            this.Address.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(195, 186);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(158, 20);
            this.email.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(195, 226);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(158, 20);
            this.dec.TabIndex = 2;
            // 
            // datatable
            // 
            this.datatable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Location = new System.Drawing.Point(1, 263);
            this.datatable.Name = "datatable";
            this.datatable.Size = new System.Drawing.Size(799, 197);
            this.datatable.TabIndex = 3;
            this.datatable.DoubleClick += new System.EventHandler(this.datatable_DoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Supplier ID";
            this.label6.Visible = false;
            // 
            // supid
            // 
            this.supid.Location = new System.Drawing.Point(195, 42);
            this.supid.Name = "supid";
            this.supid.Size = new System.Drawing.Size(158, 20);
            this.supid.TabIndex = 2;
            this.supid.Visible = false;
            // 
            // Sup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datatable);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.supid);
            this.Controls.Add(this.Supname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Suppliername);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Sup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Supplies";
            this.Load += new System.EventHandler(this.Suppliesr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Suppliername;
        private System.Windows.Forms.TextBox Supname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dec;
        private System.Windows.Forms.DataGridView datatable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox supid;
    }
}