using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1.ModelTanımlama.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string BolumAdi { get; set; }
        public DateTime GirisYili { get; set; }
        public int TC { get; set; }
    }
}