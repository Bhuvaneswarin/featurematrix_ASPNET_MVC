using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DatePicker
{
    public class DatePickerPostBack
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        // GET: DatePicker post back
        public ActionResult PostBack()
        {
            var model = new DatePickerPostBack();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult PostBack(DatePickerPostBack model)
        {
            return View(model);
        }
    }
}