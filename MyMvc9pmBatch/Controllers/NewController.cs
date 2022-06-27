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
        // GET: New
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


    }
}