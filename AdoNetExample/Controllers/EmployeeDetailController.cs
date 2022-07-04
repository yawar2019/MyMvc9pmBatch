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
    }
}