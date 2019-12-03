using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Interface;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBL _employee;
        public EmployeeController(IEmployeeBL _emp)
        {
            this._employee = _emp;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(EmployeeModel employeeModel)
        {
            var result = _employee.AddEmployee(employeeModel);
            return Ok(new { result });
        }

        [HttpDelete]
        [Route("delete/{employeeId}")]
        public IActionResult Delete(int employeeId)
        {
            var result = _employee.DeleteEmployee(employeeId);
            return Ok(new { result });
        }

        [HttpPut]
        [Route("update/{employeeId}")]
        public IActionResult Update(EmployeeModel employeeModel, int employeeId)
        {
            var result = _employee.UpdateEmployee(employeeModel, employeeId);
            return Ok(new { result });
        }
        [HttpGet]
        [Route("get")]
        public IActionResult Display()
        {
            var result = _employee.DisplayEmployee();
            return Ok(new { result });
        }
        [HttpGet]
        [Route("searchId/{employeeId}")]
        public IActionResult SearchById(int employeeId)
        {
            var result = _employee.SerachEmployeeById(employeeId);
            return Ok(new { result });
        }
    }
}