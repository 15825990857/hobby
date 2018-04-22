using hobby.Common;
using hobby.Core;
using hobby.Core.Model;
using hobby.Data.DataHelp;
using hobby.Data.LogNet;
using hobby.Service.BLL;
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
        public IUserService _userService;
        public LoginController()
        {
            _userService = new UserService();
        }
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginIn(string name,string pwd)
        {
            pwd = Encrypt.EncryptMD5By32(pwd);
           var model= _userService.Login(name,pwd);
            ResultInfo info = new ResultInfo();
            if (model == null)
            {
                info.status = 0;
                info.message = "用户名或密码错误";
                info.data = null;
            }
            else
            {
                info.status = 1;
                info.message = "登陆成功";
                info.data = model;
            }
            return Json(info,JsonRequestBehavior.AllowGet);
        }
    }
}