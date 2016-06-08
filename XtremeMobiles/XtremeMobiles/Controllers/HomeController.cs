using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XtremeMobiles.Models;

namespace XtremeMobiles.Controllers
{
    public class HomeController : Controller
    {
        IBrand brand;
        public HomeController(IBrand b)
        {
            brand = b;
        }
        public ActionResult Index()
        {
            return View(brand.getLatestProducts());
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
        public ActionResult Other()
        {
            ViewBag.Message = "Privacy and Terms Of use.";

            return View();
        }
        public ActionResult Latest()
        {
            ViewBag.Message = "Latest Phones.";

            return View();
        }
        
    }
}