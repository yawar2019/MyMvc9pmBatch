using AdoNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetExample.Controllers
{
    public class EmployeeDetailController : Controller
    {
        // GET: EmployeeDetail
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetAllEmployees());
        }

        public ActionResult Create()
        {
            ViewBag.dropdownEmp = new SelectList(db.GetAllEmployees(), "EmpId", "EmpName");

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);

            ViewBag.dropdownEmp = new SelectList(db.GetAllEmployees(),"EmpId","EmpName");

            if(i>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
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
            return View();
        }


        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployeeById(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}