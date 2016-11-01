using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class ProductsController : Controller
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
        // 以下為demo用
        public ActionResult Import_list()
        {
            return View();
        }
        public ActionResult Export_list()
        {
            return View();
        }
    }
}