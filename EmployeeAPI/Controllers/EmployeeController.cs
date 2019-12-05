// <copyright file=" EmployeeController.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeAPI.Controllers
 {
        /// <summary>
        /// Here we use the [Route] attribute  to define routes it gives the control over the URL 
        /// </summary>
        /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeController : ControllerBase
        {
            /// <summary>
            /// Here we create the reference of Business Layer
            /// </summary>
            private readonly IEmployeeBL _employee;
            public EmployeeController(IEmployeeBL _emp)
            {
                this._employee = _emp;
            }

            /// <summary>
            /// Adds the specified employee model.
            /// </summary>
            /// <param name="employeeModel">The employee model.</param>
            /// <returns></returns>
            /// Route is the attribute and add is the Http verb which is used for Post data to server
            [HttpPost]
            [Route("add")]
            public IActionResult Add(EmployeeModel employeeModel)
            {
                var result = _employee.AddEmployee(employeeModel);

                ////It will returns the result in response body of API
                return Ok(new { result });
            }

            /// <summary>
            /// Deletes the specified employee identifier.
            /// </summary>
            /// <param name="employeeId"></param>
            /// Here we use the Delete Httpverb with Route attribute by giving id 
            /// <returns></returns>
            [HttpDelete]
            [Route("delete/{employeeId}")]
            public IActionResult Delete(int employeeId)
            {
                var result = _employee.DeleteEmployee(employeeId);

                ////It will returns the result in response body of API
                return Ok(new { result });
            }

            /// <summary>
            /// Updates the specified employee model.
            /// </summary>
            /// <param name="employeeModel">The employee model.</param>
            /// <param name="employeeId">The employee identifier.</param>
            /// <returns></returns>
            /// Here we use HTTpPut verb for update record
            [HttpPut]
            [Route("update/{employeeId}")]
            public IActionResult Update(EmployeeModel employeeModel)
            {
                var result = _employee.UpdateEmployee(employeeModel);

                ////It will returns the result in response body of API
                return Ok(new { result });
            }

            /// <summary>
            /// Displays this all employeelist so we use Get http verb
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Route("getAllEmployee")]
            public IActionResult Display()
            {
                var result = _employee.DisplayEmployee();

                ////It will returns the result in response body of API
                return Ok(new { result });
            }

            /// <summary>
            /// Searches the by identifier. using Get http verb
            /// </summary>
            /// <param name="employeeId">The employee identifier.</param>
            /// <returns></returns>
            [HttpGet]
            [Route("searchId/{employeeId}")]
            public IActionResult SearchById(int employeeId)
            {
                var result = _employee.SerachEmployeeById(employeeId);
                return Ok(new { result });
            }
        }
}