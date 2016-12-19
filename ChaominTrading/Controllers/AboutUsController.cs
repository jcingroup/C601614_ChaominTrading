using DotWeb.Controller;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class AboutUsController : WebUserController
    {
        public ActionResult Index()
        {
            return View("AboutUs");
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}