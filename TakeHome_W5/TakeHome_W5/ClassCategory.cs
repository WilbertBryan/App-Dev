using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class ClassCategory
{
    public string id;
    public string nama;
    public ClassProduct product;
    public ClassCategory(string id, string nama)
    {
        this.id = id;
        this.nama = nama;
    }
}

