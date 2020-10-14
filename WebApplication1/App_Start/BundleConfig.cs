using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Teste").IncludeDirectory("~/Scripts/Teste", "*.js", true));
            var ordem = new BundleFileSetOrdering("ordemTeste");
            ordem.Files.Add("teste.js");
            ordem.Files.Add("Exibir.js");
            bundles.FileSetOrderList.Insert(0, ordem);

            bundles.UseCdn = true;
            var jqueryCdnpath = "https://code.jquery.com/jquery-3.5.1.js";
            bundles.Add(new ScriptBundle("~/bundles/jquery",jqueryCdnpath).Include("~/Scripts/Jquery-{version}.js"));

            //defini o link do jquery

            /*bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));*/

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqcolor").Include("~/Scripts/jquery.color*"));
        }
    }
}
