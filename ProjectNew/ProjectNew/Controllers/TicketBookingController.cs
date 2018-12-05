using ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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
        
        public JsonResult SendEmailToCust()
        {
            bool Result = false;
            Result = SendEmail("shahzan.magray@gmail.com", "Hi", "<p>Hi Shahzan<br />Hi watsaup</p>");
            return Json(Result, JsonRequestBehavior.AllowGet);
        }
        public bool SendEmail(string toEmail, string Subject, string Body)
        {
            try
            {
                string senderEmail = System.Configuration.ConfigurationManager.AppSettings["SenderEmail"].ToString();
                string senderPassword = System.Configuration.ConfigurationManager.AppSettings["SenderPassword"].ToString();


                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage mm = new MailMessage(senderEmail, toEmail, Subject, Body);
                mm.IsBodyHtml = true;
                mm.BodyEncoding = UTF8Encoding.UTF8;
                client.Send(mm);



                return true;
            }
            catch (Exception e)
            {
                e.GetBaseException();

                return false;
            }
        }
    }
}