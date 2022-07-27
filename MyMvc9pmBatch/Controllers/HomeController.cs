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
    }
}