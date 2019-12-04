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

       
        [Required(ErrorMessage = "Employee FirstName Is Required")]
        [StringLength(100, MinimumLength = 3,
        ErrorMessage = "FirstName Should be minimum 3 characters and a maximum of 25 characters")]
        public string FirstName { get => firstName; set => firstName = value; }


        [Required(ErrorMessage = "Employee LastName Is Required")]
        [StringLength(100, MinimumLength = 3,
        ErrorMessage = "Employee LastName Should be minimum 3 characters and a maximum of 25 characters")]
        [DataType(DataType.Text)]
        public string LastName { get => lastName; set => lastName = value; }


       // //[Range(18, 99, ErrorMessage = "Age should be between 18 and 99")]
       // public int Age { get => age; set => age = value; }



        [Required(ErrorMessage = "Address Required")]
        public string Address { get => address; set => address = value; }



        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get => email; set => email = value; }
    }
}
