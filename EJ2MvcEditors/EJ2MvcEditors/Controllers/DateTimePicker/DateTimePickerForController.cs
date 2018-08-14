using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateTimePicker
{
    public class DateTimePickerValue
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        // GET: DateTimePickerFor
        public ActionResult DateTimePickerFor()
        {
            var model = new DateTimePickerValue();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult DateTimePickerFor(DateTimePickerValue model)
        {
            return View(model);
        }
    }
}