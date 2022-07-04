using MyMvc9pmBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvc9pmBatch.Controllers
{
    public class NewController : Controller
    {
        // GET: New Vamsi
        public string Index()
        {
            return "hello world";
        }
        public string GetEmpId(int id)
        {
            return "My Employee Id is "+ id;
        }
        //newe.GetEmpId2/1211?name=james&designation=developer
        public string GetEmpId2(int? id)
        {
            return "My Employee Id is " + id+" Employee Name is "+Request.QueryString["name"]+" Designation is "+Request.QueryString["designation"];
        }
        public ActionResult GetMeView()
        {
            return RedirectToAction("GetMeView2");
        }

        public ActionResult GetMeView2()
        {
            ViewBag.Name = "Yash";
            return View();
        }

        public ActionResult GetMeView3()
        {
            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;

            ViewBag.employeedDetail = emp;
            return View();
        }

        public ActionResult GetMeView4()
        {
            List<EmployeeeModel> listObj = new List<EmployeeeModel>();

            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;


            EmployeeeModel emp1 = new EmployeeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kabir";
            emp1.EmpSalary = 61000;

            listObj.Add(emp);
            listObj.Add(emp1);


            ViewBag.employeedDetail = listObj;
            return View();
        }

        public ActionResult GetMeView5()
        {
            List<EmployeeeModel> listObj = new List<EmployeeeModel>();

            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;


            EmployeeeModel emp1 = new EmployeeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kabir";
            emp1.EmpSalary = 61000;

            listObj.Add(emp);
            listObj.Add(emp1);

            //object model=listObj;
             
            return View(listObj);
        }

        public ActionResult GetMeView6()
        {

            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;
            


            //object model=emp;

            return View(emp);
        }

        public ViewResult GetMeView7(int? id)
        {
            List<EmployeeeModel> listEmpObj = new List<Models.EmployeeeModel>();

            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;


            EmployeeeModel emp1 = new EmployeeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "sanjay";
            emp1.EmpSalary =61000;

            EmployeeeModel emp2 = new EmployeeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Vijay";
            emp2.EmpSalary = 71000;

            listEmpObj.Add(emp);
            listEmpObj.Add(emp1);
            listEmpObj.Add(emp2);

            DepartmentModel dept = new DepartmentModel();
            dept.DeptId = 1211;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1212;
            dept1.DeptName = "Marketing";

            List<DepartmentModel> listdeptObj = new List<DepartmentModel>();
            listdeptObj.Add(dept);
            listdeptObj.Add(dept1);

            EmpDept empdeptObj = new EmpDept();
            empdeptObj.Emp = listEmpObj;
            empdeptObj.dept = listdeptObj;


            return View(empdeptObj);
        }

       public RedirectResult RedirectToUrl1()
        {
            return Redirect("~/new/GetMeView7?id=1");
        }

        public RedirectResult RedirectToUrl2()
        {
            return Redirect("http://www.google.com");
        }

        public ActionResult ExampleView1()
        {
            return View();
        }

        public ActionResult ExampleView2()
        {
            List<EmployeeeModel> listObj = new List<EmployeeeModel>();

            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;


            EmployeeeModel emp1 = new EmployeeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kabir";
            emp1.EmpSalary = 61000;

            listObj.Add(emp);
            listObj.Add(emp1);


            return View(listObj);
        }

        public ActionResult GetDefaultIndexView()
        {
            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Yash";
            emp.EmpSalary = 51000;


           
            return View("GetMeView6",emp);
        }

        public JsonResult Getjson()

        {
            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Jacson";
            emp.EmpSalary = 83939;


            EmployeeeModel emp1 = new EmployeeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kevin";
            emp1.EmpSalary = 33939;


            EmployeeeModel emp2 = new EmployeeeModel();
            emp2.EmpId = 1;
            emp2.EmpName = "peter";
            emp2.EmpSalary = 73939;

            List<EmployeeeModel> listemp = new List<EmployeeeModel>();
            listemp.Add(emp);
            listemp.Add(emp1);
            listemp.Add(emp2);



            return Json(listemp,JsonRequestBehavior.AllowGet);
        }
        public ActionResult getAccessJsonData()
        {
            return View();
        }

        public FileResult GetFileData()
        {
            return File("~/Web.config", "text");
        }
        public FileResult GetFileData2()
        {
            return File("~/Web.config", "application/xml");
        }
        public FileResult GetFileData3()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
        public FileResult GetFileData4()
        {
            return File("~/Web.config", "application/xml","myweb.config");
        }

        public ContentResult getContent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");
            }
            else if (id == 2)
            {
                return Content("<h1 style=color:red>Hello World</h1>");
            }
            else
            {
                return Content("<script>alert('Hello World')</script>");
            }
        }

        public RedirectToRouteResult getRoute()
        {
            return RedirectToAction("index","Default",new {id=1});
        }

        public RedirectToRouteResult getRoute2()
        {
            EmployeeeModel emp = new EmployeeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Jacson";
            emp.EmpSalary = 83939;

            return RedirectToAction("index2", "Default",emp);
        }
        public RedirectToRouteResult getRoute3()
        {
            
            return RedirectToRoute("Default21");
        }

    }
}