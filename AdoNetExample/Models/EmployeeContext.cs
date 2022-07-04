using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoNetExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=mvc9pmbatchdb;Integrated Security=true");

        public List<EmployeeModel> GetAllEmployees()
        {
            List<EmployeeModel> listEmp = new List<Models.EmployeeModel>();

            SqlCommand cmd = new SqlCommand("sp_Employee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new Models.EmployeeModel();

                emp.EmpId=Convert.ToInt32(dr["EmpId"]);
                emp.EmpName=Convert.ToString(dr["EmpName"]);
                emp.EmpSalary=Convert.ToInt32(dr["EmpSalary"]);

                listEmp.Add(emp);
            }

            return listEmp;

        }

    }
}