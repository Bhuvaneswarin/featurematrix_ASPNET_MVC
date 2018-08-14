using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateTimePicker
{
    public partial class DateTimePickerController : Controller
    {
        // GET: Partial view
        public ActionResult PartialView()
        {
            ViewBag.Value = new DateTime(2019, 11, 22, 12, 00, 00);
            return PartialView("~/Views/DateTimePicker/PartialView.cshtml");
        }
    }
}