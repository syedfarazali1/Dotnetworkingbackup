
namespace Inventory_System
{
    partial class Brand
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
            this.button1 = new System.Windows.Forms.Button();
            this.datatable = new System.Windows.Forms.DataGridView();
            this.catid = new System.Windows.Forms.TextBox();
            this.catname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Suppliername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 70);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datatable
            // 
            this.datatable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable.Location = new System.Drawing.Point(1, 254);
            this.datatable.Name = "datatable";
            this.datatable.Size = new System.Drawing.Size(799, 197);
            this.datatable.TabIndex = 10;
            // 
            // catid
            // 
            this.catid.Location = new System.Drawing.Point(195, 33);
            this.catid.Name = "catid";
            this.catid.Size = new System.Drawing.Size(158, 20);
            this.catid.TabIndex = 8;
            this.catid.Visible = false;
            // 
            // catname
            // 
            this.catname.Location = new System.Drawing.Point(195, 67);
            this.catname.Name = "catname";
            this.catname.Size = new System.Drawing.Size(158, 20);
            this.catname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Brand ID";
            this.label6.Visible = false;
            // 
            // Suppliername
            // 
            this.Suppliername.AutoSize = true;
            this.Suppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suppliername.Location = new System.Drawing.Point(12, 67);
            this.Suppliername.Name = "Suppliername";
            this.Suppliername.Size = new System.Drawing.Size(126, 24);
            this.Suppliername.TabIndex = 7;
            this.Suppliername.Text = "Brand Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Brand";
            // 
            // Brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datatable);
            this.Controls.Add(this.catid);
            this.Controls.Add(this.catname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Suppliername);
            this.Controls.Add(this.label1);
            this.Name = "Brand";
            this.Text = "New Brand";
            ((System.ComponentModel.ISupportInitialize)(this.datatable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datatable;
        private System.Windows.Forms.TextBox catid;
        private System.Windows.Forms.TextBox catname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Suppliername;
        private System.Windows.Forms.Label label1;
    }
}