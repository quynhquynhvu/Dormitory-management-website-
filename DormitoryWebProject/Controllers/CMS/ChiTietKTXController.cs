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
    public class ChiTietKTXController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: ChiTietKTX
        public ActionResult Index()
        {
            var chiTietKTX = db.ChiTietKTX.Include(c => c.KTX);
            return View(chiTietKTX.ToList());
        }

        // GET: ChiTietKTX/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietKTX chiTietKTX = db.ChiTietKTX.Find(id);
            if (chiTietKTX == null)
            {
                return HttpNotFound();
            }
            return View(chiTietKTX);
        }

        // GET: ChiTietKTX/Create
        public ActionResult Create()
        {
            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX");
            return View();
        }

        // POST: ChiTietKTX/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChiTietKTX,Rated,GiaThueThapNhat,GiaThueCaoNhat,MoTaKTX,pictureUpload1,pictureUpload2,pictureUpload3,pictureUpload4,pictureUpload5,MaKTX")] ChiTietKTX chiTietKTX)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename1 = Path.GetFileName(chiTietKTX.pictureUpload1.FileName);
                string filename2 = Path.GetFileName(chiTietKTX.pictureUpload2.FileName);
                string filename3 = Path.GetFileName(chiTietKTX.pictureUpload3.FileName);
                string filename4 = Path.GetFileName(chiTietKTX.pictureUpload4.FileName);
                string filename5 = Path.GetFileName(chiTietKTX.pictureUpload5.FileName);
                string path1 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename1);
                string path2 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename2);
                string path3 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename3);
                string path4 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename4);
                string path5 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename5);
                chiTietKTX.pictureUpload1.SaveAs(path1);
                chiTietKTX.pictureUpload2.SaveAs(path2);
                chiTietKTX.pictureUpload3.SaveAs(path3);
                chiTietKTX.pictureUpload4.SaveAs(path4);
                chiTietKTX.pictureUpload5.SaveAs(path5);
                string pathInDb1 = "/assets/images/CMS/chiTietKTX/" + filename1;
                string pathInDb2 = "/assets/images/CMS/chiTietKTX/" + filename2;
                string pathInDb3 = "/assets/images/CMS/chiTietKTX/" + filename3;
                string pathInDb4 = "/assets/images/CMS/chiTietKTX/" + filename4;
                string pathInDb5 = "/assets/images/CMS/chiTietKTX/" + filename5;
                chiTietKTX.picturePath1 = pathInDb1;
                chiTietKTX.picturePath2 = pathInDb2;
                chiTietKTX.picturePath3 = pathInDb3;
                chiTietKTX.picturePath4 = pathInDb4;
                chiTietKTX.picturePath5 = pathInDb5;

                db.ChiTietKTX.Add(chiTietKTX);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX", chiTietKTX.MaKTX);
            return View(chiTietKTX);
        }

        // GET: ChiTietKTX/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietKTX chiTietKTX = db.ChiTietKTX.Find(id);
            if (chiTietKTX == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX", chiTietKTX.MaKTX);
            return View(chiTietKTX);
        }

        // POST: ChiTietKTX/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChiTietKTX,Rated,GiaThueThapNhat,GiaThueCaoNhat,MoTaKTX,pictureUpload1,pictureUpload2,pictureUpload3,pictureUpload4,pictureUpload5,MaKTX")] ChiTietKTX chiTietKTX)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename1 = Path.GetFileName(chiTietKTX.pictureUpload1.FileName);
                string filename2 = Path.GetFileName(chiTietKTX.pictureUpload2.FileName);
                string filename3 = Path.GetFileName(chiTietKTX.pictureUpload3.FileName);
                string filename4 = Path.GetFileName(chiTietKTX.pictureUpload4.FileName);
                string filename5 = Path.GetFileName(chiTietKTX.pictureUpload5.FileName);
                string path1 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename1);
                string path2 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename2);
                string path3 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename3);
                string path4 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename4);
                string path5 = Path.Combine(Server.MapPath("~/assets/images/CMS/chiTietKTX"), filename5);
                chiTietKTX.pictureUpload1.SaveAs(path1);
                chiTietKTX.pictureUpload2.SaveAs(path2);
                chiTietKTX.pictureUpload3.SaveAs(path3);
                chiTietKTX.pictureUpload4.SaveAs(path4);
                chiTietKTX.pictureUpload5.SaveAs(path5);
                string pathInDb1 = "/assets/images/CMS/chiTietKTX/" + filename1;
                string pathInDb2 = "/assets/images/CMS/chiTietKTX/" + filename2;
                string pathInDb3 = "/assets/images/CMS/chiTietKTX/" + filename3;
                string pathInDb4 = "/assets/images/CMS/chiTietKTX/" + filename4;
                string pathInDb5 = "/assets/images/CMS/chiTietKTX/" + filename5;
                chiTietKTX.picturePath1 = pathInDb1;
                chiTietKTX.picturePath2 = pathInDb2;
                chiTietKTX.picturePath3 = pathInDb3;
                chiTietKTX.picturePath4 = pathInDb4;
                chiTietKTX.picturePath5 = pathInDb5;

                db.Entry(chiTietKTX).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKTX = new SelectList(db.KTX, "MaKTX", "TenKTX", chiTietKTX.MaKTX);
            return View(chiTietKTX);
        }

        // GET: ChiTietKTX/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ChiTietKTX chiTietKTX = db.ChiTietKTX.Find(id);
        //    if (chiTietKTX == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(chiTietKTX);
        //}

        // POST: ChiTietKTX/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietKTX chiTietKTX = db.ChiTietKTX.Find(id);
            if (chiTietKTX == null)
            {
                return HttpNotFound();
            }
            db.ChiTietKTX.Remove(chiTietKTX);
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
