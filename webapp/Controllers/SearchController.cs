using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webapp.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        // /search/byartist

        public ActionResult ByArtist()
        {
            return View();
        }

        // /search/bylocation

        public ActionResult ByLocation()
        {
            return View();
        }

        //search/bydate

        public ActionResult ByDate()
        {
            return View();
        }
    }
}