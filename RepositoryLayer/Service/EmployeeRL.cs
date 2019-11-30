using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmployeeRL : IEmployeeRL
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDb)\LocalDB;Initial Catalog=EmployeeDb;Integrated Security=true;");
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try 
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("InsertEmployee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("@Age",employeeModel.Age);
                sqlCommand.Parameters.AddWithValue("@Address",employeeModel.Address);
                sqlCommand.Parameters.AddWithValue("@Email",employeeModel.Email);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return  true;
        }

        public bool DeleteEmployee(int employeeId)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("DeleteEmployeeById",sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@EmployeeId",employeeId);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return true;
        }


        public bool UpdateEmployee(EmployeeModel employeeModel, int employeeId)
        {
           try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UpdateEmployeeById",sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@EmployeeId",employeeModel.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@FirstName",employeeModel.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName",employeeModel.LastName);
                sqlCommand.Parameters.AddWithValue("@Age", employeeModel.Age);
                sqlCommand.Parameters.AddWithValue("@Address",employeeModel.Address);
                sqlCommand.Parameters.AddWithValue("@Email",employeeModel.Email);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return true;
        }


        public IList<EmployeeModel> DisplayEmployee()
        {
            sqlConnection.Open();
            IList<EmployeeModel> employeeList = new List<EmployeeModel>();

            try
            {
                
                SqlCommand sqlCommand = new SqlCommand("DisplayAllEmployees",sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while(dataReader.Read())
                {
                   
                    employeeList.Add(new EmployeeModel
                    {
                        EmployeeId = Convert.ToInt32(dataReader["EmployeeId"]),
                        FirstName = dataReader["FirstName"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        Age = Convert.ToInt32(dataReader["Age"]),
                        Address = dataReader["Address"].ToString(),
                        Email = dataReader["Email"].ToString()

                    }) ; 
                      
                }
                return employeeList;
            }
            catch(Exception exception)
            {
                throw new Exception (exception.Message);
            }
            
        }
        
    }
}
