using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.EmployeeModels.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel Emp)
        {
            db.EmployeeModels.Add(Emp);//Generate Insert Script
            int i = db.SaveChanges();//Execute Our Newly added Record
            if(i>0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }


        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel Emp)
        {
            db.Entry(Emp).State = System.Data.Entity.EntityState.Modified;
            int i = db.SaveChanges();//Execute Our Newly added Record
            if (i > 0)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
             db.EmployeeModels.Remove(emp);
            int i = db.SaveChanges();//Execute Our Newly added Record
            if (i > 0)
            {

                return RedirectToAction("Index");
            }

            return View();
        }

    }
}