using System.Web;
using System.Web.Optimization;

namespace TestChutzpahWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/components/jquery/dist/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Content/components/angular/angular.js",
                        "~/Content/components/angular-route/angular-route.js",
                        "~/Content/Components/angular-google-analytics/dist/angular-google-analytics.js",
                        "~/Scripts/angular-busy.js"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/components/bootstrap/dist/css/bootstrap.css"
                ));

            bundles.Add(new StyleBundle("~/content/fontawesome").Include(
                "~/Content/components/fontawesome/css/font-awesome.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Content/components/bootstrap/dist/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Content/angular-busy.css"));
        }
    }
}
