using DepartPersonel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DepartPersonel
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MyCon")
        {

        }

        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
}