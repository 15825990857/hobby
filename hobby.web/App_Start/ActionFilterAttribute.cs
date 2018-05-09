using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hobby.web.App_Start
{
    public class ActionFilterAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}