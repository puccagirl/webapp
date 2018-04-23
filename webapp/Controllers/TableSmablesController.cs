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
    public class TableSmablesController : Controller
    {
        private Database1Entities2 db = new Database1Entities2();

        // GET: TableSmables
        public ActionResult Index()
        {
            return View(db.TableSmables.ToList());
        }

        // GET: TableSmables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableSmable tableSmable = db.TableSmables.Find(id);
            if (tableSmable == null)
            {
                return HttpNotFound();
            }
            return View(tableSmable);
        }

        // GET: TableSmables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TableSmables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nume")] TableSmable tableSmable)
        {
            if (ModelState.IsValid)
            {
                db.TableSmables.Add(tableSmable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tableSmable);
        }

        // GET: TableSmables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableSmable tableSmable = db.TableSmables.Find(id);
            if (tableSmable == null)
            {
                return HttpNotFound();
            }
            return View(tableSmable);
        }

        // POST: TableSmables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nume")] TableSmable tableSmable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tableSmable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tableSmable);
        }

        // GET: TableSmables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TableSmable tableSmable = db.TableSmables.Find(id);
            if (tableSmable == null)
            {
                return HttpNotFound();
            }
            return View(tableSmable);
        }

        // POST: TableSmables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TableSmable tableSmable = db.TableSmables.Find(id);
            db.TableSmables.Remove(tableSmable);
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
