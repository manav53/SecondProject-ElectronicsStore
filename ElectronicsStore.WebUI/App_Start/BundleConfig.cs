﻿using System.Web;
using System.Web.Optimization;

namespace ElectronicsStore.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include("~/Scripts/jquery-3.7.0.js", "~/Scripts/umd/popper.js", "~/Scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/Styles/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Styles/site").Include("~/Content/Styles.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
