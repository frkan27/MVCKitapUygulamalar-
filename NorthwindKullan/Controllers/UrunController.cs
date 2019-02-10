using NorthwindKullan.Models.EntityModel;
using NorthwindKullan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindKullan.Controllers
{
    public class UrunController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Urun
        public ActionResult Index()
        {
            var model = db.Products.ToList();
            return View(model);
        }

        public ActionResult Ekle()
        {
            var model = new UrunViewModel()
            {
                Categories=db.Categories.OrderBy(x=>x.CategoryName).ToList()
            };

            return View("UrunForm",model);
        }
        
        public ActionResult Kaydet(Product urun)
        {
            if(urun.CategoryID==0)
            {
                db.Products.Add(urun);
            }
            else //guncelleme
            {
               
            }
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}