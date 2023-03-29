using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class ClassProduct
{
    public string idproduct;
    public string nama;
    public string harga;
    public string stock;
    public string idcategory;

    public ClassProduct(string idproduct,string nama,string harga, string stock, string idcategory) { 
        this.idproduct = idproduct;
        this.nama = nama;
        this.harga = harga;
        this.stock = stock;
        this.idcategory = idcategory;

    }
    public ClassProduct(string idcategory,string nama)
    {
        this.idcategory = idcategory;
        this.nama = nama;
    }

}

