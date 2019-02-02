using EntityFrameworkKullanimi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkKullanimi.DAL
{
    public class MyContext:DbContext
    {

        public MyContext():base("MyCon")
        {

        }

        public DbSet<Kategori>  Kategoriler { get; set; }

        public DbSet<Urun> Urunler { get; set; }

    
    }
}