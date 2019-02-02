using EntityFrameworkKullanimi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkKullanimi.DAL
{
     class MyContextInitializer:CreateDatabaseIfNotExists<MyContext>
        
    {
        protected override void Seed(MyContext conte)
        {
            var kategoriBilgisayar = new Kategori { KategoriAdi = "Bilgisayar" };
            var kategoriCepTel = new Kategori { KategoriAdi = "CepTelefonu" };
            var kategoriTV = new Kategori { KategoriAdi = "Televizyon" };

            conte.Kategoriler.Add(kategoriBilgisayar);
            conte.Kategoriler.Add(kategoriCepTel);
            conte.Kategoriler.Add(kategoriTV);
            conte.SaveChanges();

            List<Urun> urunler = new List<Urun>
            {
                new Urun{UrunAdi="NoteBook",Fiyat=2000,KategoriId=kategoriBilgisayar.Id,Stok=300},
                new Urun{UrunAdi="Tablet",Fiyat=800,KategoriId=kategoriBilgisayar.Id,Stok=450},
                new Urun{UrunAdi="Masaüstü",Fiyat=1500,KategoriId=kategoriBilgisayar.Id,Stok=150},
                new Urun{UrunAdi="UltraBook",Fiyat=3000,KategoriId=kategoriBilgisayar.Id,Stok=85},
                new Urun{UrunAdi="SmartPhone",Fiyat=2000,KategoriId=kategoriCepTel.Id,Stok=1000},
                new Urun{UrunAdi="TabPhone",Fiyat=3000,KategoriId=kategoriCepTel.Id,Stok=50},
                new Urun{UrunAdi="Led TV",Fiyat=3500,KategoriId=kategoriTV.Id,Stok=50},
                 new Urun{UrunAdi="LCD TV",Fiyat=1500,KategoriId=kategoriTV.Id,Stok=30},
                  new Urun{UrunAdi="Plazma TV",Fiyat=2500,KategoriId=kategoriTV.Id,Stok=20},
            };

            urunler.ForEach(urun => conte.Urunler.Add(urun));
            conte.SaveChanges();

        }




    }
}