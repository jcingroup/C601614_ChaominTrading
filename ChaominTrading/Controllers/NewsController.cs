using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class NewsController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("list");
        }
        public ActionResult list()
        {
            return View();
        }
        public ActionResult content()
        {
            return View();
        }
    }
}