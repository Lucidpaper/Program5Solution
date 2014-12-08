using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCWebApp.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoNotLike()
        {
            ViewBag.PageTitle = "music I dont like";
            return View();
        }

        public ActionResult PartialVeiwTest()
        {
            return PartialView();
        }

        public ActionResult contenttest()
        {
           return Content("asdfasdf");
        }
    }
}