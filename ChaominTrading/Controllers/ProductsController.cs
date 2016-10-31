using System.Web.Mvc;
using DotWeb.Controller;

namespace DotWeb.WebApp.Controllers
{
    public class ProductsController : WebUserController
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