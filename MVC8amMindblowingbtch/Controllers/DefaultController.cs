using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amMindblowingbtch.Models;
namespace MVC8amMindblowingbtch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult PartialViewExample() {
            StudentModel std = new Models.StudentModel();
            std.StudId = 1;
            std.StudName = "Hari";
            std.StudFees = 1000;
            std.StudCourse = "Java";

            return View(std);
        }
        public PartialViewResult getPartialView()
        {
            StudentModel std = new Models.StudentModel();
            std.StudId = 1;
            std.StudName = "Hari";
            std.StudFees = 1000;
            std.StudCourse = "Java";

            

            return PartialView("_MyPartialView", std);
        }

        public RedirectResult GoToYahoo() {

            return Redirect("http://www.yahoo.com");
        }

        public RedirectResult GoTolocalYahoo()
        {

            return Redirect("~/Default/localYahoo");
        }

        public ViewResult localYahoo()
        {
            return View();
        }

        public FileResult OpenFile() {

            return File("~/Web.config","application/xml", "Web.config");

        }
    }
}