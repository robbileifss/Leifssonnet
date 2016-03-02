using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LeifssonNetMvc.Controllers
{
    public class SumarfriController : Controller
    {
        // GET: Sumarfri
        public ActionResult Index()
        {
            string dateString;
            if (DateTime.Now.Day < 10)
            {
                dateString = DateTime.Now.Date.ToString("d. MMMM yyyy");
            }
            else
            {
                dateString = DateTime.Now.Date.ToString("dd. MMMM yyyy");
            }

        int numDays = 0;
            DateTime summerDate = new DateTime(2016, 6, 2);
            numDays = summerDate.Subtract(DateTime.Now).Days;

            ViewBag.NumDays = numDays;
            ViewBag.ToDay = dateString;

            return View();
        }
    }
}