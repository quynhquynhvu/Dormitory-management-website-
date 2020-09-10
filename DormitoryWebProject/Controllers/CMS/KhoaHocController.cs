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
    public class KhoaHocController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: KhoaHoc
        public ActionResult Index()
        {
            return View(db.KhoaHoc.ToList());
        }

        // GET: KhoaHoc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaHoc khoaHoc = db.KhoaHoc.Find(id);
            if (khoaHoc == null)
            {
                return HttpNotFound();
            }
            return View(khoaHoc);
        }

        // GET: KhoaHoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhoaHoc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKhoaHoc,TenKhoaHoc")] KhoaHoc khoaHoc)
        {
            if (ModelState.IsValid)
            {
                db.KhoaHoc.Add(khoaHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khoaHoc);
        }

        // GET: KhoaHoc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhoaHoc khoaHoc = db.KhoaHoc.Find(id);
            if (khoaHoc == null)
            {
                return HttpNotFound();
            }
            return View(khoaHoc);
        }

        // POST: KhoaHoc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKhoaHoc,TenKhoaHoc")] KhoaHoc khoaHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khoaHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khoaHoc);
        }

        // GET: KhoaHoc/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    KhoaHoc khoaHoc = db.KhoaHoc.Find(id);
        //    if (khoaHoc == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(khoaHoc);
        //}

        // POST: KhoaHoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KhoaHoc khoaHoc = db.KhoaHoc.Find(id);
            if (khoaHoc == null)
            {
                return HttpNotFound();
            }
            db.KhoaHoc.Remove(khoaHoc);
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
