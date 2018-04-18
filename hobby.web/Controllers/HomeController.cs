using hobby.Data.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hobby.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
             RedisManager redis = new RedisManager();
             redis.Insert("user","ygs");
            var userG = redis.Get("user");
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