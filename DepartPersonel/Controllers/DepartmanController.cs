using DepartPersonel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DepartPersonel.Controllers
{
    public class DepartmanController : Controller
    {
        MyContext db = new MyContext();
       
      // public static List<Departman> dep { get; set; }
        // GET: Departman
        public ActionResult Index()
        {
            //var model = new List<Departman>()
            //{
            //    new Departman()
            //    {
            //        Ad="Bilgiİşlem",
            //        Id=1
            //    },
            //    new Departman()
            //    {
            //        Ad="Muhasebe",
            //        Id=2
            //    },
            //     new Departman()
            //    {
            //        Ad="Satış",
            //        Id=3
            //    },


            //};
            return View();
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Departman model)
        {
            
            db.Departmanlar.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index","Departman");
        }
    }
}