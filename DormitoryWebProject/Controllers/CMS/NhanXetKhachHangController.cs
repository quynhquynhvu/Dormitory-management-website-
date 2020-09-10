using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DormitoryWebProject.Models;

namespace DormitoryWebProject.Controllers.CMS
{
    public class NhanXetKhachHangController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: NhanXetKhachHang
        public ActionResult Index()
        {
            var nhanXetKhachHang = db.NhanXetKhachHang.Include(n => n.KhoaHoc);
            return View(nhanXetKhachHang.ToList());
        }

        // GET: NhanXetKhachHang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanXetKhachHang nhanXetKhachHang = db.NhanXetKhachHang.Find(id);
            if (nhanXetKhachHang == null)
            {
                return HttpNotFound();
            }
            return View(nhanXetKhachHang);
        }

        // GET: NhanXetKhachHang/Create
        public ActionResult Create()
        {
            ViewBag.MaKhoaHoc = new SelectList(db.KhoaHoc, "MaKhoaHoc", "TenKhoaHoc");
            return View();
        }

        // POST: NhanXetKhachHang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhanXet,TenKhachHang,BinhLuan,CongViec,Rated,pictureUpload,MaKhoaHoc")] NhanXetKhachHang nhanXetKhachHang)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename = Path.GetFileName(nhanXetKhachHang.pictureUpload.FileName);
                string path = Path.Combine(Server.MapPath("~/assets/images/CMS/client"), filename);
                nhanXetKhachHang.pictureUpload.SaveAs(path);
                string pathInDb = "/assets/images/CMS/client/" + filename;
                nhanXetKhachHang.picturePath = pathInDb;

                db.NhanXetKhachHang.Add(nhanXetKhachHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhoaHoc = new SelectList(db.KhoaHoc, "MaKhoaHoc", "TenKhoaHoc", nhanXetKhachHang.MaKhoaHoc);
            return View(nhanXetKhachHang);
        }

        // GET: NhanXetKhachHang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanXetKhachHang nhanXetKhachHang = db.NhanXetKhachHang.Find(id);
            if (nhanXetKhachHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhoaHoc = new SelectList(db.KhoaHoc, "MaKhoaHoc", "TenKhoaHoc", nhanXetKhachHang.MaKhoaHoc);
            return View(nhanXetKhachHang);
        }

        // POST: NhanXetKhachHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhanXet,TenKhachHang,BinhLuan,CongViec,Rated,pictureUpload,MaKhoaHoc")] NhanXetKhachHang nhanXetKhachHang)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename = Path.GetFileName(nhanXetKhachHang.pictureUpload.FileName);
                string path = Path.Combine(Server.MapPath("~/assets/images/CMS/client"), filename);
                nhanXetKhachHang.pictureUpload.SaveAs(path);
                string pathInDb = "/assets/images/CMS/client/" + filename;
                nhanXetKhachHang.picturePath = pathInDb;

                db.Entry(nhanXetKhachHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhoaHoc = new SelectList(db.KhoaHoc, "MaKhoaHoc", "TenKhoaHoc", nhanXetKhachHang.MaKhoaHoc);
            return View(nhanXetKhachHang);
        }

        // GET: NhanXetKhachHang/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    NhanXetKhachHang nhanXetKhachHang = db.NhanXetKhachHang.Find(id);
        //    if (nhanXetKhachHang == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(nhanXetKhachHang);
        //}

        // POST: NhanXetKhachHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhanXetKhachHang nhanXetKhachHang = db.NhanXetKhachHang.Find(id);
            if (nhanXetKhachHang == null)
            {
                return HttpNotFound();
            }
            db.NhanXetKhachHang.Remove(nhanXetKhachHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
