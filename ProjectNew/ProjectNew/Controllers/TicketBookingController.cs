using ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectNew.Controllers
{
    public class TicketBookingController : Controller
    {
        Model3 db = new Model3();

        // GET: TicketBooking
        public ActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Payment([Bind(Include = "TicketDay,AvailableSeatCount")] TicketBooking ticketDetail)
        {
            if (ModelState.IsValid)
            {
                //All transaction and email
                db.TicketBookings.Add(ticketDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ticketDetail);
        }

    }
}