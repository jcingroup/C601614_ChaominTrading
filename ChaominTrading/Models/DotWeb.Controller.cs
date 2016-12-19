using System.Web;
using System.Web.Mvc;

namespace DotWeb.Controller
{
    #region 基底控制器
    public abstract class WebUserController : System.Web.Mvc.Controller
    {
        protected string WebCookiesId = "ChaominTrading";
        public RedirectResult SetLanguage(string L, string A)
        {
            HttpCookie WebLang = new HttpCookie(WebCookiesId + ".Lang", L);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(WebLang.Value);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(WebLang.Value);
            ViewBag.Lang = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            Response.Cookies.Add(WebLang);
            return Redirect(A);
        }
    }
    #endregion

}