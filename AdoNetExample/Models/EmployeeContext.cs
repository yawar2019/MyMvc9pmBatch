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

                emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                emp.EmpName = Convert.ToString(dr["EmpName"]);
                emp.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);

                listEmp.Add(emp);
            }

            return listEmp;

        }

        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("sp_CreateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public EmployeeModel GetEmployeeById(int? id)
        {


            EmployeeModel Emp = new EmployeeModel();

            SqlCommand cmd = new SqlCommand("usp_getEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmpId", id);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                Emp.EmpId = Convert.ToInt32(dr["EmpId"]);
                Emp.EmpName = Convert.ToString(dr["EmpName"]);
                Emp.EmpSalary = Convert.ToInt32(dr["EmpSalary"]);

            }

            return Emp;

        }



        public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("usp_updateEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public int DeleteEmployeeById(int? id)
        {
            SqlCommand cmd = new SqlCommand("usp_DeleteEmployeeById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpId", id);
            
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

    }
}