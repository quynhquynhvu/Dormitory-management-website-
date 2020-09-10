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
    public class PosterController : Controller
    {
        private DormitoryDBContext db = new DormitoryDBContext();

        // GET: Poster
        public ActionResult Index()
        {
            return View(db.Poster.ToList());
        }

        // GET: Poster/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poster poster = db.Poster.Find(id);
            if (poster == null)
            {
                return HttpNotFound();
            }
            return View(poster);
        }

        // GET: Poster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Poster/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPoster,Caption,LastModified,pictureUpload")] Poster poster)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename = Path.GetFileName(poster.pictureUpload.FileName);
                string path = Path.Combine(Server.MapPath("~/assets/images/CMS/poster"), filename);
                poster.pictureUpload.SaveAs(path);
                string pathInDb = "/assets/images/CMS/poster/" + filename;
                poster.picturePath = pathInDb;

                poster.LastModified = DateTime.Now;
                db.Poster.Add(poster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(poster);
        }

        // GET: Poster/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Poster poster = db.Poster.Find(id);
            if (poster == null)
            {
                return HttpNotFound();
            }
            return View(poster);
        }

        // POST: Poster/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPoster,Caption,LastModified,pictureUpload")] Poster poster)
        {
            if (ModelState.IsValid)
            {
                //Picture Handle
                string filename = Path.GetFileName(poster.pictureUpload.FileName);
                string path = Path.Combine(Server.MapPath("~/assets/images/CMS/poster"), filename);
                poster.pictureUpload.SaveAs(path);
                string pathInDb = "/assets/images/CMS/poster/" + filename;
                poster.picturePath = pathInDb;

                poster.LastModified = DateTime.Now;
                db.Entry(poster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(poster);
        }

        // GET: Poster/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Poster poster = db.Poster.Find(id);
        //    if (poster == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(poster);
        //}

        // POST: Poster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Poster poster = db.Poster.Find(id);
            if (poster == null)
            {
                return HttpNotFound();
            }
            db.Poster.Remove(poster);
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
