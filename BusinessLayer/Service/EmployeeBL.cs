// <copyright file=" EmployeeBL.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System.Collections.Generic;
namespace BusinessLayer.Service
{
    /// <summary>
    /// Here we implements the Business Layer Interface
    /// </summary>
    /// <seealso cref="BusinessLayer.Interface.IEmployeeBL" />
    public class EmployeeBL : IEmployeeBL
    {
        
        /// Here we create the reference of Repository Interface
        private readonly  IEmployeeRL _employeeRL;

        /// <summary>
        /// Initializes a instance using Constructor injection i.e we use the dependency injection <see cref="EmployeeBL"/> class.
        /// </summary>
        /// <param name="employeeRL">The employee rl.</param>
        public EmployeeBL(IEmployeeRL employeeRL)
        {
            _employeeRL = employeeRL;
        }

        /// <summary>
        /// Here AddEmployee() returns the object of EmployeeModel using reference of repsository layer interface
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        public string AddEmployee(EmployeeModel employeeModel)
        {
            return _employeeRL.AddEmployee(employeeModel);
        }

        /// <summary>
        /// Here DeleteEmployee() returns the object of EmployeeModel with employeeid  using reference of repsository layer interface
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public bool DeleteEmployee(int employeeId)
        {
            return _employeeRL.DeleteEmployee(employeeId);
        }

        /// <summary>
        /// Here UpdateEmployee() returns the object of EmployeeModel with employeeid using reference of repsository layer interface
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public bool UpdateEmployee(EmployeeModel employeeModel)
        {
            return _employeeRL.UpdateEmployee(employeeModel);
        }

        /// <summary>
        ///Here DisplayEmployee() returns the list of employee by using repository layer interface
        /// </summary>
        /// <returns></returns>
        public IList<EmployeeModel> DisplayEmployee()
        {
            return _employeeRL.DisplayEmployee();
        }

        /// <summary>
        /// Seraches the employee by identifier. by using the reference of repository layer
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public IList<EmployeeModel> SerachEmployeeById(int employeeId)
        {
            return _employeeRL.SearchEmployeeById(employeeId);
        }
    }
}
