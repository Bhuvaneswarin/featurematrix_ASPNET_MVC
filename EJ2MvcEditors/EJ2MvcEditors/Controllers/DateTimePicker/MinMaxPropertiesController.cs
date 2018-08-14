using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateTimePicker
{
    public partial class DateTimePickerController : Controller
    {
        // GET: MinMaxProperties
        public ActionResult MinMaxProperties()
        {
            ViewBag.minDate = new DateTime(2019, 11, 22, 12, 00, 00);
            ViewBag.maxDate = new DateTime(2019, 11, 25, 05, 00, 00);
            return View();
        }
    }
}