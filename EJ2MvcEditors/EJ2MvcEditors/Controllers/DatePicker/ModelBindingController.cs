using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DatePicker
{
    public class DatePickerModelBinding
    {
        public DateTime? value { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        // GET: Model binding
        public ActionResult ModelBinding()
        {
            var model = new DatePickerModelBinding() {
                value = DateTime.Now
            };
            ViewBag.value = model.value;
            ViewData["value"] = model.value;
            return View();
        }
        [HttpPost]
        public ActionResult ModelBinding(DatePickerModelBinding model)
        {
            return View(model);
        }
    }
}