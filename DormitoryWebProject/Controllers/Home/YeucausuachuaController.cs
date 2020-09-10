using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Yeucausuachua")]
    public class YeucausuachuaController : Controller
    {
        //GET: Home/Yeucausuachua
        [Route]
        public ActionResult Danhsachsuachua()
        {
            ViewData["aYCSC"] = "active";
            ViewData["aDSSC"] = "active";
            return View();
        }

        //GET: Home/Yeucausuachua/Themyeucau
        [Route("Themyeucau")]
        public ActionResult Themyeucau()
        {
            ViewData["aYCSC"] = "active";
            ViewData["aDSSC"] = "active";
            return View();
        }

        //GET: Home/Yeucausuachua/Chuyenyeucau
        [Route("Chuyenyeucau")]
        public ActionResult Chuyenyeucau()
        {
            ViewData["aYCSC"] = "active";
            ViewData["aCYC"] = "active";
            return View();
        }
    }
}