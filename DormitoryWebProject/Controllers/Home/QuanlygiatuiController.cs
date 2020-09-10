using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Quanlygiatui")]
    public class QuanlygiatuiController : Controller
    {
        //GET: Home/Quanlygiatui
        [Route]
        public ActionResult Danhsachgiatui()
        {
            ViewData["aQLGU"] = "active";
            return View();
        }

        //GET: Home/Quanlygiatui/Taophieugiatui
        [Route("Taophieugiatui")]
        public ActionResult Taophieugiatui()
        {
            ViewData["aQLGU"] = "active";
            return View();
        }
    }
}