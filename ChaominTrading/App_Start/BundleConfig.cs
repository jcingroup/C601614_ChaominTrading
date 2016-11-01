using System.Web;
using System.Web.Optimization;

namespace ChaominTrading
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //開啟 CDN
            bundles.UseCdn = true;
            //設定 CDN 目錄
            var jqueryCdnPath = "http://code.jquery.com/jquery-latest.min.js";
            //優先載入 CDN 位置，如 CDN 失效將使用本機位置提供資源
            bundles.Add(new ScriptBundle("~/bundles/jquery",
                        jqueryCdnPath).Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/js/common.js",
                      "~/Content/js/tab.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/css/vendor/icomoon.css",
                      "~/Content/css/grid.css",
                      "~/Content/css/page.css"));
        }
    }
}
