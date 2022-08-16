using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandleFilter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HandleError]
        public ActionResult GetDetail(int d)
        {
            //try
            //{
                int a = d, b = 0, c;
                int result = a / b;
            //}
            //catch(Exception ex)
            //{
            //   if(ex.Message.Contains("Attempted to divide by zero"))
            //    {
            //        return View("CustomErrorPage",new HandleErrorInfo(ex,"Home","GetDetail"));
            //    }
            //    return View("Error", new HandleErrorInfo(ex, "Home", "GetDetail"));

            //}
            return View();
        }
    }
}