using System.Web;
using System.Web.Optimization;

namespace ShoeStoreTeam
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js", "~/Content/Admin/js/jquery2.0.3.min.js", "~/Content/Admin/js/raphael-min.js", "~/Content/Admin/js/morris.js"
                        , "~/Content/Admin/js/jquery.dcjqaccordion.2.7.js", "~/Content/Admin/js/script.js", "~/Content/Admin/js/jquery.nicescroll.js", "~/Content/Admin/jsjquery.scrollTo.js",
                        "~/Content/Admin/js/jquery.slimscroll.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Admin/css/bootstrap.min.css", "~/Content/Admin/css/font-awesome.css", "~/Content/Admin/css/font.css", "~/Content/Admin/css/jqvmap.css", "~/Content/Admin/css/lightbox.css", "~/Content/Admin/css/minimal.css",
                      "~/Content/Admin/css/monthly.css", "~/Content/Admin/css/morris.css", "~/Content/Admin/css/style.css", "~/Content/Admin/css/style-responsive.css", "~/Content/Site.css", "~/Content/boostrap.css"));
        }
    }
}
