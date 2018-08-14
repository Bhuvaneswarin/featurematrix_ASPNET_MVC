using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.DateRangePicker
{
    public class DateRangePostBack
    {
        public string value { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        // GET: PostBack calling
        public ActionResult PostBack()
        {
            var model = new DateRangePostBack();
            model.value = "05/28/2017-06/27/2017";
            return View(model);
        }
        [HttpPost]
        public ActionResult PostBack(DateRangePostBack model)
        {
            return View(model);
        }
    }
}