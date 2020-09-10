using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Sinhvien")]
    public class SinhvienController : Controller
    {
        //GET: Home/Sinhvien
        [Route]
        public ActionResult Hososinhvien()
        {
            ViewData["aSV"] = "active";
            return View();
        }

        //GET: Home/Sinhvien/Thongtinsinhvien
        [Route("Thongtinsinhvien")]
        public ActionResult Thongtinsinhvien()
        {
            ViewData["aSV"] = "active";
            return View();
        }

        //GET: Home/Sinhvien/Themsinhvien
        [Route("Themsinhvien")]
        public ActionResult Themsinhvien()
        {
            ViewData["aSV"] = "active";
            ViewData["aTSV"] = "active";
            return View();
        }

        /*//GET: Home/Sinhvien/Downloaddanhsach
        [Route("Downloaddanhsach")]
        public ActionResult Downloaddanhsach()
        {
            ViewData["aSV"] = "active";
            ViewData["aDDS"] = "active";
            return View();
        }*/
    }
}