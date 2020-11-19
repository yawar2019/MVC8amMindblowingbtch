using AdonetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdonetExample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }

        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            EmployeeModel emp = new Models.EmployeeModel();
            emp.EmpName = frm["EmpName"];
            emp.EmpSalary =Convert.ToInt32(frm["EmpSalary"]);


            int i = db.Save(emp);
            if (i > 0) {
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {

            }
            return View();
        }


        public ActionResult Edit(int ? id)
        {
          EmployeeModel emp= db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {

            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
              return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }
    }
}