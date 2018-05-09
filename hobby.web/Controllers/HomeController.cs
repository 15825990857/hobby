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

            //Sname = "你来了";
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

        //static string Sname;
        //static HomeController()
        //{
        //    timer();
        //}

        /////// <summary>
        /////// 定时器
        /////// </summary>
        ////private static void timer()
        ////{
        ////    System.Timers.Timer t = new System.Timers.Timer(60);//实例化Timer类，设置间隔时间为10000毫秒；
        ////    t.Elapsed += new System.Timers.ElapsedEventHandler(Theout);//到达时间的时候执行事件；
        ////    t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；
        ////    t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
        ////}

        /////// <summary>
        /////// 实行事件
        /////// </summary>
        /////// <param name="source"></param>
        /////// <param name="e"></param>
        ////public static void Theout(object source, System.Timers.ElapsedEventArgs e)
        ////{
        ////    Sname = "";
        ////}
    }
}