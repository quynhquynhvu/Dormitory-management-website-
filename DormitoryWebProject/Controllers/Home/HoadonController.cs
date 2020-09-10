using DormitoryWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Hoadon")]
    public class HoadonController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        //GET: Home/Hoadon/Hoadonlephi
        public ActionResult Hoadonlephi()
        {
            ViewData["aHD"] = "active";
            ViewData["aHDLP"] = "active";
            List<HoaDonLePhi> lstHoaDonLePhi = db.HoaDonLePhi.ToList<HoaDonLePhi>();
            return View(lstHoaDonLePhi);
        }

        public ActionResult TaoHoaDonLePhi()
        {
            ViewData["aHD"] = "active";
            ViewData["aHDLP"] = "active";
            HoaDonLePhi hoaDon = new HoaDonLePhi();
            return View(hoaDon);
        }

        //GET: Home/Hoadon/Hoadondiennuoc
        public ActionResult Hoadondiennuoc()
        {
            ViewData["aHD"] = "active";
            ViewData["aHDDN"] = "active";
            return View();
        }
    }
}