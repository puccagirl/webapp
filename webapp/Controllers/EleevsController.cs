using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    public class EleevsController : Controller
    {
        private DUMMY2Entities db = new DUMMY2Entities();

        // GET: Eleevs
        public ActionResult Index()
        {
            return View(db.Eleevs.ToList());
        }

        // GET: Eleevs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eleev eleev = db.Eleevs.Find(id);
            if (eleev == null)
            {
                return HttpNotFound();
            }
            return View(eleev);
        }

        // GET: Eleevs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eleevs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Numeleee")] Eleev eleev)
        {
            if (ModelState.IsValid)
            {
                db.Eleevs.Add(eleev);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eleev);
        }

        // GET: Eleevs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eleev eleev = db.Eleevs.Find(id);
            if (eleev == null)
            {
                return HttpNotFound();
            }
            return View(eleev);
        }

        // POST: Eleevs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Numeleee")] Eleev eleev)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eleev).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eleev);
        }

        // GET: Eleevs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eleev eleev = db.Eleevs.Find(id);
            if (eleev == null)
            {
                return HttpNotFound();
            }
            return View(eleev);
        }

        // POST: Eleevs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Eleev eleev = db.Eleevs.Find(id);
            db.Eleevs.Remove(eleev);
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
