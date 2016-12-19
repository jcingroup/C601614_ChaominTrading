using DotWeb.Controller;
using System.Web.Mvc;

namespace ChaominTrading.Controllers
{
    public class ProductsController : WebUserController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Export_list");
        }
        // 以下為程式用
        public ActionResult list()
        {
            return View();
        }
        public ActionResult content()
        {
            return View();
        }

        // 以下為demo用
        // 進口
        public ActionResult Import_list()
        {
            return View();
        }
        public ActionResult Import1()
        {
            return View();
        }
        public ActionResult Import2()
        {
            return View();
        }
        public ActionResult Import3()
        {
            return View();
        }
        // 出口
        public ActionResult Export_list()
        {
            return View();
        }
        public ActionResult Export1()
        {
            return View();
        }
        public ActionResult Export2()
        {
            return View();
        }
        public ActionResult Export3()
        {
            return View();
        }
        public ActionResult Export4()
        {
            return View();
        }
        public ActionResult Export5()
        {
            return View();
        }
    }
}