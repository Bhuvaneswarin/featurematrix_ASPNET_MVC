using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public partial class TimePickerController : Controller
    {
        // GET: TimeZone
        public ActionResult TimeZone()
        {
            var isoDate = "2018-09-05T10:35:15.282Z";
            ViewBag.value1 = "2018-09-05T10:35:15.282";
            ViewBag.value2 = isoDate;
            return View();
        }
    }
}