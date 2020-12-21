using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC8amMindblowingbtch.Models;
using MVC8amMindblowingbtch.Filter;

namespace MVC8amMindblowingbtch.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        [NonAction]
        public string getName() {

            return "hi";
        }

        public ActionResult GetMyView()
        {
       

            return View();
        }

        public ViewResult SendData()
        {
            List<StudentModel> listobj = new List<StudentModel>();
             

            StudentModel st = new StudentModel();

            st.StudId = 1;
            st.StudName = "Arjun";
            st.StudCourse = "MVC";
            st.StudFees = 10000;

            StudentModel st1 = new StudentModel();

            st1.StudId = 2;
            st1.StudName = "umesh";
            st1.StudCourse = "java";
            st1.StudFees = 30000;

            StudentModel st2 = new StudentModel();

            st2.StudId = 3;
            st2.StudName = "Sai";
            st2.StudCourse = "Angular";
            st2.StudFees = 20000;

            listobj.Add(st);
            listobj.Add(st1);
            listobj.Add(st2);


            ViewBag.StudentDetail = listobj;

            return View();
        }

        public ActionResult getStudentVModel()
        {
            StudentModel st = new StudentModel();
            st.StudId = 1;
            st.StudName = "Arjun";
            st.StudCourse = "MVC";
            st.StudFees = 10000;
            return View(st);
        }

        public ActionResult getAllStudentVModel()
        {
            List<StudentModel> listobj = new List<StudentModel>();


            StudentModel st = new StudentModel();

            st.StudId = 1;
            st.StudName = "Arjun";
            st.StudCourse = "MVC";
            st.StudFees = 10000;

            StudentModel st1 = new StudentModel();

            st1.StudId = 2;
            st1.StudName = "umesh";
            st1.StudCourse = "java";
            st1.StudFees = 30000;

            StudentModel st2 = new StudentModel();

            st2.StudId = 3;
            st2.StudName = "Sai";
            st2.StudCourse = "Angular";
            st2.StudFees = 20000;

            listobj.Add(st);
            listobj.Add(st1);
            listobj.Add(st2);




            return View(listobj);
        }

        public ViewResult getAllStudentByDeptVModel()
        {
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

            return View(studentDpartObj);
        }
        public ActionResult ViewDataExample() {
            ViewData["id"] = 1;
            ViewBag.l = "ltm";
            TempData["shirt"] = "blue";
            return RedirectToAction("ViewDataExample1");
        }
        public ActionResult ViewDataExample1()
        {
            int a = Convert.ToInt32(ViewData["id"]);
            string k = ViewBag.l;
            //ViewBag.sid = TempData["shirt"];
            //TempData.Keep();
            ViewBag.sid = TempData.Peek("shirt");
            return View();
        }

        public ActionResult HtmlHelper()
        {
            StudentModel st = new Models.StudentModel();
            st.StudName = "Hari";

            EmployeeEntities db = new EmployeeEntities();
            ViewBag.Employess=new SelectList(db.employeeDetails,"EmpId","EmpName", 17024);


            return View(st);
        }

        [MyFilter]
        public ActionResult TestFilter()
        {
            ViewBag.Employee = "Rahul";
            return View();
        }
    }
}

