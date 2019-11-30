CREATE PROCEDURE [dbo].[InsertEmployee]
	 
	   @FirstName varchar(20),
	   @LastName varchar(50),
	   @Age int,
	   @Address varchar(50),
	   @Email varchar(50)
AS
BEGIN
	INSERT INTO Employee(
	FirstName,
	LastName,
	Age,
	Address,
	Email)VALUES(
	   @FirstName ,
	   @LastName,
	   @Age ,
	   @Address ,
	   @Email)

END