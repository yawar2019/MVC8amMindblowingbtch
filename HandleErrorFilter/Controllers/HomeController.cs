using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorFilter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
      
        public ActionResult GetResult(string id)
        {
            try
            {

                int b = Convert.ToInt32(id);
                ViewBag.info = b;
                return View();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}