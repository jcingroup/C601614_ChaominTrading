using DotWeb.Controller;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class NewsController : WebUserController
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