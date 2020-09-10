using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DormitoryWebProject.Models;
using DormitoryWebProject.ViewModels;


namespace DormitoryWebProject.Controllers
{
    [RoutePrefix("Home/Khuphong")]
    public class KhuphongController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();
        private ThongtinphongViewModel ThongtinphongVM = new ThongtinphongViewModel();
        //GET: Home/Khuphong
        [Route]
        public ActionResult Khuphong()
        {

            ViewData["aKP"] = "active";
            return View();
        }

        //GET: Home/Khuphong/Khuphongchitiet

        [Route("Khuphongchitiet")]

        public ActionResult Khuphongchitiet()
        {
            //ViewBag.Phongs = db.Phong.ToList();
            //ViewBag.Tangs = db.Tang.ToList();
            //ViewBag.Loais = db.Loai.ToList();
            //ViewBag.KTXs = db.KTX.ToList();
            //ViewBag.ChiTietPhongs = db.ChiTietPhong.ToList();
            //ViewBag.ChucVus = db.ChucVu.ToList();
            //ViewBag.SinhViens = db.SinhVien.ToList();
            //ViewBag.Khoas = db.Khoa.ToList();
            ThongtinphongVM.LISTPhong = db.Phong.ToList();
            ThongtinphongVM.LISTTang = db.Tang.ToList();
            ThongtinphongVM.LISTKTX = db.KTX.ToList();
            ThongtinphongVM.LISTLoai = db.Loai.ToList();
            ThongtinphongVM.LISTChiTiet = db.ChiTietPhong.ToList();
            ThongtinphongVM.LISTSinhVien = db.SinhVien.ToList();
            ThongtinphongVM.LISTKhoa = db.Khoa.ToList();
            ThongtinphongVM.LISTChiTietPhong = db.ChiTietPhong.ToList();
            ThongtinphongVM.LISTChucVu = db.ChucVu.ToList();
            ThongtinphongVM.LISTChiTietPhong = db.ChiTietPhong.ToList();
            return View(ThongtinphongVM);
        }
   
    }

}
