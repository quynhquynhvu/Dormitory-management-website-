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
    public class PhongController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: Phong
        public ActionResult Index()
        {
            var phong = db.Phong.Include(p => p.KTX).Include(p => p.Loai).Include(p => p.Tang);
            return View(phong.ToList());
        }

        // GET: Phong/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phong phong = db.Phong.Find(id);
            if (phong == null)
            {
                return HttpNotFound();
            }
            return View(phong);
        }

        // GET: Phong/Create
        public ActionResult Create()
        {
            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX");
            ViewBag.MaLoai = new SelectList(db.Loai, "MaLoai", "TenLoai");
            ViewBag.MaTang = new SelectList(db.Tang, "MaTang", "Ten");
            return View();
        }

        // POST: Phong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhong,TenPhong,TongSoGiuong,CoSoVatChat,pictureUpload1,pictureUpload2,pictureUpload3,pictureUpload4,pictureUpload5,MaKTX,MaTang,MaLoai")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename1 = Path.GetFileName(phong.pictureUpload1.FileName);
                string filename2 = Path.GetFileName(phong.pictureUpload2.FileName);
                string filename3 = Path.GetFileName(phong.pictureUpload3.FileName);
                string filename4 = Path.GetFileName(phong.pictureUpload4.FileName);
                string filename5 = Path.GetFileName(phong.pictureUpload5.FileName);
                string path1 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename1);
                string path2 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename2);
                string path3 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename3);
                string path4 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename4);
                string path5 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename5);
                phong.pictureUpload1.SaveAs(path1);
                phong.pictureUpload2.SaveAs(path2);
                phong.pictureUpload3.SaveAs(path3);
                phong.pictureUpload4.SaveAs(path4);
                phong.pictureUpload5.SaveAs(path5);
                string pathInDb1 = "/assets/images/CMS/phong/" + filename1;
                string pathInDb2 = "/assets/images/CMS/phong/" + filename2;
                string pathInDb3 = "/assets/images/CMS/phong/" + filename3;
                string pathInDb4 = "/assets/images/CMS/phong/" + filename4;
                string pathInDb5 = "/assets/images/CMS/phong/" + filename5;
                phong.picturePath1 = pathInDb1;
                phong.picturePath2 = pathInDb2;
                phong.picturePath3 = pathInDb3;
                phong.picturePath4 = pathInDb4;
                phong.picturePath5 = pathInDb5;

                db.Phong.Add(phong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX", phong.MaKTX);
            ViewBag.MaLoai = new SelectList(db.Loai, "MaLoai", "TenLoai", phong.MaLoai);
            ViewBag.MaTang = new SelectList(db.Tang, "MaTang", "Ten", phong.MaTang);
            return View(phong);
        }

        // GET: Phong/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phong phong = db.Phong.Find(id);
            if (phong == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX", phong.MaKTX);
            ViewBag.MaLoai = new SelectList(db.Loai, "MaLoai", "TenLoai", phong.MaLoai);
            ViewBag.MaTang = new SelectList(db.Tang, "MaTang", "Ten", phong.MaTang);
            return View(phong);
        }

        // POST: Phong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhong,TenPhong,TongSoGiuong,CoSoVatChat,pictureUpload1,pictureUpload2,pictureUpload3,pictureUpload4,pictureUpload5,MaKTX,MaTang,MaLoai")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename1 = Path.GetFileName(phong.pictureUpload1.FileName);
                string filename2 = Path.GetFileName(phong.pictureUpload2.FileName);
                string filename3 = Path.GetFileName(phong.pictureUpload3.FileName);
                string filename4 = Path.GetFileName(phong.pictureUpload4.FileName);
                string filename5 = Path.GetFileName(phong.pictureUpload5.FileName);
                string path1 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename1);
                string path2 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename2);
                string path3 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename3);
                string path4 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename4);
                string path5 = Path.Combine(Server.MapPath("~/assets/images/CMS/phong"), filename5);
                phong.pictureUpload1.SaveAs(path1);
                phong.pictureUpload2.SaveAs(path2);
                phong.pictureUpload3.SaveAs(path3);
                phong.pictureUpload4.SaveAs(path4);
                phong.pictureUpload5.SaveAs(path5);
                string pathInDb1 = "/assets/images/CMS/phong/" + filename1;
                string pathInDb2 = "/assets/images/CMS/phong/" + filename2;
                string pathInDb3 = "/assets/images/CMS/phong/" + filename3;
                string pathInDb4 = "/assets/images/CMS/phong/" + filename4;
                string pathInDb5 = "/assets/images/CMS/phong/" + filename5;
                phong.picturePath1 = pathInDb1;
                phong.picturePath2 = pathInDb2;
                phong.picturePath3 = pathInDb3;
                phong.picturePath4 = pathInDb4;
                phong.picturePath5 = pathInDb5;

                db.Entry(phong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX", phong.MaKTX);
            ViewBag.MaLoai = new SelectList(db.Loai, "MaLoai", "TenLoai", phong.MaLoai);
            ViewBag.MaTang = new SelectList(db.Tang, "MaTang", "Ten", phong.MaTang);
            return View(phong);
        }

        // GET: Phong/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Phong phong = db.Phong.Find(id);
        //    if (phong == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phong);
        //}

        // POST: Phong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Phong phong = db.Phong.Find(id);
            if (phong == null)
            {
                return HttpNotFound();
            }
            if (phong == null)
            {
                return HttpNotFound();
            }
            db.Phong.Remove(phong);
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
