using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace TakeHome_W5
{
    public partial class Form1 : Form
    {
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        List<ClassProduct> productlist = new List<ClassProduct>();
        List<ClassCategory> categorylist = new List<ClassCategory>();
        bool select = false;
        bool selectcat = false;
        public Form1()
        {
            InitializeComponent();
            productlist = new List<ClassProduct>
            {
                new ClassProduct("J001", "Jas Hitam", "100000", "10", "C1"),
                new ClassProduct("T001", "T-Shirt Black Pink", "70000", "20", "C2"),
                new ClassProduct("T002", "T - Shirt Obsessive", "75000", "16", "C2"),
                new ClassProduct("R001", "Rok mini", "82000", "26", "C3"),
                new ClassProduct("J002", "Jeans Biru", "90000", "5", "C4"),
                new ClassProduct("C001", "Celana Pendek Coklat", "60000", "11", "C4"),
                new ClassProduct("C002", "Cawat Blink-blink", "1000000", "1", "C5"),
                new ClassProduct("R002", "Rocca Shirt", "50000", "8", "C2")
            };
            categorylist = new List<ClassCategory>
            {
                new ClassCategory("C1", "Jas"),
                new ClassCategory("C2", "T-Shirt"),
                new ClassCategory("C3", "Rok"),
                new ClassCategory("C4", "Celana"),
                new ClassCategory("C5", "Cawat")
            };
        }
        public void UpdateDGVProduct()
        {
            dtProdukSimpan.Clear();
            foreach (ClassProduct a in productlist)
            {
                dtProdukSimpan.Rows.Add(a.idproduct, a.nama, a.harga, a.stock, a.idcategory);
            }
            dgv_product.DataSource = dtProdukSimpan;
        }
        public void UpdateDGVCategory()
        {
            foreach (ClassCategory c in categorylist)
            {
                dtCategory.Rows.Add(c.id, c.nama);
                cmb_filter.Items.Add(c.nama);
                cmb_category.Items.Add(c.nama);
            }
            dgv_category.DataSource = dtCategory;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            UpdateDGVProduct();
            //dgv_product.DataSource = dtProdukSimpan;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            UpdateDGVCategory();
        }
        private void dgv_product_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_product.ClearSelection();
        }
        private void dgv_category_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_category.ClearSelection();
        }
        private void txtBox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btn_filter_Click(object sender, EventArgs e)
        {
            cmb_filter.Enabled = true;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            cmb_filter.Enabled = false;
            cmb_filter.SelectedItem = null;
            dgv_product.DataSource = dtProdukSimpan;
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtProdukTampil.Clear();
            string simpanid = "";
            foreach (ClassCategory a in categorylist)
            {
                if (cmb_filter.Text == a.nama)
                {
                    simpanid = a.id;
                    break;
                }
            }
            foreach (ClassProduct a in productlist)
            {
                if (a.idcategory == simpanid)
                {
                    dtProdukTampil.Rows.Add(a.idproduct, a.nama, a.harga, a.stock, a.idcategory);
                }
            }
            dgv_product.DataSource = dtProdukTampil;


        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_nama.Text) || string.IsNullOrEmpty(cmb_category.Text) || string.IsNullOrEmpty(txtBox_harga.Text) || string.IsNullOrEmpty(txtBox_stock.Text))
            {
                MessageBox.Show("Input yang lengkap ya");
            }
            else
            {
                //Cek id product
                string nama = txtBox_nama.Text;
                nama = nama.ToUpper();
                char a = nama[0];
                string id = "";
                bool ada = false;
                foreach (ClassProduct p in productlist)
                {
                    if (p.idproduct.Contains(a.ToString()))
                    {
                        id = p.idproduct;
                        ada = true;
                    }
                }

                int angkaproduct = 0;
                if (ada == true)
                {
                    string num = id[1].ToString() + id[2].ToString() + id[3].ToString();
                    angkaproduct = Convert.ToInt32(num);
                }
                    angkaproduct++;

                if (angkaproduct <= 9)
                    id = a + "00" + angkaproduct.ToString();
                else if (angkaproduct <= 99)
                    id = a + "0" + angkaproduct.ToString();
                else
                    id = a + angkaproduct.ToString();
                //MessageBox.Show(id);

                // id
                string simpanid = "";
                foreach (ClassCategory cat in categorylist)
                {
                    if (cmb_category.Text == cat.nama)
                    {
                        simpanid = cat.id;
                        break;
                    }
                }
                ClassProduct c = new ClassProduct(id, txtBox_nama.Text, txtBox_harga.Text, txtBox_stock.Text, simpanid);
                productlist.Add(c);
                dtProdukSimpan.Rows.Add(id, txtBox_nama.Text, txtBox_harga.Text, txtBox_stock.Text, simpanid);

                txtBox_nama.Clear();
                cmb_category.SelectedItem = null;
                txtBox_harga.Clear();
                txtBox_stock.Clear();
            }
        }
        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            bool benar = false;
            foreach (ClassCategory a in categorylist)
            {
                if (a.nama == cmb_category.Text)
                    benar = true;
            }

            if (string.IsNullOrEmpty(txtBox_nama.Text) || benar == false || string.IsNullOrEmpty(txtBox_harga.Text) || string.IsNullOrEmpty(txtBox_stock.Text))
            {
                MessageBox.Show("Input yang lengkap ya");
            }
            else if(select==false)
            {
                MessageBox.Show("PILIH DULU BRO");
            }
            else
            {
                

                int a = dgv_product.CurrentCell.RowIndex;
                if (Convert.ToInt32(txtBox_stock.Text) <= 0)
                {
                    //Remove Product from List
                    productlist.RemoveAt(a);
                }
                else
                {
                    string simpan = "";
                    foreach (ClassCategory category in categorylist)
                    {
                        if (category.nama == cmb_category.Text)
                            simpan = category.id;
                    }
                    productlist[a].nama = txtBox_nama.Text;
                    productlist[a].idcategory = simpan;
                    productlist[a].harga = txtBox_harga.Text;
                    productlist[a].stock = txtBox_stock.Text;
                }
                UpdateDGVProduct();

                txtBox_nama.Clear();
                cmb_category.SelectedItem = null;
                txtBox_harga.Clear();
                txtBox_stock.Clear();
                select = false;
            }
        }
        int countcategory = 6;
        private void btn_addcategory_Click(object sender, EventArgs e)
        {

            if (txtBox_namacat.Text == "")
            {
                MessageBox.Show("Input yang lengkap ya");
            }
            else
            {
                bool found = false;
                foreach(ClassCategory c in categorylist)
                {
                    if(c.nama == txtBox_namacat.Text)
                    {
                        found = true;
                        MessageBox.Show("Namanya udh ada");
                        break;
                    }
                }
                if(!found)
                {
                    ClassCategory c = new ClassCategory("C" + countcategory, txtBox_namacat.Text);
                    dtCategory.Rows.Add("C" + countcategory, txtBox_namacat.Text);
                    cmb_filter.Items.Add(txtBox_namacat.Text);
                    cmb_category.Items.Add(txtBox_namacat.Text);
                    countcategory++;
                    txtBox_namacat.Clear();
                }
            }
        }
        private void btn_removecategory_Click(object sender, EventArgs e)
        {
            if (selectcat == false)
                MessageBox.Show("KLIK DULU");
            else
            {


                int a = dgv_category.CurrentCell.RowIndex;
                //MessageBox.Show(a.ToString());
                cmb_category.Items.RemoveAt(a);
                cmb_filter.Items.RemoveAt(a);

                //==========Remove Category from list===========
                string idcat = categorylist[a].id;
                categorylist.RemoveAt(a);
                //MessageBox.Show(idcat);

                //==========Check Product id dari list==========
                int count = -1;

                int i = 0;
                for (i = 0; i < productlist.Count; i++)
                {
                    //MessageBox.Show(productlist[i].idcategory + " loop ke -" + i.ToString() + " " + idcat);
                    if (productlist[i].idcategory == idcat)
                    {
                        //MessageBox.Show("iniii " + productlist[i].idproduct + " " + i.ToString());
                        dtProdukSimpan.Rows.RemoveAt(i);
                        productlist.RemoveAt(i);
                        i = -1;
                    }
                }
                txtBox_namacat.Clear();
                dtCategory.Rows.RemoveAt(dgv_category.CurrentCell.RowIndex);
            }
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgv_product.CurrentCell.RowIndex;


            string idcat = productlist[a].idcategory;
            foreach (ClassCategory c in categorylist)
            {
                if (c.id.Contains(idcat))
                    idcat = c.nama;
            }
            txtBox_nama.Text = productlist[a].nama;
            cmb_category.Text = idcat;
            txtBox_harga.Text = productlist[a].harga;
            txtBox_stock.Text = productlist[a].stock;

            select = true;
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectcat = true;
            int a = dgv_category.CurrentCell.RowIndex;
            txtBox_namacat.Text = categorylist[a].nama;
        }

        private void btn_removeproduct_Click(object sender, EventArgs e)
        {
            int a = dgv_product.CurrentCell.RowIndex;
            productlist.RemoveAt(a);
            if (select == true)
            { UpdateDGVProduct(); select = false; txtBox_nama.Clear();
                cmb_category.SelectedItem = null;
                txtBox_harga.Clear();
                txtBox_stock.Clear();
            }
            else
                MessageBox.Show("KLIK DULU");
        }
    }
}
