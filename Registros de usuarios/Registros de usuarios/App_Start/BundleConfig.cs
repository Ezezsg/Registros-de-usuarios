using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Registros_de_usuarios.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryvalunobtrusive").Include(
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/contacto-modal-ynnova").Include("~/Scripts/js-contacto-modal-ynnova.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/Style.css"));
        }
    }
}