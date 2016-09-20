using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeifssonNetMvc.Models;

namespace LeifssonNetMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel m = new HomeViewModel {HostName = Environment.MachineName};
            return View(m);
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Sumarfri()
        {
            return View();
        }
    }
}