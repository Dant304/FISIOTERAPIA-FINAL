using System.Web;
using System.Web.Optimization;

namespace FECprojeto
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
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                         "~/Scripts/angular.js",
                         "~/Scripts/angular-route.js"));

            //Meus arquivos CSS no BundlesConfig - Para otimizar o sistema
            bundles.Add(new StyleBundle("~/CSS/Inicio").Include(
                "~/Content/Inicio/config.css"
               ));

            bundles.Add(new StyleBundle("~/CSS/TelaDanielFisioterapeuta").Include("~/Content/TelaDanielFisioterapeuta/style.css",
                "~/Content/TelaDanielFisioterapeuta/index.css",
                "~/Content/TelaDanielFisioterapeuta/inicial.css",
                 "~/Content/TelaDanielFisioterapeuta/inicial.css",
                 "~/Content/TelaDanielFisioterapeuta/adm.css"));

            bundles.Add(new StyleBundle("~/CSS/TelaProfissional").Include("~/Content/TelaProfissional/index.css",
                 "~/Content/TelaProfissional/style.css"));

            bundles.Add(new StyleBundle("~/CSS/TelaDanielLogin").Include("~/Content/TelaDanielLogin/index.css",
                "~/Content/TelaDanielLogin/style.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                                "~/Content/bootstrap.css",
                                "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/CSS/modalCSS").Include("~/Content/Modal/component.css", "~/Content/Modal/default.css"));
            //Meus arquivos JS no bundleConfig
            bundles.Add(new ScriptBundle("~/JS/TelaDanielLoginjs").Include("~/Scripts/TelaDanielLogin/index.js"));
            bundles.Add(new ScriptBundle("~/JS/TelaDanielFisioterapeuta").Include("~/Scripts/TelaDanielFisioterapeuta/inicial.js"));
            bundles.Add(new ScriptBundle("~/JS/Inicio").Include("~/Scripts/Inicio/ListarProfissionais.js", "~/Scripts/Inicio/config.js" ,"~/Scripts/Inicio/JQueryBlockUI.js"));
            bundles.Add(new ScriptBundle("~/JS/modalJS").Include("~/Scripts/Adm/classie.js", "~/Scripts/Adm/css-filters-polyfill.js", "~/Scripts/Adm/cssParser.js", "~/Scripts/Adm/modalEffects.js"));

        }
    }
}
