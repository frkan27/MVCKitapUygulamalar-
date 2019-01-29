using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6.ViewData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Urun()
        {
            ViewData["UrunAdi"] = "Bilgisayar";
            return View();
        }
        public ActionResult Kategori()
        {
            ViewBag.KategoriAdi = "Yiyecekler";
            return View();
        }

    }
}