using DepatmanOrneği.Models;
using DepatmanOrneği.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DepatmanOrneği.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Detail(int id=5)
        {
            var departman = new Departman() { Id = id, Ad = "Bilgi İşlem" };

            var personeller = new List<Personel>()
            {
                new Personel(){Ad="personel1"},
                 new Personel(){Ad="personel2"},
                  new Personel(){Ad="personel3"}

            };

            var model = new DepartmanDetayViewModel()
            {
                Departman = departman,
                Personeller = personeller
            };
           
            return View(model);
        }



    }
}