--ASSIGNMENT 1
CREATE FUNCTION fn_display_product_details()
RETURNS TABLE
AS
	RETURN SELECT * FROM Sales.SalesOrderHeader
	WHERE YEAR(OrderDate) BETWEEN 2010 AND 2013;

SELECT * FROM fn_display_product_details();

--ASSIGNMENT 2
select * from sales.SalesOrderDetail;
CREATE FUNCTION fn_get_quantity_name(@Id int)
RETURNS TABLE
AS
	RETURN SELECT P.ProductID, P.Name, Q.AvailableQuantity FROM Production.Quantity AS Q
	RIGHT JOIN Production.Product AS P
	ON Q.ProductID = P.ProductID
	WHERE P.ProductID = @Id;
	 
SELECT * FROM fn_get_quantity_name(2);

--ASSIGNMENT 3
CREATE TRIGGER tr_restrict_delete
ON Sales.Store
INSTEAD OF DELETE
AS
BEGIN
	RAISERROR('DATA FROM THIS TABLE CAN NOT BE DELETED',16,1)
END

SELECT * FROM SALES.STORE;
DELETE FROM SALES.STORE WHERE BusinessEntityID = 292;

--ASSIGNMENT 4

ALTER TRIGGER tr_prohibit_all_action
ON DBO.STUDENT
FOR INSERT, UPDATE, DELETE
AS
BEGIN
	DECLARE @Date DATE
	DECLARE @TodaysDate DATE

	IF EXISTS (SELECT DOB from DELETED)
		select @Date = DOB from deleted;
	IF EXISTS (SELECT DOB from inserted)
		select @Date = DOB from INSERTED;  

	SELECT @TodaysDate = GETDATE()
	IF(@Date = @TodaysDate)
		THROW 50000, 'Operation can not be done on todays date', 1;
END;

SELECT GETDATE();
DELETE FROM Student WHERE DOB = '2011-03-23';
UPDATE STUDENT SET course = 'Mechanical' WHERE DOB = '2024-05-08';
INSERT INTO STUDENT VALUES(13,'Yash','Amravati','Testing','y@gmail.com',1029384756,'2024-05-08');
select * from DBO.Student

	
	


--ASSIGNMENT 6
CREATE TRIGGER tr_prohibit_adding
ON DATABASE
FOR CREATE_TABLE
AS
BEGIN
	PRINT( 'Can not add tables into this database');
	THROW 50000, 'Table can not be created', 1;
END

CREATE TABLE DUMMY(ID INT);
SELECT * FROM DUMMY

--ASSIGNMENT 7

CREATE VIEW DummyView
AS
SELECT P.BusinessEntityID, P.PersonType, CONCAT(P.FirstName, ' ', P.LastName) AS FullName, E.NationalIDNumber, E.JobTitle, E.BirthDate, E.Gender 
FROM PERSON.Person AS P
INNER JOIN HumanResources.Employee AS E
ON P.BusinessEntityID = E.BusinessEntityID
GO

SELECT * FROM dummyView;

CREATE TRIGGER tr_restrict_update
ON dummyView
INSTEAD OF UPDATE
AS
BEGIN
	PRINT('View can not be updated');
	THROW 50000, 'View can not be updated', 1;
END

update dummyView set personType = 'fg' where businessEntityID = 1;