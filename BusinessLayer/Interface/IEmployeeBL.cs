// <copyright file=" IEmployeeBL.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------

using CommonLayer.Model;
using System.Collections.Generic;
    namespace BusinessLayer.Interface
    {
    /// <summary>
    /// This id BusinessLayer Interface which decalres methods that are declared in Repository Layer
    /// </summary>
    public interface IEmployeeBL
        {
            string AddEmployee(EmployeeModel employeeModel);

            bool DeleteEmployee(int employeeId);
            bool UpdateEmployee(EmployeeModel employeeModel);
            IList<EmployeeModel> DisplayEmployee();
            IList<EmployeeModel> SerachEmployeeById(int employeeId);

        }
    }
