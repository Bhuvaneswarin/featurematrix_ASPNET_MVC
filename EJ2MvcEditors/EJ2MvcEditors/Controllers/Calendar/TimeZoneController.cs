﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.Calendar
{
    public partial class CalendarController : Controller
    {
        // GET: TimeZone
        public ActionResult TimeZone()
        {
            var isoDate = "2013-06-13T14:00:00.000Z";
            ViewBag.value1 = new DateTime(2013, 06, 13, 14, 00, 00);
            ViewBag.value2 = isoDate;
            return View();
        }
    }
}