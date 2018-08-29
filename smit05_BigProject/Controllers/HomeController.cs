using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using smit05_BigProject.Models;

namespace smit05_BigProject.Controllers {
    public class HomeController : Controller {
        MarketGoEntities db = new MarketGoEntities();

        // GET: Home
        public ActionResult Index() {
            return View();
        }

        // GET: About
        public ActionResult About() {
            return View();
        }
    }
}