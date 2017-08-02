using System.Web;
using System.Web.Optimization;

namespace RecruitmentWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //site scripts - css
            bundles.Add(new StyleBundle("~/Content/custom/default/css").Include(
                        "~/App_Themes/Default/Default.css"));

            bundles.Add(new StyleBundle("~/Content/custom/green/css").Include(
                        "~/App_Themes/green/Default.css"));

            bundles.Add(new StyleBundle("~/Content/custom/red/css").Include(
                        "~/App_Themes/red/Default.css"));

            //site scripts - js
            bundles.Add(new ScriptBundle("~/bundles/site-scripts").Include(
          "~/Scripts/site.js"));
        }
    }
}
