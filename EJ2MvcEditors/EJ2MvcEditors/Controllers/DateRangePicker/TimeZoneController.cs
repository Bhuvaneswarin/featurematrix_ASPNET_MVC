﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public partial class DateRangePickerController : Controller
    {
        // GET: TimeZone
        public ActionResult TimeZone()
        {
            ViewBag.startDate1 = new DateTime(2013, 06, 13, 14, 00, 00);
            ViewBag.endDate1 = new DateTime(2013, 06, 13, 15, 30, 00);

            ViewBag.startDate2 = "2013-06-13T14:00:00.000Z";
            ViewBag.endDate2 = "2013-06-13T15:30:00.000Z";
            return View();
        }
    }
}