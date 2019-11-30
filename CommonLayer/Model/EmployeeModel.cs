using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Model
{
    public class EmployeeModel
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private int age;
        private string address;
        private string email;
        [Required(ErrorMessage="Employee Id Required")]
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        [Required(ErrorMessage="FirstName Required")]
        public string FirstName { get => firstName; set => firstName = value; }

        [Required(ErrorMessage="LastName Required")]
        public string LastName { get => lastName; set => lastName = value; }

        [Required(ErrorMessage = "Age Required")]
        public int Age { get => age; set => age = value; }

        [Required(ErrorMessage = "Address Required")]
        public string Address { get => address; set => address = value; }

        [Required(ErrorMessage = "Email Required")]
        public string Email { get => email; set => email = value; }
    }
}
