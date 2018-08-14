using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public partial class TimePickerController : Controller
    {
        // GET: MinMaxProperties
        public ActionResult MinMaxProperties()
        {
            ViewBag.minVal = new DateTime(2017, 05, 07, 07, 00, 00);
            ViewBag.maxVal = new DateTime(2017, 05, 07, 04, 00, 00);
            ViewBag.value = new DateTime(2017, 05, 07, 01, 00, 00);
            return View();
        }
    }
}