using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaSystem.Controllers
{
    public class HomeController : Controller
    {
        //TODO: Fix up the booking model. There needs to be business logic and sql data access.
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Enquiries()
        {
            ViewBag.Message = "Enquiry page";

            return View();
        }

        [Authorize]
        public ActionResult CreateBooking()
        {
            ViewBag.Message = "Create Booking page";

            return View();
        }

        public ActionResult SpaOffers()
        {
            ViewBag.Message = "Offers page";

            return View();
        }
    }
}