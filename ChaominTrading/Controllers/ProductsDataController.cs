using DotWeb.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class ProductsDataController : WebUserController
    {
        public ActionResult Index()
        {
            return View("ProductsData_List");
        }
        public ActionResult List()
        {
            return View("ProductsData_List");
        }
        public ActionResult Content()
        {
            return View("ProductsData_Content");
        }
    }
}