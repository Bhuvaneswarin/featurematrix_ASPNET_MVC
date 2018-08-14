using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.TimePicker
{
    public class TimePickerPostBack
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? value { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        // GET: TimePicker postback
        public ActionResult PostBack()
        {
            var model = new TimePickerPostBack();
            model.value = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult PostBack(TimePickerPostBack model)
        {
            return View(model);
        }
    }
}