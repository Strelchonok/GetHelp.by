using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetHelp.Controllers
{
    public class HomeController : Controller
    {
        // Компьютерная помощь
        public ActionResult Index()
        {
            ViewBag.Title = "Компьютерная помощь";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Удаление вирусов
        public ActionResult Viruses()
        {
            ViewBag.Title = "Удаление вирусов";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Установка Windiws
        public ActionResult InstWin()
        {
            ViewBag.Title = "Установка Windows";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Настройка Wi-Fi
        public ActionResult WiFi()
        {
            ViewBag.Title = "Настройка Wi-Fi";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Ремонт компьютера
        public ActionResult RepairComp()
        {
            ViewBag.Title = "Ремонт компьютеров";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Ремонт ноутбуков
        public ActionResult RepairBook()
        {
            ViewBag.Title = "Ремонт ноутбуков";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Установка программ
        public ActionResult Programs()
        {
            ViewBag.Title = "Установка программ";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

        // Модернизация компьютера
        public ActionResult Modern()
        {
            ViewBag.Title = "Модернизация компьютера";
            ViewBag.Description = "";
            ViewBag.KeyWords = "";

            return View();
        }

    }
}
