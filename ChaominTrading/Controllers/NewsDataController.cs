using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class NewsDataController : Controller
    {
        public ActionResult Index()
        {
            return View("NewsData_List");
        }
        public ActionResult List()
        {
            return View("NewsData_List");
        }
        public ActionResult Content()
        {
            return View("NewsData_Content");
        }
    }
}