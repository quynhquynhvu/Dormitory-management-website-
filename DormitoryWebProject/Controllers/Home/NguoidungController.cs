using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Nguoidung")]
    public class NguoidungController : Controller
    {
        // GET: Home/Nguoidung/Quanlynguoidung
        [Route("Thongtinnguoidung")]
        public ActionResult Thongtinnguoidung()
        {
            ViewData["aND"] = "active";
            ViewData["aTTND"] = "active";
            return View();
        }

        // GET: Home/Nguoidung/Quanlynguoidung
        [Route("Quanlynguoidung")]
        public ActionResult Quanlynguoidung()
        {
            ViewData["aND"] = "active";
            ViewData["aQLND"] = "active";
            return View();
        }

        // GET: Home/Nguoidung/Themnguoidung
        [Route("Themnguoidung")]
        public ActionResult Themnguoidung()
        {
            ViewData["aND"] = "active";
            ViewData["aQLND"] = "active";
            return View();
        }

        // GET: Home/Nguoidung/Quanlynhomnguoidung
        [Route("Quanlynhomnguoidung")]
        public ActionResult Quanlynhomnguoidung()
        {
            ViewData["aND"] = "active";
            ViewData["aQLNND"] = "active";
            return View();
        }

        // GET: Home/Nguoidung/Themnhomnguoidung
        [Route("Themnhomnguoidung")]
        public ActionResult Themnhomnguoidung()
        {
            ViewData["aND"] = "active";
            ViewData["aQLNND"] = "active";
            return View();
        }
    }
}