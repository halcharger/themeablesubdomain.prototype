using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThemeableSubdomains.Prototype.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var url = Request.Url;
            if (url.HostNameType == UriHostNameType.Dns)
            {

                string host = url.Host;

                var nodes = host.ToLower().Split('.').ToList();
                if (nodes.Contains("www")) nodes.Remove("www");

                ViewBag.Subdomain = nodes.Count > 1 ? nodes[0] : "no sub domain";

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}