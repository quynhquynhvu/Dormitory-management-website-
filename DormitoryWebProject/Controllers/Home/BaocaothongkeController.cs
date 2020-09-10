using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Baocaothongke")]
    public class BaocaothongkeController : Controller
    {
        // GET: Home/Baocaothongke
        [Route]
        public ActionResult Baocaothongke()
        {
            ViewData["aBCTC"] = "active";
            return View();
        }
    }
}