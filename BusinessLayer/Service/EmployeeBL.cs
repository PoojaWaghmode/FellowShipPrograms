using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class EmployeeBL : IEmployeeBL
    {
        private readonly  IEmployeeRL _employeeRL;
        public EmployeeBL(IEmployeeRL employeeRL)
        {
            _employeeRL = employeeRL;
        }
        public string AddEmployee(EmployeeModel employeeModel)
        {
            return _employeeRL.AddEmployee(employeeModel);
        }

        public bool DeleteEmployee(int employeeId)
        {
            return _employeeRL.DeleteEmployee(employeeId);
        }
        public bool UpdateEmployee(EmployeeModel employeeModel, int employeeId)
        {
            return _employeeRL.UpdateEmployee(employeeModel,employeeId);
        }

        public IList<EmployeeModel> DisplayEmployee()
        {
            return _employeeRL.DisplayEmployee();
        }
        public IList<EmployeeModel> SerachEmployeeById(int employeeId)
        {
            return _employeeRL.SearchEmployeeById(employeeId);
        }
    }
}
