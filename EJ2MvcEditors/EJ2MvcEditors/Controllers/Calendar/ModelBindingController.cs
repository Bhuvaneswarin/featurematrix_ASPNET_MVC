using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.Calendar
{
    public class CalendarModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class CalendarController : Controller
    {
        // GET: Model binding using ViewBag and ViewData
        public ActionResult ModelBinding()
        {
            var model = new CalendarModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View();
        }
        [HttpPost]
        public ActionResult ModelBinding(CalendarModelBinding model)
        {
            return View(model);
        }
    }
}