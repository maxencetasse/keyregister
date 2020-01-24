using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace KeyRegister
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory(
                "~/Theme/css",
                "*.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate*",
                "~/Scripts/modernizr-*",
                "~/Scripts/respond.js",

                //BOOTSTRAP 
                "~/Theme/js/bootstrap.min.js",
                "~/Theme/js/metisMenu.min.js",
                "~/Theme/js/sb-admin-2.min.js"
            ));
        }
    }
}
