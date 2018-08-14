using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DatePicker
{
    public class DatePickerValue
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        // GET: DatePickerFor
        public ActionResult DatePickerFor()
        {
            var model = new DatePickerValue();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult DatePickerFor(DatePickerValue model)
        {
            return View(model);
        }
    }
}