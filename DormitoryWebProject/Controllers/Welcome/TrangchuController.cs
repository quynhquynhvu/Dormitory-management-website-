using DormitoryWebProject.Models;
using DormitoryWebProject.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DormitoryWebProject.Controllers
{
    public class TrangchuController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();
        private TrangChuViewModel trangchuVM = new TrangChuViewModel();
        // GET: Trangchu
        public ActionResult Index()
        {
            trangchuVM.LISTKTX = db.KTX.ToList();
            trangchuVM.LISTChiTietKTX = db.ChiTietKTX.ToList();
            trangchuVM.LISTPoster = db.Poster.ToList();
            trangchuVM.LISTNhanXetKhachHang = db.NhanXetKhachHang.ToList();
            return View(trangchuVM);
        }
    }
}