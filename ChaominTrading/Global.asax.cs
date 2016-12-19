using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.WebPages;

namespace ChaominTrading
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            string VarCookie = "ChaominTrading";
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("zh-TW")
            { //使用狀況條件為 Cookies值 或 QueryString["lang"]
                ContextCondition = (C =>
                (
                C.Request.Cookies[VarCookie + ".Lang"] != null &&
                C.Request.Cookies[VarCookie + ".Lang"].Value.Contains("zh-TW") &&
                string.IsNullOrEmpty(C.Request.QueryString["lang"])
                ) ||
                C.Request.QueryString["lang"] == "zh-TW"
                )
            });
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("ja-JP")
            { //使用狀況條件為 Cookies值 或 QueryString["lang"]
                ContextCondition = (C =>
                (
                C.Request.Cookies[VarCookie + ".Lang"] != null &&
                C.Request.Cookies[VarCookie + ".Lang"].Value.Contains("ja-JP") &&
                string.IsNullOrEmpty(C.Request.QueryString["lang"])
                ) ||
                C.Request.QueryString["lang"] == "ja-JP"
    )
            });
        }
    }
}
