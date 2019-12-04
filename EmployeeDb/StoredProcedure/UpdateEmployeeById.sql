CREATE PROCEDURE [dbo].[UpdateEmployeeById] 
									@EmployeeId INT,
									@FirstName  VARCHAR(50),
									@LastName   VARCHAR(50),
									@Address    VARCHAR(50),
									@Email      VARCHAR(50)
	
AS
BEGIN	
		UPDATE Employee SET 
				
						FirstName=@FirstName,
						LastName=@LastName,
						Address=@Address,
						Email=@Email
		WHERE EmployeeId=@EmployeeId

	
END

