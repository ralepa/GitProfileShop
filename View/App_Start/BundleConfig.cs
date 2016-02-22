using System.Web.Optimization;

namespace View
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/lib/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/react").Include(
                        "~/lib/react/react.min.js",
                        "~/lib/react/react-dom.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/lib/jquery/jquery.validate*"));
            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/lib/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/lib/bootstrap/bootstrap.js",
                      "~/lib/respond/respond.js"));

            bundles.Add(new StyleBundle("~/style/css").Include(
                      "~/lib/bootstrap/bootstrap.css",
                      "~/style/main.css"));
        }
    }
}
