using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3.ViewLayoutSection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult AnaSayfa()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
    }
}