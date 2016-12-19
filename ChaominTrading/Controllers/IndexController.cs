﻿using DotWeb.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class IndexController : WebUserController
    {
        public ActionResult Index()
        {
            return View();
        }
        public RedirectResult Login()
        {
            return Redirect("~/Base/Index");
        }
    }
}