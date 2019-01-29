using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7.MVC_CSS_Kullanımı.Controllers
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

        public ActionResult Uye()
        {
            return View();
        }

        public ActionResult Yonetici()
        {
            return View();
        }

        public ActionResult MusteriTemsilcisi()
        {
            return View();
        }
    }
}