﻿using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IEmployeeRL
    {
        string AddEmployee(EmployeeModel employeeModel);
        bool DeleteEmployee(int employeeId);
        bool UpdateEmployee(EmployeeModel employeeModel, int employeeId);
        IList<EmployeeModel> DisplayEmployee();
        IList<EmployeeModel> SearchEmployeeById(int employeeId);
    }


}
