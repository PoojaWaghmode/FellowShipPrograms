using BusinessLayer.Service;
using CommonLayer.Model;
using Moq;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using Xunit;

namespace EmployeeOperationsTestCases
{
    public class EmployeeTestCases
    {
        [Fact]
        public void InsertEmployee()
        {
            var repository = new Mock<IEmployeeRL>();
            var business = new EmployeeBL(repository.Object);
            var model = new EmployeeModel()
            {
                FirstName = "firstName",
                LastName="lastName",
                Age = 21,
                Address="address",
                Email="email@gmail.com"
            };
            var data = business.AddEmployee(model);
            Assert.NotNull(data);

        }

        [Fact]
        public void DeleteEmployee()
        {
            var repository = new Mock<IEmployeeRL>();
            var business = new EmployeeBL(repository.Object);
            var model = new EmployeeModel();
            
            var data = business.DeleteEmployee(2);
            Assert.NotNull(data);
        }

        [Fact]
        public void UpdateEmployee()
        {
            var repository = new Mock<IEmployeeRL>();
            var business = new EmployeeBL(repository.Object);
            var model = new EmployeeModel()
            {
                EmployeeId= 1002,
                FirstName = "firstName",
                LastName  = "lastName",
                Age       =  21,
                Address   = "address",
                Email     = "email@gmail.com"
            };
            var data = business.UpdateEmployee(model, 1002);
            Assert.True(data);

        }

        [Fact]
        public void DisplayEmp()
        {
            var repository = new Mock<IEmployeeRL>();
            var business = new EmployeeBL(repository.Object);
            var model = new EmployeeModel()
            {
                FirstName = "firstName",
                LastName = "lastName",
                Age = 21,
                Address = "address",
                Email = "email@gmail.com"
            };
            //var data = business.DisplayEmployee(model);


        }

    }
}
