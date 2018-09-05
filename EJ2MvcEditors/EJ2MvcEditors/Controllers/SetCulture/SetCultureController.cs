using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.SetCulture
{
    public partial class SetCultureController : Controller
    {
        // GET: SetCulture
        public ActionResult SetCulture()
        {
            ViewBag.value = DateTime.Now;
            ViewBag.startDate = new DateTime(2017, 11, 09);
            ViewBag.endDate = new DateTime(2017, 11, 21);
            return View();
        }
    }
}