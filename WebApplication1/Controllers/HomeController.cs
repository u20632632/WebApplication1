using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase files,string value)
        {

            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}