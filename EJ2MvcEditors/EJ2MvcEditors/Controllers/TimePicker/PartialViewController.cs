using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public partial class TimePickerController : Controller
    {
        // GET: Partial view
        public ActionResult PartialView()
        {
            ViewBag.value = new DateTime(2017, 05, 07, 01, 00, 00);
            return PartialView("~/Views/TimePicker/PartialView.cshtml");
        }
    }
}