using Autofac;
using Autofac.Integration.Mvc;
using hobby.web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace hobby.web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            init();
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<HomeController>().InstancePerRequest();
             
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            //获取到HttpUnhandledException异常，这个异常包含一个实际出现的异常  
            Exception ex = Server.GetLastError();
            //实际发生的异常  
            Exception iex = ex.InnerException;

            string errorMsg = String.Empty;
            string particular = String.Empty;
            if (iex != null)
            {
                errorMsg = iex.Message;
                particular = iex.StackTrace;
            }
            else
            {
                errorMsg = ex.Message;
                particular = ex.StackTrace;
            }
            //HttpContext.Current.Response.Write("来自Global的错误处理<br />");  
            //HttpContext.Current.Response.Write(errorMsg);  
            //写日志  
            string filePath = string.Format("~/Log/Error/{0}/", new object[] { DateTime.Now.ToString("yyyy-MM") });
            //LogManager.SaveLog(Server.MapPath(filePath), errorMsg);
            Server.ClearError();//处理完及时清理异常  
            int stateCode = (ex is HttpException) ? (ex as HttpException).GetHttpCode() : 500;
            switch (stateCode)
            {
                case 404:
                    Response.Redirect("/NotFound.html");
                    break;
                default:
                    Response.Redirect("/Error.html");
                    break;
            }
        }
    }
}
