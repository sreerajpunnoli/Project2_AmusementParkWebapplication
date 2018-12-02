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
    }
}