using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkKullanimi.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }


        public virtual ICollection<Urun> Urunler { get; set; }
    }
}