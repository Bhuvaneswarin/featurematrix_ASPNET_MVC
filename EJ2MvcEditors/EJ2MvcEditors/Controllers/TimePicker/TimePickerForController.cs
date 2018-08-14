using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public class TimePickerValue
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: TimePickerFor
        public ActionResult TimePickerFor()
        {
            var model = new TimePickerValue();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult TimePickerFor(TimePickerValue model)
        {
            return View(model);
        }
    }
}