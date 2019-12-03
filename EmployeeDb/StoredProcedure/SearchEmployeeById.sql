CREATE PROCEDURE [dbo].[SearchEmployeeById]
										@EmployeeId INT
										
AS
BEGIN
		SELECT * FROM Employee 
		WHERE EmployeeId = @EmployeeId
	
END
