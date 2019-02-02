using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkKullanimi.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }


        public virtual Kategori Kategori { get; set; }
    }
}