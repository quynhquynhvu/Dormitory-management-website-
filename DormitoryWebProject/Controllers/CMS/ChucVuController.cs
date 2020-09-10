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
    public class ChucVuController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: ChucVu
        public ActionResult Index()
        {
            return View(db.ChucVu.ToList());
        }

        // GET: ChucVu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChucVu chucVu = db.ChucVu.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // GET: ChucVu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChucVu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChucVu,TenChucVu")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                db.ChucVu.Add(chucVu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chucVu);
        }

        // GET: ChucVu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChucVu chucVu = db.ChucVu.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            return View(chucVu);
        }

        // POST: ChucVu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChucVu,TenChucVu")] ChucVu chucVu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chucVu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chucVu);
        }

        // GET: ChucVu/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ChucVu chucVu = db.ChucVu.Find(id);
        //    if (chucVu == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(chucVu);
        //}

        // POST: ChucVu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChucVu chucVu = db.ChucVu.Find(id);
            if (chucVu == null)
            {
                return HttpNotFound();
            }
            db.ChucVu.Remove(chucVu);
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
