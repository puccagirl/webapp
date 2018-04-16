using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webapp.Models;


namespace webapp.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View();
        }

        // /events/addevent
        public ActionResult AddEvent()
        {
            return View();
        }

        // /events/delevent
        public ActionResult DelEvent()
        {
            return View();
        }

        // /events/editevent/index
        public ActionResult EditEvent()
        {
            return View();
        }

        // /events/viewall

        public ActionResult ViewEvents()
        {
            return View();
        }
    }
}