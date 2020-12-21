using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amMindblowingbtch.Filter
{
   
    public class MyFilter  :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
          
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
           
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
           
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            (filterContext.Result as ViewResult).ViewBag.Employee = "Arjun";
        }
    }
}