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

        public JsonResult SaveData(UserAccount model)
        {
            db.UserAccounts.Add(model);
            db.SaveChanges();
            return Json("Registration Successful", JsonRequestBehavior.AllowGet);
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
            UserAccount userDetails = db.UserAccounts.Where(x => x.Name == userModel.Name && x.Password == userModel.Password).FirstOrDefault();
            if (userDetails == null)
            {
                userModel.LoginErrorMessage = "wrong username or Password.";
                return View("SignIn", userModel);
            }
            else
            {
                Session["Id"] = userDetails.Id;
                Session["Name"] = userDetails.Name;
                //change to booking
                return RedirectToAction("Booking", "TicketDetails");
            }
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["Id"];
            Session.Abandon();
            return RedirectToAction("SignIn", "Registration");
        }
    }
}