using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectNew.Models;

namespace ProjectNew.Controllers
{
    public class TicketDetailsController : Controller
    {
        private Model2 db = new Model2();

        // GET: TicketDetails
        public ActionResult Index()
        {
            return View(db.TicketDetails.ToList());
        }

        // GET: TicketDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketDetail ticketDetail = db.TicketDetails.Find(id);
            if (ticketDetail == null)
            {
                return HttpNotFound();
            }
            return View(ticketDetail);
        }

        // GET: TicketDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TicketDay,AvailableSeatCount")] TicketDetail ticketDetail)
        {
            if (ModelState.IsValid)
            {
                db.TicketDetails.Add(ticketDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ticketDetail);
        }

        // GET: TicketDetails/Edit/5
        /*public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketDetail ticketDetail = db.TicketDetails.Find(id);
            if (ticketDetail == null)
            {
                return HttpNotFound();
            }
            return View(ticketDetail);
        }*/

        // POST: TicketDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TicketDay,AvailableSeatCount")] TicketDetail ticketDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ticketDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ticketDetail);
        }
        
        // GET: TicketDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TicketDetail ticketDetail = db.TicketDetails.Find(id);
            if (ticketDetail == null)
            {
                return HttpNotFound();
            }
            return View(ticketDetail);
        }

        // POST: TicketDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TicketDetail ticketDetail = db.TicketDetails.Find(id);
            db.TicketDetails.Remove(ticketDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }*/

        public ActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Booking([Bind(Include = "TicketDay,AvailableSeatCount")] TicketDetail ticketDetail)
        {
            if (ModelState.IsValid)
            {
                ///TODO: update the count in db

                /*int amount = 0;
                if (TicketDetail.TicketDay.DayOfWeek == DayOfWeek.Saturday || TicketDetail.TicketDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    amount = TicketDetail.TicketSeats.Value * 12;
                }
                else
                {
                    amount = TicketDetail.TicketSeats.Value * 10;
                }
                String userId = Session["userId"].ToString();
                // DateTime.Today;
                db.TicketDetails.Add(TicketDetail);
                db.SaveChanges();
                */
                return RedirectToAction("../Home/Index");
            }

            return View(ticketDetail);
        }
    }
}
