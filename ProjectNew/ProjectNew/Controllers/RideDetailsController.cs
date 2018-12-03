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
    public class RideDetailsController : Controller
    {
        private Model2 db = new Model2();

        // GET: RideDetails
        public ActionResult Index()
        {
            return View(db.RideDetails.ToList());
        }

        // GET: RideDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RideDetail rideDetail = db.RideDetails.Find(id);
            if (rideDetail == null)
            {
                return HttpNotFound();
            }
            return View(rideDetail);
        }

        // GET: RideDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RideDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RideDay,RideSeats")] RideDetail rideDetail)
        {
            if (ModelState.IsValid)
            {
                db.RideDetails.Add(rideDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rideDetail);
        }

        // GET: RideDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RideDetail rideDetail = db.RideDetails.Find(id);
            if (rideDetail == null)
            {
                return HttpNotFound();
            }
            return View(rideDetail);
        }

        // POST: RideDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RideDay,RideSeats")] RideDetail rideDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rideDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rideDetail);
        }

        // GET: RideDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RideDetail rideDetail = db.RideDetails.Find(id);
            if (rideDetail == null)
            {
                return HttpNotFound();
            }
            return View(rideDetail);
        }

        // POST: RideDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RideDetail rideDetail = db.RideDetails.Find(id);
            db.RideDetails.Remove(rideDetail);
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
