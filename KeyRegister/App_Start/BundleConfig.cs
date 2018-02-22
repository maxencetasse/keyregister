using System.Web;
using System.Web.Optimization;

namespace KeyRegister
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"
            ));
            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"
            ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"
            ));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                //"~/Content/bootstrap.css",
                //"~/Content/site.css",
                "~/Content/style.css"
            ));
            
            bundles.Add(new StyleBundle("~/Content/adminTheme").IncludeDirectory(
                "~/Content/startbootstrap-sb-admin-2-gh-pages",
                "*.css",
                true
            ));

            bundles.Add(new ScriptBundle("~/Content/js").IncludeDirectory(
                "~/Content/startbootstrap-sb-admin-2-gh-pages",
                "*.js",
                true
            ));
        }
    }
}
