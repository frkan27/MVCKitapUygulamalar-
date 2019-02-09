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
        public static List<Departman> departman { get; set; }
        
        // GET: Departman
        public ActionResult Index()
        {
            var model = new List<Departman>()
            {
                new Departman()
                {
                    Ad="BilgiİŞlem",
                    Id=1
                },
                new Departman()
                {
                    Ad="Muhasebe",
                    Id=2
                },
                 new Departman()
                {
                    Ad="Satış",
                    Id=3
                },


            };
            return View(model);
        }
    }
}