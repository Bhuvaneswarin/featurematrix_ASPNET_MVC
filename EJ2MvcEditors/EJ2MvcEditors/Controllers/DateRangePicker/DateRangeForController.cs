using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public class DateRangePickerFor
    {
        public string value { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: DateRangePickerFor
        public ActionResult DateRangeFor()
        {
            var model = new DateRangePickerFor();
            model.value = "05/28/2017-06/27/2017";
            return View(model);
        }
        [HttpPost]
        public ActionResult DateRangeFor(DateRangePickerFor model)
        {
            return View(model);
        }
    }
}