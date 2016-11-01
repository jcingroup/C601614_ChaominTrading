using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class AboutUsController : Controller
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