﻿using System;
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
    public class EventsController : Controller
    {
        private EMA db = new EMA();

        // GET: Events
        
        public ActionResult Index()
        {
            var events = db.Events;//.Include(@ => @.Artist).Include(@ => @.Event_Type);
            return View(events.ToList());
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Events/Create
        [Authorize(Roles = "Admin,EventManager")]
        public ActionResult Create()
        {
            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name");
            ViewBag.id_etype = new SelectList(db.Event_Type, "id_etype", "name");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_event,id_building,name,date,description,id_artist,id_etype")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name", @event.id_artist);
            ViewBag.id_etype = new SelectList(db.Event_Type, "id_etype", "name", @event.id_etype);
            return View(@event);
        }

        // GET: Events/Edit/5
        [Authorize(Roles = "Admin,EventManager")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name", @event.id_artist);
            ViewBag.id_etype = new SelectList(db.Event_Type, "id_etype", "name", @event.id_etype);
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_event,id_building,name,date,description,id_artist,id_etype")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name", @event.id_artist);
            ViewBag.id_etype = new SelectList(db.Event_Type, "id_etype", "name", @event.id_etype);
            return View(@event);
        }

        // GET: Events/Delete/5
        [Authorize(Roles = "Admin,EventManager")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
