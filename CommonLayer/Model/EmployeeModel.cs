    // <copyright file=" EmployeeModel.cs" company="Bridgelabz">
    // Copyright © 2019 Company
    // </copyright>
    // <creator name="Pooja Waghmode"/>
    // --------------------------------------------------------------------------------------------------------------------
    using System.ComponentModel.DataAnnotations;
    namespace CommonLayer.Model
    {
    /// <summary>
    /// Employee Models have all the data members which are used in overall application .Here we achieve encapsulation by accessing private data members by public methods
    /// </summary>
    public class EmployeeModel
        {
            private int employeeId;
            private string firstName;
            private string lastName;
            private string address;
            private string email;

            /// <summary>
            /// Gets or sets the employee identifier.
            /// </summary>
            /// <value>
            /// Here we use the Annotations i.e Validation Attribute which validate the datamember EmployeeId
            /// </value>
            [Required(ErrorMessage="Employee Id Required")]
            public int EmployeeId { get => employeeId; set => employeeId = value; }

            /// <summary>
            /// Gets or sets the first name.
            /// </summary>
            /// <value>
            /// Here we use the StringLength Attribute
            /// </value>
            [Required(ErrorMessage = "Employee FirstName Is Required")]
            [StringLength(100, MinimumLength = 3,
            ErrorMessage = "FirstName Should be minimum 3 characters and a maximum of 25 characters")]
            public string FirstName { get => firstName; set => firstName = value; }

            /// <summary>
            /// Gets or sets the last name.
            /// </summary>
            /// <value>
            /// Here we use the StringLength Attribute
            /// </value>
            [Required(ErrorMessage = "Employee LastName Is Required")]
            [StringLength(100, MinimumLength = 3,
            ErrorMessage = "Employee LastName Should be minimum 3 characters and a maximum of 25 characters")]
            [DataType(DataType.Text)]
            public string LastName { get => lastName; set => lastName = value; }


            /// <summary>
            /// Gets or sets the address.
            /// </summary>
            /// <value>
            /// Here we use the Required Attribute for validation
            /// </value>
            [Required(ErrorMessage = "Address Required")]
            public string Address { get => address; set => address = value; }


            /// <summary>
            /// Gets or sets the email.
            /// </summary>
            /// <value>
            /// Here we use the Datatype Attribute which provides validation directly to email address 
            /// </value>
            [DataType(DataType.EmailAddress)]
            [EmailAddress]
            public string Email { get => email; set => email = value; }
        }
    }
