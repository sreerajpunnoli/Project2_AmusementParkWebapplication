using ProjectNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectNew.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(ProjectNew.Models.UserAccount userModel)
        {
            using (Model1 db = new Model1())
            {
                UserAccount userDetails = db.UserAccounts.Where(x => x.Name == userModel.Name && x.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "wrong username or Password.";
                    return View("Index", userModel);
                }
                else
                {
                    Session["Id"] = userDetails.Id;
                    Session["Name"] = userDetails.Name;
                    return RedirectToAction("Index", "Home");
                }
            }

        }
        public ActionResult LogOut()
        {
            int userId = (int)Session["Id"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }

}
