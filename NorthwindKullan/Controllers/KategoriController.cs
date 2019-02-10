using NorthwindKullan.Models.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindKullan.Controllers
{
    public class KategoriController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Kategori
        public ActionResult Index()
        {
            var model = db.Categories.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View();
        }

       [HttpPost]
      
       public ActionResult Yeni(Category model)
        {
            db.Categories.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index", "Kategori");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var model = db.Categories.Find(id);
            if (model == null)
                return HttpNotFound();
            return View(model);
        }

        [HttpPost]

        public ActionResult Guncelle(Category model)
        {
            var data = db.Categories.Find(model.CategoryID);
            data.CategoryName = model.CategoryName;
            data.Description = model.Description;
            
            db.SaveChanges();
            return View(data);


        }
    }
}