using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home")]
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [Route]
        public ActionResult Dashboard()
        {
            ViewData["aDB"] = "active";
            return View();
        }
    }
}