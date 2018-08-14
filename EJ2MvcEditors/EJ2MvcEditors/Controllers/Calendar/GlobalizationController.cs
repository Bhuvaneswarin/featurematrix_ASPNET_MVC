using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.Calendar
{
    public partial class CalendarController : Controller
    {
        // GET: Globalization
        public ActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 07);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
            ViewBag.value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 14);
            return View();
        }
    }
}