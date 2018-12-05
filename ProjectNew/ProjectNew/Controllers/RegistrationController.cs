using ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectNew.Controllers
{
    public class RegistrationController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(ProjectNew.Models.UserAccount model)
        {
            UserAccount user = db.UserAccounts.SingleOrDefault(x => x.Email == model.Email);
            if (user == null)
            {
                db.UserAccounts.Add(model);
                try {
                    db.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }

                Response.Write("<script>alert('Sign Up successfully')</script>");
                return View("SignUp");
            }
            Response.Write("<script>alert('User already exists ')</script>");
            return View("SignUp");

            
        }

        public ActionResult SignUp()
        {
            return View();
        }


        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(ProjectNew.Models.UserAccount userModel)
        {
            UserAccount userDetails = db.UserAccounts.Where(x => x.Email == userModel.Email && x.Password == userModel.Password).FirstOrDefault();
            if (userDetails == null)
            {
                //userModel.LoginErrorMessage = "wrong username or Password.";
                return View("SignIn", userModel);
            }
            else
            {
                Session["UserId"] = userDetails.Id;
                //change to booking
                return RedirectToAction("Booking", "TicketDetails");
            }
        }

        public ActionResult LogOut()
        {
            int userId = (int) Session["UserId"];
            Session.Abandon();
            return RedirectToAction("SignIn", "Registration");
        }
    }
}