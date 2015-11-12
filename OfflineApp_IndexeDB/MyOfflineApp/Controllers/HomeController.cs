using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyOfflineApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Offline()
        {
           return View();
        }
        public ActionResult Manifest()
        {
            var manifest = "CACHE MANIFEST" + Environment.NewLine +
                  "# App Version: 1.0.9" + System.IO.File.GetLastWriteTime(Server.MapPath("~/Views/Home/Offline.cshtml")) + Environment.NewLine +
                  "# Server Assembly Version: " + this.GetType().Assembly.GetName().Version + Environment.NewLine +
                  "NETWORK:" + Environment.NewLine +
                  "*" + Environment.NewLine +
                  "CACHE:" + Environment.NewLine +
                  Url.Action("Offline", "Home") + Environment.NewLine +
                  Url.Content("~/Content/site.css") + Environment.NewLine +
                  Url.Content("~/Content/jquery-ui.css") + Environment.NewLine +
                  Url.Content("~/Scripts/jquery.min.js") + Environment.NewLine +
                  Url.Content("~/Scripts/jquery-ui.min.js") + Environment.NewLine +
                  Url.Content("~/Scripts/modernizr-2.6.2.js") + Environment.NewLine +
                  Url.Content("~/Scripts/IndexedDBShim.js") + Environment.NewLine +
                  Url.Content("~/Scripts/Linq2IndexedDB.js") + Environment.NewLine +
                  Url.Content("~/Scripts/dbOperations.js") + Environment.NewLine +
                  Url.Content("~/Scripts/jquery.blockUI.js") + Environment.NewLine +
                  Url.Content("~/Scripts/cache.js") + Environment.NewLine;

            return Content(manifest, "text/cache-manifest");
        }
    }
}
