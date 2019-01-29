using _1.ModelTanımlama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1.ModelTanımlama.Veri
{
    public class OgrenciVeri
    {
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>
        {
        new Ogrenci
            {
            Id=1,
            Ad="Furkan",
            Soyad="Kılıc",
            BolumAdi="Mekatronik",
            TC=2213293,
            GirisYili=DateTime.Now
            },
        new Ogrenci
        {
             Id=2,
            Ad="Kürsad",
            Soyad="Bayir",
            BolumAdi="Endüstri",
            TC=2254293,
            GirisYili=DateTime.Now
        }



        };
    }
}