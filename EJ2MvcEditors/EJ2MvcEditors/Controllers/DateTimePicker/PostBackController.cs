using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateTimePicker
{
    public class DateTimePickerPostBack
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        // GET: DateTimePicker post back
        public ActionResult PostBack()
        {
            var model = new DateTimePickerPostBack();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult PostBack(DateTimePickerPostBack model)
        {
            return View(model);
        }
    }
}