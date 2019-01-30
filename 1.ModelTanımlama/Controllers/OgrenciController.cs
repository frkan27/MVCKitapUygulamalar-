using _1.ModelTanımlama.Models;
using _1.ModelTanımlama.Veri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1.ModelTanımlama.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Listele()
        {
            return View(OgrenciVeri.Ogrenciler);
        }
        public ActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yeni(Ogrenci ogrenci)
        {
            OgrenciVeri.Ogrenciler.Add(ogrenci);
            return RedirectToAction("Listele");/*View u calıstırma işlemi bu metotla yapılır*/
        }
      

        public ActionResult Update(int Id)
        {
            var ogrenci = OgrenciVeri.Ogrenciler.Where(x => x.Id == Id).FirstOrDefault();
            return View(ogrenci);
        }

        [HttpPost]
        public ActionResult Update(Ogrenci ogrenci)
        {
            Ogrenci duzenlenOgrenci = OgrenciVeri.Ogrenciler.Where(x => x.Id == ogrenci.Id).FirstOrDefault();
            duzenlenOgrenci.Ad = ogrenci.Ad;
            duzenlenOgrenci.Soyad = ogrenci.Soyad;
            duzenlenOgrenci.BolumAdi = ogrenci.BolumAdi;
            duzenlenOgrenci.GirisYili = ogrenci.GirisYili;
            duzenlenOgrenci.TC = ogrenci.TC;
            return RedirectToAction("Listele");
        }

        public ActionResult Delete(int Id)
        {
            var ogrenci = OgrenciVeri.Ogrenciler.Where(x => x.Id == Id).FirstOrDefault();
            return View(ogrenci);
        }
        [HttpPost]
        public ActionResult Delete(Ogrenci ogrenci)
        {
            Ogrenci sil = OgrenciVeri.Ogrenciler.Where(x => x.Id == ogrenci.Id).FirstOrDefault();
            OgrenciVeri.Ogrenciler.Remove(ogrenci);
            return RedirectToAction("Listele");
        }
        public ActionResult Details(int Id)
        {
            var ogrenci = OgrenciVeri.Ogrenciler.Where(x => x.Id == Id).FirstOrDefault();

            return View(ogrenci);
        }
    }
}