using DotWeb.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class BaseController : WebUserController
    {
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult ChangePW()
        {
            return View("ChangePW");
        }
    }
}