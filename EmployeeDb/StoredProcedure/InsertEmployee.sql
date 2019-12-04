CREATE PROCEDURE [dbo].[InsertEmployee]
	 
	   @FirstName varchar(20),
	   @LastName varchar(50),
	   @Address varchar(50),
	   @Email varchar(50)
AS
BEGIN
	INSERT INTO Employee(
	FirstName,
	LastName,
	Address,
	Email)VALUES(
	   @FirstName ,
	   @LastName,
	   @Address ,
	   @Email)

END