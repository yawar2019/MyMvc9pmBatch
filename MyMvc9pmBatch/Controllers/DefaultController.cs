using MyMvc9pmBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc9pmBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? id)
        {
            return View();
        }
        public ActionResult Index2(EmployeeeModel emp)
        {
            return View();
        }
    }
}