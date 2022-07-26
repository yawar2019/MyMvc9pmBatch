using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DapperExample.Models;
namespace DapperExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: 
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetAllEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if(i>0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int? id)
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
    }
}