using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DormitoryWebProject.Models;

namespace DormitoryWebProject.Controllers.CMS
{
    public class LopController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: Lop
        public ActionResult Index()
        {
            var lop = db.Lop.Include(l => l.Khoa);
            return View(lop.ToList());
        }

        // GET: Lop/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop lop = db.Lop.Find(id);
            if (lop == null)
            {
                return HttpNotFound();
            }
            return View(lop);
        }

        // GET: Lop/Create
        public ActionResult Create()
        {
            ViewBag.MaKhoa = new SelectList(db.Khoa, "MaKhoa", "TenKhoa");
            return View();
        }

        // POST: Lop/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop,MaKhoa")] Lop lop)
        {
            if (ModelState.IsValid)
            {
                db.Lop.Add(lop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhoa = new SelectList(db.Khoa, "MaKhoa", "TenKhoa", lop.MaKhoa);
            return View(lop);
        }

        // GET: Lop/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lop lop = db.Lop.Find(id);
            if (lop == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhoa = new SelectList(db.Khoa, "MaKhoa", "TenKhoa", lop.MaKhoa);
            return View(lop);
        }

        // POST: Lop/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop,MaKhoa")] Lop lop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhoa = new SelectList(db.Khoa, "MaKhoa", "TenKhoa", lop.MaKhoa);
            return View(lop);
        }

        // GET: Lop/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Lop lop = db.Lop.Find(id);
        //    if (lop == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(lop);
        //}

        // POST: Lop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lop lop = db.Lop.Find(id);
            if (lop == null)
            {
                return HttpNotFound();
            }
            db.Lop.Remove(lop);
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
