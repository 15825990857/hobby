using hobby.Data.Redis;
using hobby.Service.IBLL;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hobby.web.Controllers
{
    public class HomeController : Controller
    {
      public IUserService _userService { get; set; }
        public ActionResult Index()
        {
             //RedisManager redis = new RedisManager();
             //CacheManager cache = new CacheManager();
            //redis.Insert("user","ygs");
            //cache.Insert("user","木椅子按");
            //var userR = redis.Get("user");
            //var userC = cache.Get("user");
            // _userService.Login("ygs","1234567");
            
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

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            base.OnActionExecuting(filterContext);
        }

      
    }
}