using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvc9pmBatch.Models
{
    public class EmpDept
    {
        public List<EmployeeeModel> Emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }
}