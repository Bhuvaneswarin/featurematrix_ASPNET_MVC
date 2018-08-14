using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateTimePicker
{
    public class DateTimePickerAjax
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        // GET: DateTimePicker Ajax
        public ActionResult DateTimeAjax()
        {
            var model = new DateTimePickerAjax();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult DateTimeAjax(DateTimePickerAjax model)
        {
            return View(model);
        }
    }
}