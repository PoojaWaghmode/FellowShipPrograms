CREATE PROCEDURE [dbo].[DeleteEmployeeById]
									@EmployeeId INT
									

AS
BEGIN
	
	DELETE FROM Employee  
    WHERE EmployeeId = @EmployeeId

   
END
