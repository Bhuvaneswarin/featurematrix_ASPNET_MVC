using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateTimePicker
{
    public class DateTimePickerModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        // GET: Model binding using ViewBag and ViewData
        public ActionResult ModelBinding()
        {
            var model = new DateTimePickerModelBinding()
            {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View(model);
        }
        [HttpPost]
        public ActionResult ModelBinding(DateTimePickerModelBinding model)
        {
            return View(model);
        }
    }
}