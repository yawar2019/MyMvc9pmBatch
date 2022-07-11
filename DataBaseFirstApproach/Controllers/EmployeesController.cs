using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataBaseFirstApproach.Models;

namespace DataBaseFirstApproach.Controllers
{
    public class EmployeesController : Controller
    {
        private mvc9pmbatchdbEntities db = new mvc9pmbatchdbEntities();

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.EmpDbs.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpDb empDb = db.EmpDbs.Find(id);
            if (empDb == null)
            {
                return HttpNotFound();
            }
            return View(empDb);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpId,EmpName,EmpSalary")] EmpDb empDb)
        {
            if (ModelState.IsValid)
            {
                db.EmpDbs.Add(empDb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empDb);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpDb empDb = db.EmpDbs.Find(id);
            if (empDb == null)
            {
                return HttpNotFound();
            }
            return View(empDb);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpId,EmpName,EmpSalary")] EmpDb empDb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empDb);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpDb empDb = db.EmpDbs.Find(id);
            if (empDb == null)
            {
                return HttpNotFound();
            }
            return View(empDb);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpDb empDb = db.EmpDbs.Find(id);
            db.EmpDbs.Remove(empDb);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
