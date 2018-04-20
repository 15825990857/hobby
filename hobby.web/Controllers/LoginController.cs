using hobby.Data.LogNet;
using hobby.Service.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hobby.web.Controllers
{
    public class LoginController : Controller
    {
        public IUserService userService;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoginIn(string name,string pwd)
        {
           var model= userService.Login(name,pwd);
            if (model == null)
            {

            }
            return Json(model,JsonRequestBehavior.AllowGet);
        }
    }
}