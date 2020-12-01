using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);//insert Query
            //Department obj=new Department();
            //obj.DeptId=emp.DeptId;
            //obj.DeptName=emp.DeptName;

            //db.DepartmentModels.Add(obj);
            int i =db.SaveChanges();
            if (i > 0)
            {

                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }
    }
}