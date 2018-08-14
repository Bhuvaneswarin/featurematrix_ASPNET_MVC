using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public class TimePickerAjaxValue
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: TimePickerFor
        public ActionResult TimePickerAjax()
        {
            var model = new TimePickerAjaxValue();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult TimePickerAjax(TimePickerAjaxValue model)
        {
            return View(model);
        }
    }
}