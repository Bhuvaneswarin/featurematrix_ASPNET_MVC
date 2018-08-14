using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public class DateRangePickerAjax
    {
        [Required(ErrorMessage = "Value is required")]
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: Ajax calling
        public ActionResult DateRangeAjax()
        {
            var model = new DateRangePickerAjax();
            model.startDate = new DateTime(2017, 11, 09);
            model.endDate = new DateTime(2017, 11, 21);
            return View(model);
        }
        [HttpPost]
        public ActionResult DateRangeAjax(DateRangePickerAjax model)
        {
            return View(model);
        }
    }
}