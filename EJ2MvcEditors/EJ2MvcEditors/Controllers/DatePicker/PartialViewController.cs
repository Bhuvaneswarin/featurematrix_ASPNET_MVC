using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DatePicker
{
    public partial class DatePickerController : Controller
    {
        // GET: Partial view
        public ActionResult PartialView()
        {
            ViewBag.Value = new DateTime(2017, 05, 07, 01, 00, 00);
            return PartialView("~/Views/DatePicker/PartialView.cshtml");
        }
    }
}