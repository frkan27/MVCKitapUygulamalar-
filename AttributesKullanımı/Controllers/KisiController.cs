using AttributesKullanımı.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributesKullanımı.Controllers
{
    public class KisiController : Controller
    {
     public ActionResult Create()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View(kisi);
        }

        private static Kisi kisi = new Kisi()
        {
            Id = 1,
            Ad = "Furkan",
            Soyad = "Kılıc",
            TCKN = "2232123212",
            DogumTarihi=new DateTime(1993,09,16)
        };

        public ActionResult Detail()
        {
            return View(kisi);
        }
    }
}