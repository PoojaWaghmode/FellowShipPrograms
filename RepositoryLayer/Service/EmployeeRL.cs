// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" EmployeeRL.cs" company="Bridgelabz">
// Copyright © 2019 Company
// </copyright>
// <creator name="Pooja Waghmode"/>
// --------------------------------------------------------------------------------------------------------------------
using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace RepositoryLayer.Service
{
    /// <summary>
    /// Here We implements the IEmployeeRL i.e repository interface
    /// </summary>
    /// <seealso cref="RepositoryLayer.Interface.IEmployeeRL" />
    public class EmployeeRL : IEmployeeRL
    {
        /// <summary>
        /// Here we give the SQL connection string of Microsoft SQL server which have the employeeDatabase
        /// </summary>
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDb)\LocalDB;Initial Catalog=EmployeeDb;Integrated Security=true;");
        
        /// <summary>
        /// Adds the employee.by taking values i.e Employee Data from EmployeeModel Class 
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string AddEmployee(EmployeeModel employeeModel)
        {
            try 
            {
                ////Here we open the sqlconnection
                sqlConnection.Open();

                ////here we create the object of SqlCommand class and pass the stored procedure and sqlconnection string through SqlCommand constructor 
                SqlCommand sqlCommand = new SqlCommand("InsertEmployee", sqlConnection);

                ////Here CommandType describes that we using the Type of command as storedprocedure 
                sqlCommand.CommandType = CommandType.StoredProcedure;

                ////Here we adds the values in database using AddWithValue()function
                sqlCommand.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("@Address",employeeModel.Address);
                sqlCommand.Parameters.AddWithValue("@Email",employeeModel.Email);

                ////Here we use ExecuteNonQuery() method to execute storedprocedure
                sqlCommand.ExecuteNonQuery();

                ////After run we closes the sqlconnection
                sqlConnection.Close();

            }
            ////Here we catch the exception if any error Occurs
            catch(Exception exception)
            {
                throw new Exception(exception.Message);
            }
            ////If data added successfully in database then it returns the message 
            return  "Record Added Successfully";
        }


        /// <summary>
        /// Deletes the employee.By Id
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                ////Here we open the sqlconnection
                sqlConnection.Open();


                ////here we create the object of SqlCommand class and pass the stored procedure and sqlconnection string through SqlCommand constructor 
                SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeById",sqlConnection);

                ////Here CommandType describes that we using the Type of command as storedprocedure 
                sqlCommand.CommandType = CommandType.StoredProcedure;

                ////here we adds the value for delete record
                sqlCommand.Parameters.AddWithValue("@EmployeeId",employeeId);

                ////Here we use ExecuteNonQuery() method to execute storedprocedure
                sqlCommand.ExecuteNonQuery();

                ////After run we closes the sqlconnection
                sqlConnection.Close();

            }
            ////Here we catch the exception if any error Occurs otherwise throw the error
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            ////If data deleted successfully from database then it returns true 
            return true;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeModel">The employee model.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool UpdateEmployee(EmployeeModel employeeModel)
        {
           try
            {
                ////Here we open the sqlconnection
                sqlConnection.Open();

                ////here we create the object of SqlCommand class and pass the stored procedure and sqlconnection string through SqlCommand constructor 
                SqlCommand sqlCommand = new SqlCommand("UpdateEmployeeById",sqlConnection);

                ////Here CommandType describes that we using the Type of command as storedprocedure 
                sqlCommand.CommandType = CommandType.StoredProcedure;

                ////here we adds the values for update to database using object of sqlCommand 
                sqlCommand.Parameters.AddWithValue("@EmployeeId",employeeModel.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@FirstName",employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName",employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("@Address",employeeModel.Address);
                sqlCommand.Parameters.AddWithValue("@Email",employeeModel.Email);

                ////Here we excecute storedprocedure
                sqlCommand.ExecuteNonQuery();

                ////Here we close the sqlConnection
                sqlConnection.Close();

            }
            ////Here we catch the exception if any error Occurs
            catch (Exception exception)
            {
                ////Here we catch the exception if any error Occurs otherwise throw the error
                throw new Exception(exception.Message);
            }
            ////If data updated successfully to database then it returns true 
            return true;
        }

        /// <summary>
        /// Displays the employee.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        /// Here we retrives all employee list using IList interface
        public IList<EmployeeModel> DisplayEmployee()
        {

            try
            {
                ////Here we open the sqlconnection
                sqlConnection.Open();

                ////Here we creates list of employee
                IList<EmployeeModel> employeeList = new List<EmployeeModel>();

                ////here we create the object of SqlCommand class and pass the stored procedure and sqlconnection string through SqlCommand constructor 
                SqlCommand sqlCommand = new SqlCommand("DisplayAllEmployees",sqlConnection);

                ////Here we calls the ExecuteReader() it will returns the number of rows affected
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                ////Here we call Read() of SqlDataReader class for read data from database
                while(dataReader.Read())
                {
                   
                    ////Here we adds the data to list using Add()
                    employeeList.Add(new EmployeeModel
                    {
                        EmployeeId = Convert.ToInt32(dataReader["EmployeeId"]),
                        FirstName = dataReader["FirstName"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        Address = dataReader["Address"].ToString(),
                        Email = dataReader["Email"].ToString()

                    }) ; 
                      
                }
                ////Here we returns the list of employee data 
                return employeeList;
               
            }
            catch(Exception exception)
            {
                ////Here we catch the exception if any error Occurs otherwise throw the error
                throw new Exception (exception.Message);
            }
            
        }
        public IList<EmployeeModel> SearchEmployeeById(int employeeId)
        {
            try
            {
                IList<EmployeeModel> employeeList = new List<EmployeeModel>();
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SearchEmployeeById", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@EmployeeId", employeeId);
               
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {

                    employeeList.Add(new EmployeeModel
                    {
                        EmployeeId = Convert.ToInt32(dataReader["EmployeeId"]),
                        FirstName = dataReader["FirstName"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        Address = dataReader["Address"].ToString(),
                        Email = dataReader["Email"].ToString()

                    });
                    
                }
                ////If data read successfully from database then it returns true 
                return employeeList;
                
            }
            catch (Exception exception)
            {
                ////Here we catch the exception if any error Occurs otherwise throw the error
                throw new Exception(exception.Message);
            }
        }
    }
}
