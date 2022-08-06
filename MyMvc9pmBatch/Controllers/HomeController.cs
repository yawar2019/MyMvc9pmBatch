using MyMvc9pmBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc9pmBatch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public EmptyResult Index()
        {
            return new EmptyResult();
        }
        public ViewResult Index3()
        {
            return   View();
        }
        public JavaScriptResult Index2()
        {
            return JavaScript("alert('hello world');");
        }

        public ActionResult Registration()
        {
            EmployeeEntities db = new Models.EmployeeEntities();
            ViewBag.Country = new SelectList(db.employeeDetails.ToList(), "EmpId", "EmpName");
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationModel Reg)
        {
            EmployeeEntities db = new Models.EmployeeEntities();
            ViewBag.Country = new SelectList(db.employeeDetails.ToList(), "EmpId", "EmpName");
            return View();
        }

        public ActionResult ValidationExample()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult ValidationExample(RegistrationModel emp)
        {
            if(ModelState.IsValid)
            {
                return Content("ValideData");
            }
            return View();
        }
    }
}