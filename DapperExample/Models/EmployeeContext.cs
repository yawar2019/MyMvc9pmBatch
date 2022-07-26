using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
namespace DapperExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=mvc9pmbatchdb;Integrated Security=true");

        public List<EmployeeModel> GetAllEmployees()
        {
            var Employees = con.Query<EmployeeModel>("sp_Employee",commandType:System.Data.CommandType.StoredProcedure);
            return Employees.ToList();
        }

        public int SaveEmployee(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);
            int i = con.Execute("sp_CreateEmployee",param:param, commandType: System.Data.CommandType.StoredProcedure);
            return i;
        }

        public EmployeeModel GetEmployeeById(int? id)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", id);

            var Employee = con.QuerySingle<EmployeeModel>("usp_getEmployeeById",param: param, commandType: System.Data.CommandType.StoredProcedure);
            return Employee;
        }
   
              public int UpdateEmployee(EmployeeModel emp)
        {
            var param = new DynamicParameters();
            param.Add("@EmpId", emp.EmpId);
            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);
            int i = con.Execute("usp_updateEmployeeById", param: param, commandType: System.Data.CommandType.StoredProcedure);
            return i;
        }
    }
}