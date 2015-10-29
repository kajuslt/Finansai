﻿using System.Web;
using System.Web.Optimization;

namespace Finanasai
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

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
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // The Kendo JavaScript bundle
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                    "~/Scripts/kendo/kendo.all.min.js", // or kendo.all.* if you want to use Kendo UI Web and Kendo UI DataViz
                    "~/Scripts/kendo/kendo.aspnetmvc.min.js"));


            // The Kendo CSS bundle
            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                    "~/Content/kendo/kendo.common.min.css",
                    "~/Content/kendo/kendo.default.min.css"));

            // Clear all items from the default ignore list to allow minified CSS and JavaScript files to be included in debug mode
            bundles.IgnoreList.Clear();
        }
    }
}