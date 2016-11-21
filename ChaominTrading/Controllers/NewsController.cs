using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class NewsController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("News");
        }
        public ActionResult News()
        {
            return View();
        }
    }
}