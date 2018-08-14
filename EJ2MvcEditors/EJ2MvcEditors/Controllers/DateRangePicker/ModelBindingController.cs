using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public class DateRangeModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: Model binding using ViewBag and ViewData
        public ActionResult ModelBinding()
        {
            var model = new DateRangeModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View();
        }
        [HttpPost]
        public ActionResult ModelBinding(DateRangeModelBinding model)
        {
            return View(model);
        }
    }
}