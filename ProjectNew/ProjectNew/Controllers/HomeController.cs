using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectNew.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ServiceReference1.getTransactionRequest getTransaction = new ServiceReference1.getTransactionRequest();
            
            return View();
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your Gallery page.";

            return View();
        }
    }
}