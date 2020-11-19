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
        public JsonResult getJsonData() {


            List<StudentModel> listobj = new List<StudentModel>();


            StudentModel st = new StudentModel();

            st.StudId = 1;
            st.StudName = "Arjun";
            st.StudCourse = "MVC";
            st.StudFees = 10000;
            st.DeptId = 1;

            StudentModel st1 = new StudentModel();

            st1.StudId = 2;
            st1.StudName = "umesh";
            st1.StudCourse = "java";
            st1.StudFees = 30000;
            st1.DeptId = 2;


            StudentModel st2 = new StudentModel();

            st2.StudId = 3;
            st2.StudName = "Sai";
            st2.StudCourse = "Angular";
            st2.StudFees = 20000;
            st2.DeptId = 3;


            listobj.Add(st);
            listobj.Add(st1);
            listobj.Add(st2);


            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "CSE";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 3;
            dept2.DeptName = "ECE";

            List<DepartmentModel> deptObj = new List<Models.DepartmentModel>();
            deptObj.Add(dept);
            deptObj.Add(dept1);
            deptObj.Add(dept2);

            StudentDept studentDpartObj = new Models.StudentDept();
            studentDpartObj.students = listobj;
            studentDpartObj.departments = deptObj;

            return Json(studentDpartObj,JsonRequestBehavior.AllowGet);
        }
        public RedirectToRouteResult GotoMethod() {

            return RedirectToAction("getJsonData");
        }

        public RedirectToRouteResult GotoAnCtrlMethod()
        {

            return RedirectToAction("getAllStudentByDeptVModel", "New");
        }

        public RedirectToRouteResult GotoCtrlMethod()
        {
            StudentModel st = new StudentModel();
            st.StudId = 3;
            st.StudName = "Sai";
            st.StudCourse = "Angular";
            st.StudFees = 20000;
            st.DeptId = 3;

            return RedirectToAction("ShowData",st);
        }

        public ViewResult ShowData(StudentModel st)
        {
            return View();
        }

        public RedirectToRouteResult GoOnUsingRoute() {

            return RedirectToRoute("Bakery");
        }

        public ActionResult Biscuit() {

            return View();
        }

        public ContentResult getContent(int ? id)
        {
            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id==2)
            {
                return Content("<p style=color:red>Hello World</p>");
            }
            else
            {
                return Content("<script>alert('Hello World')</script>");
            }

        }

        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}