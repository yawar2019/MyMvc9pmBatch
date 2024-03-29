﻿using MyMvc9pmBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MyMvc9pmBatch.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            EmployeeEntities db = new EmployeeEntities();
            UserDetail u = db.UserDetails.Where(x => x.UserName == user.UserName && x.Password == user.Password).SingleOrDefault();
            if (u!=null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult AboutUS()
        {
            return View();
        }

        [Authorize(Roles ="Manager")]
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        [OutputCache(Duration =10,Location =System.Web.UI.OutputCacheLocation.Client)]
        public ActionResult GetOurTime()
        {
            return View();
        }

        public ActionResult ConsumeGetService()
        {
            ServiceReference1.WebService1SoapClient webasp = new ServiceReference1.WebService1SoapClient();
            int r=webasp.Result(12,87);
            return Content("Got Result"+r);
        }
    }
}