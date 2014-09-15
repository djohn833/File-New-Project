using System.Web;
using System.Web.Optimization;
using PaladinCloudware.Helpers;

namespace GSPNewProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region Scripts

            bundles.Add(new ScriptBundle(JSBundles.Scripts).Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle(JSBundles.Validate).Include(
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/bootstrap.validate.js"));

            bundles.Add(new ScriptBundle(JSBundles.DateTimePicker).Include(
                "~/Scripts/moment.js",
                "~/Scripts/bootstrap-datetimepicker.js"
                ));


            #endregion

            #region CSS

            bundles.Add(new StyleBundle(CSSBundles.CSS).Include(
                "~/Content/site.css"));

            #endregion
        }
    }
}

namespace PaladinCloudware.Helpers
{
    public class JSBundles
    {
        public static string Scripts = "~/bundles/scripts";
        public static string Validate = "~/bundles/validate";
        public static string DateTimePicker = "~/bundles/datetimepicker";
    }

    public class CSSBundles
    {
        public static string CSS = "~/Content/css";
    }
}