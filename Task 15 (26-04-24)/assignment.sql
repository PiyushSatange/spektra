select SalesPersonID, OrderDate, TotalDue from Sales.SalesOrderHeader;
/* Slide 1 Assignment - 1*/
SELECT 
salesPersonId, OrderDate, sum(TotalDue) as Total 
from Sales.SalesOrderHeader 
group by SalesPersonID, OrderDate;

/* Slide 1 Assignment - 2*/
select top 1 
SalesPersonID, sum(TotalDue) as Total_Sales 
from Sales.SalesOrderHeader 
group by SalesPersonID 
order by Total_Sales desc;

/* Slide 1 Assignment - 3*/
select top 1 
MONTH(orderDate) as Highest_Month, 
SUM(totalDue) as Total_Sales 
from Sales.SalesOrderHeader 
group by OrderDate 
order by Total_Sales desc;

/* Slide 1 Assignment - 4*/
select * from HumanResources.JobCandidate 
where BusinessEntityID is not null;

/* Slide 1 Assignment - 5*/
select * from Production.Product 
where MakeFlag = 1;

/* Slide 1 Assignment - 6*/
select 
ProductId, sum(OrderQty) as Total_Orders 
from Sales.SalesOrderDetail 
group by ProductID;

/* Slide 1 Assignment - 7*/
select
CONCAT(firstName,' ', LastName) as Full_Name 
from Person.Person;

/* Slide 2 Assignment - 1*/
select ContactTypeID, Name 
from Person.ContactType where Name like '%Manager%'
order by ContactTypeID desc;

/* Slide 2 Assignment - 2*/ 
SELECT 
ST.Name AS PostalCode,
SP.SalesYTD AS SalesYTD
FROM Sales.SalesPerson AS SP
inner JOIN 
Sales.SalesTerritory AS ST 
ON SP.TerritoryID = ST.TerritoryID
WHERE SP.SalesYTD != 0
ORDER BY ST.Name ASC, SP.SalesYTD DESC;

/* Slide 2 Assignment - 3*/
SELECT 
CAST(hur.RateChangeDate as VARCHAR(10)) AS FromDate,
CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS NameInFull,
(40 * hur.Rate) AS SalaryInAWeek
FROM Person.Person AS pp
INNER JOIN HumanResources.EmployeePayHistory AS hur
ON hur.BusinessEntityID = pp.BusinessEntityID
ORDER BY NameInFull;

/* Slide 2 Assignment - 4*/
SELECT 
sod.SalesOrderID,
sod.ProductID,
p.Name AS ProductName,
sod.OrderQty,
SUM(sod.OrderQty) AS TotalOrderQty,
AVG(sod.OrderQty) AS AverageOrderQty,
COUNT(sod.OrderQty) AS TotalOrders,
MAX(sod.OrderQty) AS MaxOrderQty,
MIN(sod.OrderQty) AS MinOrderQty
FROM 
Sales.SalesOrderDetail AS sod
JOIN 
Production.Product AS p ON sod.ProductID = p.ProductID
WHERE 
sod.SalesOrderID IN (43659, 43664)
GROUP BY 
sod.SalesOrderID,
sod.ProductID,
p.Name,
sod.OrderQty;


/* Slide 2 Assignment - 5*/
SELECT p.Name, sod.SalesOrderID  
FROM Production.Product AS p  
full JOIN Sales.SalesOrderDetail AS sod  
ON p.ProductID = sod.ProductID  
ORDER BY p.Name;

/* Slide 3 Assignment - 1*/
select Name, SalesOrderID 
from Production.Product as p1 
inner join 
Sales.SalesOrderDetail as p2 
on p1.ProductID = p2.ProductID;

/*Slide 3 Assignment - 2*/
select 
s1.SalesOrderID, s2.TotalDue
from 
Sales.SalesOrderDetail as s1 
inner join 
Sales.SalesOrderHeader as s2
on s1.SalesOrderID = s2.SalesOrderID 
where TotalDue > 100000;

/*Slide 3 Assignment - 3*/
select s1.SalesOrderID, s2.TotalDue
from Sales.SalesOrderDetail as s1 
inner join 
Sales.SalesOrderHeader as s2
on s1.SalesOrderID = s2.SalesOrderID 
where s1.OrderQty > 5 or 
s1.UnitPriceDiscount < 1000 and 
s2.TotalDue > 100;

/*Slide 3 Assignment - 4*/
select 
JobTitle, COUNT(e1.JobTitle), MIN(e2.Rate) as Minimum, MAX(e2.Rate) as Maximum, AVG(e2.Rate) as Average
from HumanResources.Employee as e1
inner join HumanResources.EmployeePayHistory as e2
on e1.BusinessEntityID = e2.BusinessEntityID
group by JobTitle;

/*Slide 3 Assignment - 5*/
select 
p.FirstName, p.LastName, e.VacationHours, e.SickLeaveHours, 
e.VacationHours+e.SickLeaveHours as TotalHours
from Person.Person as p
inner join 
HumanResources.Employee as e
on p.BusinessEntityID = e.BusinessEntityID;

/*Slide 4 Assignment - 1*/
SELECT D.Name  
,E.JobTitle  
,COUNT(E.BusinessEntityID) AS "Employee Count"  
FROM HumanResources.Employee AS E  
INNER JOIN HumanResources.EmployeeDepartmentHistory AS DH  
ON E.BusinessEntityID = DH.BusinessEntityID  
INNER JOIN HumanResources.Department AS D  
ON D.DepartmentID = DH.DepartmentID       
WHERE DH.EndDate IS NULL  
AND D.DepartmentID IN (12,14)  
GROUP BY D.Name, E.JobTitle;

/*Slide 4 Assignment - 2*/
select SalesOrderID, 
MONTH(OrderDate) as OrderMonth, 
SalesPersonID, CustomerID, SubTotal, OrderDate 
from Sales.SalesOrderHeader

/*Slide 4 Assignment - 3*/
SELECT LastName, FirstName FROM Person.Person WHERE BusinessEntityID IN 
(SELECT SalesPersonID FROM Sales.SalesOrderHeader WHERE SalesOrderID IN 
    (SELECT SalesOrderID FROM Sales.SalesOrderDetail WHERE ProductID IN 
        (SELECT ProductID FROM Production.Product WHERE ProductNumber = 'BK-M68B-42')));

/*Slide 4 Assignment - 4*/
select ProductNumber, p1.Name, ListPrice from Production.Product as p1
inner join Production.ProductModel as p2
on p1.ProductModelID = p2.ProductModelID 
where ListPrice > (select 2*avg(listPrice) from Production.Product);


/*Practice*/
select * from table where salary > 
(select salary from table where name = 'rohit');

select * from Person.Person where  ModifiedDate = '2009-01-07';
select NameStyle name from Person.Person;
select businessEntityId, FirstName, LastName, 
case
	when BusinessEntityID < 1000 then 'greater that 500'
	when businessEntityId > 1000 then 'less than 1000'
	else 'else Part'
end as Test
from Person.Person;

select * from employee;
alter table Student rename column course to courses_available;

exec sp_renamedb 'Updated_Piyush','Piyush'
exec sp_rename 'employee.updated_course', 'course', 'column';
alter table employee alter column course varchar(500) primary key;
alter table employee drop constraint PK_EMAIL
ALTER TABLE EMPLOYEE ALTER COLUMN PHONENUMBER BIGINT NOT NULL
ALTER TABLE EMPLOYEE ADD CONSTRAINT PK_EMAIL PRIMARY KEY (EMAILID);
ALTER TABLE EMPLOYEE ALTER COLUMN EMAILID VARCHAR(50) UNIQUE;
ALTER TABLE EMPLOYEE ADD CONSTRAINT UNIQUE_CON UNIQUE (EMAILID);
ALTER TABLE EMPLOYEE DROP CONSTRAINT FK__employee__id__74AE54BC;
ALTER TABLE EMPLOYEE ADD PRIMARY KEY (EMAILID);
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (ID) REFERENCES DEPARTMENT(ID_DEP);
ALTER TABLE eMPLOYEE DROP COLUMN ID

ALTER TABLE EMPLOYEE ADD UNIQUE (ADDRESS);

BEGIN TRANSACTION
DROP TABLE DEPARTMENT;
SELECT * FROM DEPARTMENT;
ROLLBACK;


CREATE TABLE DEPARTMENT(
	ID_DEP INT PRIMARY KEY);


EXEC sp_renamedb 'UPDATED_PIYUSH', 'PIYUSH';

	INSERT INTO DEPARTMENT VALUES(2)
ALTER TABLE EMPLOYEE ADD ID INT FOREIGN KEY (ID) REFERENCES DEPARTMENT(ID_DEP)
ALTER TABLE EMPLOYEE DROP CONSTRAINT [FK__employee__ID__787EE5A0];