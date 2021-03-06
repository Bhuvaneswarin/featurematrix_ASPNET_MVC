﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public partial class DateRangePickerController : Controller
    {
        // GET: Partial View
        public ActionResult PartialView()
        {
            ViewBag.startDate = new DateTime(2017, 11, 09);
            ViewBag.endDate = new DateTime(2017, 11, 21);
            return PartialView("~/Views/DateRangePicker/PartialView.cshtml");
        }
    }
}