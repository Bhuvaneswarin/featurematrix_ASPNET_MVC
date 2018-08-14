using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MvcEditors.Controllers.Sidebar
{
    public partial class SidebarController : Controller
    {
        // GET: Partial view
        public ActionResult PartialView()
        {
            return PartialView("~/Views/Sidebar/PartialView.cshtml");
        }
    }
}