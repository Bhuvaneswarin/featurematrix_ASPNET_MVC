using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public class TimePickerModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: Model Binding
        public ActionResult ModelBinding()
        {
            var model = new TimePickerModelBinding() {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View(model);
        }
        [HttpPost]
        public ActionResult ModelBinding(TimePickerModelBinding model)
        {
            return View(model);
        }
    }
}