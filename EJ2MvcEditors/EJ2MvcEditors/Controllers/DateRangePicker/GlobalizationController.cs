using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public partial class DateRangePickerController : Controller
    {
        // GET: Globalization
        public ActionResult Globalization()
        {
            ViewBag.minDate = new DateTime(2017, 01, 05);
            ViewBag.maxDate = new DateTime(2017, 12, 20);
            return View();
        }
    }
}