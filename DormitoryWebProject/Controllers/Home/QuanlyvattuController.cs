using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Quanlyvattu")]
    public class QuanlyvattuController : Controller
    {
        //GET: Home/Quanlyvattu
        [Route]
        public ActionResult Quanlykho()
        {
            ViewData["aQLVT"] = "active";
            return View();
        }

        //GET: Home/Quanlyvattu/Themvattu
        [Route("Themvattu")]
        public ActionResult Themvattu()
        {
            ViewData["aQLVT"] = "active";
            ViewData["aTVT"] = "active";
            return View();
        }

        //GET: Home/Quanlyvattu/Tiepnhanyeucau
        [Route("Tiepnhanyeucau")]
        public ActionResult Tiepnhanyeucau()
        {
            ViewData["aQLVT"] = "active";
            ViewData["aTNYC"] = "active";
            return View();
        }
    }
}