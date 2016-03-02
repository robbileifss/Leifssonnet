using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeifssonNetMvc.Controllers
{
    public class SumarfriController : Controller
    {
        // GET: Sumarfri
        public ActionResult Index()
        {
            int numDays = 0;
            DateTime summerDate = new DateTime(2016, 6, 2);
            numDays = summerDate.Subtract(DateTime.Now).Days;

            ViewBag.NumDays = numDays;
            
            return View();
        }
    }
}