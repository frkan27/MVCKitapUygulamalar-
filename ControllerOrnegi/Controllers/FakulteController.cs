using ControllerOrnegi.DAL;
using ControllerOrnegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerOrnegi.Controllers
{
    public class FakulteController : Controller
    {
        OBSContext obs = new OBSContext();

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public RedirectResult Add(Fakulte fakulte)
        {
            obs.Fakulteler.Add(fakulte);
            obs.SaveChanges();
            return Redirect("http://www.facebook.com");
        }
    }
}