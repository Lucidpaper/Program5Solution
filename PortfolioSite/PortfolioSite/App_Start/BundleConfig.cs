using System;
using System.Web;
using System.Web.Optimization;

namespace PortfolioSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/css/site.css"));
        }
    }
}