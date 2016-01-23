using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetHelp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Viruses()
        {
            ViewBag.Title = "Viruses";

            return View();
        }

        public ActionResult InstWin()
        {
            ViewBag.Title = "Viruses";

            return View();
        }

        public ActionResult WiFi()
        {
            ViewBag.Title = "WiFI";

            return View();
        }

        public ActionResult RepairComp()
        {
            ViewBag.Title = "RepairComp";

            return View();
        }
    }
}
