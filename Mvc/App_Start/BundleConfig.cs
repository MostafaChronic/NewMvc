using System.Web;
using System.Web.Optimization;

namespace Kala_be_Kala
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/Ajaxform").Include(
                "~/Scripts/jquery.ajaxform.js",
                "~/Scripts/jquery.form.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            
    //<link href="@Url.Content("~/Content/Style/base.css")" rel="stylesheet" />
    //<link href="@Url.Content("~/Content/Style/form.css")" rel="stylesheet" />

    //<link href="@Url.Content("~/Content/Style/overlay.css")" rel="stylesheet" />
    //<!--Css Plugin Files-->
    //<link href="@Url.Content("~/Content/Style/onepcssgrid.css")" rel="stylesheet" />
    //<!--    <link href="@Url.Content("~/Content/Style/perfect-scrollbar.min.css")" rel="stylesheet" /> -->
    //<link href="@Url.Content("~/Content/Style/MaterialIcons.css")" rel="stylesheet" />
    //<link href="@Url.Content("~/Content/Style/pe-icon-7-stroke.css")" rel="stylesheet" />

            bundles.Add(new StyleBundle("~/AdminPanel/css").Include(
                      "~/Content/Style/base.css",
                      "~/Content/Style/overlay.css",
                     "~/Content/Style/form.css" ,
                      "~/Content/Style/onepcssgrid.css",
                      "~/Content/Style/MaterialIcons.css",
                      "~/Content/Style/pe-icon-7-stroke.css"
                      ));
        }
    }
}
