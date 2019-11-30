using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
   public interface IEmployeeBL
    {
        bool AddEmployee(EmployeeModel employeeModel);

        bool DeleteEmployee(int employeeId);
        bool UpdateEmployee(EmployeeModel employeeModel, int employeeId);
        IList<EmployeeModel> DisplayEmployee();

    }
}
