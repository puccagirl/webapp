using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapp.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservations
        public ActionResult Index()
        {
            return View();
        }

        // /reservations/add

        public ActionResult AddReservation()
        {
            return View();
        }

        // /reservations/viewall

        public ActionResult ViewReservations()
        {
            return View();
        }
    }
}