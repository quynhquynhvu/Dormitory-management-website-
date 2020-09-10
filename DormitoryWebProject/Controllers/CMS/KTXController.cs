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
    public class KTXController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: KTX
        public ActionResult Index()
        {
            return View(db.KTX.ToList());
        }

        // GET: KTX/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KTX kTX = db.KTX.Find(id);
            if (kTX == null)
            {
                return HttpNotFound();
            }
            return View(kTX);
        }

        // GET: KTX/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KTX/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKTX,TenKTX,DiaChi,SDTLienHe,Email")] KTX kTX)
        {
            if (ModelState.IsValid)
            {
                db.KTX.Add(kTX);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kTX);
        }

        // GET: KTX/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KTX kTX = db.KTX.Find(id);
            if (kTX == null)
            {
                return HttpNotFound();
            }
            return View(kTX);
        }

        // POST: KTX/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKTX,TenKTX,DiaChi,SDTLienHe,Email")] KTX kTX)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kTX).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kTX);
        }

        // GET: KTX/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    KTX kTX = db.KTX.Find(id);
        //    if (kTX == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(kTX);
        //}

        // POST: KTX/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KTX kTX = db.KTX.Find(id);
            if (kTX == null)
            {
                return HttpNotFound();
            }
            db.KTX.Remove(kTX);
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
