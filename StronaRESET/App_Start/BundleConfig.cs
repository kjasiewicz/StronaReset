using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StronaRESET.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                         "~/Scripts/jquery-{version}.js",
                         "~/Scripts/bootstrap.js",
                         "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include("~/Content/bootstrap.min.css", 
                "~/Content/bootstrap-theme.css", 
                "~/Content/main.min.css", 
                "~/Content/FontAwesome/font-awesome.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}