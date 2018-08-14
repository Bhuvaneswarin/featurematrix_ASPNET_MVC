using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DatePicker
{
    public class DatePickerAjax
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        // GET: Ajax calling
        public ActionResult AjaxCalling()
        {
            var model = new DatePickerAjax();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult AjaxCalling(DatePickerAjax model)
        {
            return View(model);
        }
    }
}