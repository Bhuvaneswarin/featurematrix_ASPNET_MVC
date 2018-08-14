using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DatePicker
{
    public partial class DatePickerController : Controller
    {
        // GET: Globalization
        public ActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 07);
            ViewBag.maxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
            return View();
        }
    }
}