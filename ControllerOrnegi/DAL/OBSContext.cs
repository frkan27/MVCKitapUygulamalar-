using ControllerOrnegi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ControllerOrnegi.DAL
{
    public class OBSContext:DbContext
    {
        public OBSContext():base("name=OBSCon")
        {

        }
        public DbSet<Fakulte> Fakulteler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }//Tablo isimlerinin coğul olmaması için.fakultes gibi.


    }
}