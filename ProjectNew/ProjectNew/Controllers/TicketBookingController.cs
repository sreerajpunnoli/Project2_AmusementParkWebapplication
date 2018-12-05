using ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace ProjectNew.Controllers
{
    public class TicketBookingController : Controller
    {
        Model3 db3 = new Model3();

        Model2 db2 = new Model2();

        Model1 db1 = new Model1();

        // GET: TicketBooking
        public ActionResult Payment()
        {
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Payment([Bind(Include = "CardNumber,NameOnCard,ExpiryDate")] CardDetails card)
        {
            if (ModelState.IsValid)
            {
                int userId = (int) Session["UserId"];

                int? bookingId = db3.TicketBookings.Max(t => (int?) t.Id);
                if (bookingId == null)
                {
                    bookingId = 1;
                }

                TransactionReference.Transaction trxn = new TransactionReference.Transaction
                {
                    id = bookingId,
                    quantity = (int)Session["TicketCount"],
                    expDate = card.ExpiryDate,
                    cardNo = card.CardNumber,
                    nameOnCard = card.NameOnCard
                };

                object ticketDay = Session["TicketDay"];
                // Entry Fee: 10 CAD for weekdays and 12 CAD for weekends
                if (ticketDay != null && (((DateTime) ticketDay).DayOfWeek == DayOfWeek.Saturday ||
                        ((DateTime) ticketDay).DayOfWeek == DayOfWeek.Sunday))
                { 
                    trxn.unitPrice = 12;
                } else
                {
                    trxn.unitPrice = 10;
                }

                TransactionReference.TransactionWebserviceImplClient trxnClient = new TransactionReference.TransactionWebserviceImplClient();
                trxnClient.Endpoint.Address = new EndpointAddress("http://dev.cs.smu.ca:9090/Assignment3/services/TransactionWebserviceImpl");

                bool success = trxnClient.createTransaction(trxn);
                if (success)
                {
                    TicketBooking ticketBooking = new TicketBooking
                    {
                        Id = (int)bookingId,
                        BookedTicketDate = (DateTime)ticketDay,
                        UserId = userId,
                        SeatsCount = (int)Session["TicketCount"],
                        TransactionId = (int)bookingId
                    };

                    db3.TicketBookings.Add(ticketBooking);
                    db3.SaveChanges();

                    //TransactionReference.Transaction transaction = trxnClient.getTransaction((int)bookingId);
                    //SendEmailToCust(userId, transaction);
                    SendEmailToCust(userId, trxn.id, trxn.unitPrice* trxn.quantity);

                    Response.Write("<script>alert('Ticket/s Booked Successfully and Email Notification Sent!')</script>");
                    return RedirectToAction("../TicketDetails/Booking");
                }

                Response.Write("<script>alert('Unsuccessful Payment!')</script>");
                return RedirectToAction("../TicketBooking/Payment");
            }

            return View();
        }
        
        //public JsonResult SendEmailToCust(int userId, TransactionReference.Transaction transaction)
        public JsonResult SendEmailToCust(int userId, int? trxnId, float? price)
        {
            UserAccount user = db1.UserAccounts.Find(userId);
            bool Result = SendEmail(user.Email, "Halifax Amusement Park Booking Confirmation", "<p>Booking Confirmed! <br /><br/ >Details:Transaction Id:"+ trxnId + "<br />Total Price:"+ price+ "</p>");
            //bool Result = SendEmail(user.Email, "Halifax Amusement Park Booking Confirmation", "<p>Booking Confirmed! <br /><br/ >Details:[Transaction Id:1<br />Total Price:20]</p>");
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