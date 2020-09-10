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
    public class TangController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: Tang
        public ActionResult Index()
        {
            return View(db.Tang.ToList());
        }

        // GET: Tang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tang tang = db.Tang.Find(id);
            if (tang == null)
            {
                return HttpNotFound();
            }
            return View(tang);
        }

        // GET: Tang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tang/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTang,Ten")] Tang tang)
        {
            if (ModelState.IsValid)
            {
                db.Tang.Add(tang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tang);
        }

        // GET: Tang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tang tang = db.Tang.Find(id);
            if (tang == null)
            {
                return HttpNotFound();
            }
            return View(tang);
        }

        // POST: Tang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTang,Ten")] Tang tang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tang);
        }

        // GET: Tang/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Tang tang = db.Tang.Find(id);
        //    if (tang == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tang);
        //}

        // POST: Tang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tang tang = db.Tang.Find(id);
            if (tang == null)
            {
                return HttpNotFound();
            }
            db.Tang.Remove(tang);
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
