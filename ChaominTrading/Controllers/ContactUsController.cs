using DotWeb.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class ContactUsController : WebUserController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("ContactUs");
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}