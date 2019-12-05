// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" IEmployeeRL.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
using CommonLayer.Model;
using System.Collections.Generic;
namespace RepositoryLayer.Interface
{
    /// <summary>
    /// This Is Repository Interface have method declarations used in EmployeeManagementSystem project
    /// </summary>
    public interface IEmployeeRL
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        string AddEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(int employeeId);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        bool UpdateEmployee(EmployeeModel employeeModel);

        /// <summary>
        /// Displays the employee.
        /// </summary>
        /// <returns></returns>
        IList<EmployeeModel> DisplayEmployee();

        /// <summary>
        /// Searches the employee by identifier.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        IList<EmployeeModel> SearchEmployeeById(int employeeId);
    }
}
