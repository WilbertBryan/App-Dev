namespace TakeHome_W5
{
    partial class Form1
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
            this.btn_all = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_nama = new System.Windows.Forms.TextBox();
            this.txtBox_harga = new System.Windows.Forms.TextBox();
            this.txtBox_stock = new System.Windows.Forms.TextBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.btn_editproduct = new System.Windows.Forms.Button();
            this.btn_removeproduct = new System.Windows.Forms.Button();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_namacat = new System.Windows.Forms.TextBox();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_removecategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(297, 56);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(110, 46);
            this.btn_all.TabIndex = 1;
            this.btn_all.Text = "all";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToOrderColumns = true;
            this.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(48, 122);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.RowHeadersWidth = 92;
            this.dgv_product.RowTemplate.Height = 37;
            this.dgv_product.Size = new System.Drawing.Size(906, 564);
            this.dgv_product.TabIndex = 2;
            this.dgv_product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_product_CellClick);
            this.dgv_product.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_product_DataBindingComplete);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(420, 56);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(110, 47);
            this.btn_filter.TabIndex = 3;
            this.btn_filter.Text = "filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cmb_filter
            // 
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.Enabled = false;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Location = new System.Drawing.Point(536, 62);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(418, 37);
            this.cmb_filter.TabIndex = 4;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 63);
            this.label2.TabIndex = 5;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 805);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 850);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 891);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 937);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stock:";
            // 
            // txtBox_nama
            // 
            this.txtBox_nama.Location = new System.Drawing.Point(148, 805);
            this.txtBox_nama.Name = "txtBox_nama";
            this.txtBox_nama.Size = new System.Drawing.Size(806, 35);
            this.txtBox_nama.TabIndex = 10;
            // 
            // txtBox_harga
            // 
            this.txtBox_harga.Location = new System.Drawing.Point(148, 891);
            this.txtBox_harga.Name = "txtBox_harga";
            this.txtBox_harga.Size = new System.Drawing.Size(456, 35);
            this.txtBox_harga.TabIndex = 11;
            this.txtBox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_harga_KeyPress);
            // 
            // txtBox_stock
            // 
            this.txtBox_stock.Location = new System.Drawing.Point(148, 937);
            this.txtBox_stock.Name = "txtBox_stock";
            this.txtBox_stock.Size = new System.Drawing.Size(456, 35);
            this.txtBox_stock.TabIndex = 12;
            this.txtBox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_stock_KeyPress);
            // 
            // cmb_category
            // 
            this.cmb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(148, 848);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(456, 37);
            this.cmb_category.TabIndex = 13;
            // 
            // btn_editproduct
            // 
            this.btn_editproduct.Location = new System.Drawing.Point(746, 850);
            this.btn_editproduct.Name = "btn_editproduct";
            this.btn_editproduct.Size = new System.Drawing.Size(130, 122);
            this.btn_editproduct.TabIndex = 15;
            this.btn_editproduct.Text = "Edit Product";
            this.btn_editproduct.UseVisualStyleBackColor = true;
            this.btn_editproduct.Click += new System.EventHandler(this.btn_editproduct_Click);
            // 
            // btn_removeproduct
            // 
            this.btn_removeproduct.Location = new System.Drawing.Point(882, 848);
            this.btn_removeproduct.Name = "btn_removeproduct";
            this.btn_removeproduct.Size = new System.Drawing.Size(130, 122);
            this.btn_removeproduct.TabIndex = 16;
            this.btn_removeproduct.Text = "Remove Product";
            this.btn_removeproduct.UseVisualStyleBackColor = true;
            this.btn_removeproduct.Click += new System.EventHandler(this.btn_removeproduct_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(610, 850);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(130, 122);
            this.btn_addproduct.TabIndex = 17;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1075, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 63);
            this.label7.TabIndex = 18;
            this.label7.Text = "Category";
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_category.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(1073, 122);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 92;
            this.dgv_category.RowTemplate.Height = 37;
            this.dgv_category.Size = new System.Drawing.Size(594, 407);
            this.dgv_category.TabIndex = 19;
            this.dgv_category.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellClick);
            this.dgv_category.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_category_DataBindingComplete);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1068, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nama:";
            // 
            // txtBox_namacat
            // 
            this.txtBox_namacat.Location = new System.Drawing.Point(1157, 563);
            this.txtBox_namacat.Name = "txtBox_namacat";
            this.txtBox_namacat.Size = new System.Drawing.Size(510, 35);
            this.txtBox_namacat.TabIndex = 21;
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Location = new System.Drawing.Point(1245, 629);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(149, 122);
            this.btn_addcategory.TabIndex = 22;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_removecategory
            // 
            this.btn_removecategory.Location = new System.Drawing.Point(1412, 629);
            this.btn_removecategory.Name = "btn_removecategory";
            this.btn_removecategory.Size = new System.Drawing.Size(149, 122);
            this.btn_removecategory.TabIndex = 23;
            this.btn_removecategory.Text = "Remove Category";
            this.btn_removecategory.UseVisualStyleBackColor = true;
            this.btn_removecategory.Click += new System.EventHandler(this.btn_removecategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1891, 1104);
            this.Controls.Add(this.btn_removecategory);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.txtBox_namacat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.btn_removeproduct);
            this.Controls.Add(this.btn_editproduct);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.txtBox_stock);
            this.Controls.Add(this.txtBox_harga);
            this.Controls.Add(this.txtBox_nama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_nama;
        private System.Windows.Forms.TextBox txtBox_harga;
        private System.Windows.Forms.TextBox txtBox_stock;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.Button btn_editproduct;
        private System.Windows.Forms.Button btn_removeproduct;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_namacat;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_removecategory;
    }
}

