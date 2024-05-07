--Assignment 1
CREATE TABLE Production.Quantity (
    ProductID INT PRIMARY KEY,
    AvailableQuantity INT NOT NULL,
    UnitPrice DECIMAL(10,2) NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL
);


CREATE TABLE Production.Sales (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    TotalPrice DECIMAL(10, 2) NOT NULL,
    DateOfSales DATE NOT NULL,
    Discount DECIMAL(10, 2) NOT NULL,
	FOREIGN KEY (ProductID)
	REFERENCES Quantity(ProductID)
);


INSERT INTO Production.Quantity VALUES
(1, 100, 20.50, 2050.00),
(2, 150, 30.75, 4612.50),
(3, 200, 15.00, 3000.00),
(4, 120, 22.95, 2754.00),
(5, 180, 18.75, 3375.00),
(6, 50, 45.00, 2250.00),
(7, 75, 10.00, 750.00),
(8, 60, 12.50, 750.00),
(9, 90, 5.75, 517.50),
(10, 110, 9.00, 990.00);

INSERT INTO Production.Sales VALUES
(1, 'Widget', 20, 20.50, 410.00, '2024-04-01', 0.00),
(2, 'Gadget', 30, 30.75, 922.50, '2024-04-02', 1.50),
(3, 'Thingy', 25, 15.00, 375.00, '2024-04-03', 0.00),
(4, 'Doohickey', 18, 22.95, 413.10, '2024-04-04', 2.00),
(5, 'Gizmo', 15, 18.75, 281.25, '2024-04-05', 0.75),
(6, 'Gismo', 5, 45.00, 225.00, '2024-04-06', 1.25),
(7, 'Widget Pro', 7, 10.00, 70.00, '2024-04-07', 0.00),
(8, 'Gadget Plus', 6, 12.50, 75.00, '2024-04-08', 0.50),
(9, 'Thingy Max', 9, 5.75, 51.75, '2024-04-09', 0.25),
(10, 'Doohickey Mini', 11, 9.00, 99.00, '2024-04-10', 1.00);

SELECT * FROM Production.Sales;
SELECT * FROM Production.Quantity;

SELECT * FROM Production.Sales AS s
INNER JOIN	Production.quantity AS q
ON s.ProductID = q.ProductID
WHERE S.Quantity = 
	(SELECT MAX(Quantity) FROM Production.Sales);

--ASSIGNMENT 2
CREATE TABLE Sales.Promotion (
    PromotionID INT PRIMARY KEY,
    PromotionName VARCHAR(255) NOT NULL,
    DiscountAmount DECIMAL(10, 2) CHECK (DiscountAmount > 0),
    MinimumPurchaseAmount DECIMAL(10, 2) CHECK (MinimumPurchaseAmount > 10),
    StartDate DATE,
    EndDate DATE ,
	CHECK (EndDate > StartDate),
);

INSERT INTO sales.promotion VALUES
(1, 'Summer Extravaganza', 20.00, 100.00, '2024-06-01', '2024-06-30'),
(2, 'New Year Kickoff', 50.00, 200.00, '2024-01-01', '2024-01-31'),
(3, 'Back to School', 15.00, 50.00, '2024-08-01', '2024-08-20'),
(4, 'Winter Wonderland', 35.00, 150.00, '2024-12-01', '2024-12-25'),
(5, 'Spring Fling', 25.00, 80.00, '2024-04-01', '2024-04-30');

SELECT * FROM Sales.promotion;

--ASSIGNMENT 3
CREATE VIEW CustomerSummary AS(
	SELECT COUNT(distinct CustomerID) AS CustomerCount, 
	ORDERDATE, 
	AVG(TotalDue) AS AverageSales, 
	SUM(TotalDue) AS TotalSales  
	FROM sALES.SalesOrderHeader 
	GROUP BY  OrderDate)

select * from CustomerSummary
order by orderdate;

--ASSIGNMENT 4
CREATE VIEW SalesPersonSummary AS(
select * from(
	SELECT 
		SalesPersonID, 
		concat(p.firstname,' ',p.lastname) as fullName,
		SUM(soh.TotalDue) over(partition by salespersonid)  AS TotalPurchase, 
		AVG(soh.TotalDue) over(partition by salespersonid) AS AveragePurchase ,
		row_number() over(partition by salespersonid order by salespersonid) as rowNumber
	FROM sales.SalesOrderHeader as soh
	inner join sales.SalesPerson as sp
	on soh.SalesPersonID = sp.BusinessEntityID
	inner join person.Person as p
	on sp.BusinessEntityID = p.BusinessEntityID) as t
	where rowNumber = 1
)
select * from SalesPersonSummary

--ASSIGNMENT 5
SELECT p.ProductID, p.Name AS ProductName, p.ProductNumber, l.Availability, l.Name as Location
INTO ProductDetails FROM
Production.Product AS p
INNER JOIN Production.ProductInventory AS pi ON p.ProductID = pi.ProductID
INNER JOIN Production.Location AS l ON pi.LocationID = l.LocationID;

SELECT * FROM ProductDetails;

--ASSIGNMENT 6
CREATE PROCEDURE getEmployeeDetails 
AS
	SELECT CONCAT(p.FirstName,' ',p.MiddleName,' ',p.LastName) AS FullName,e.JobTitle ,e.NationalIDNumber
	FROM HumanResources.Employee AS e
	INNER JOIN person.person AS p
	ON e.BusinessEntityID = p.BusinessEntityID
GO

EXEC getEmployeeDetails;

--ASSIGNMENT 7
CREATE PROCEDURE getSalesPersonSummary @eID INT
AS
	SELECT sp.BusinessEntityID,
		CONCAT(p.FirstName,' ',p.MiddleName,' ',p.LastName) AS FullName, 
		sp.SalesQuota, 
		sp.SalesYTD, 
		(sp.SalesYTD-sp.SalesQuota) AS Comparision 
		FROM Sales.SalesPerson AS sp
		INNER JOIN Person.Person AS p ON sp.BusinessEntityID = p.BusinessEntityID
		WHERE sp.BusinessEntityID = @eID;
GO
--    274-290
EXEC getSalesPersonSummary 276

--ASSIGNMENT 8
CREATE PROCEDURE getProductRankingByQuantity
AS
	SELECT ProductID, Name, Quantity,
	DENSE_RANK() OVER(PARTITION BY pi.locationID ORDER  BY Quantity DESC) AS ranking
	From Production.ProductInventory AS pi
	LEFT JOIN production.location AS l
	ON pi.LocationID = l.LocationID
GO

EXEC getProductRankingByQuantity

--ASSIGNMENT 9
CREATE PROCEDURE getTopTenEmployee 
AS
	SELECT * FROM(
		SELECT *, DENSE_RANK() OVER(ORDER  BY rate DESC ) AS rowNumber
		FROM HumanResources.EmployeePayHistory) AS t
	WHERE rowNumber <= 10
GO

EXEC getTopTenEmployee;

--ASSIGNMENT 10
CREATE PROCEDURE getTotalSales
AS
	SELECT Year(OrderDate) AS SalesYear, SUM(totaldue) AS TotalSales 
	FROM Sales.SalesOrderHeader 
	GROUP  BY YEAR(OrderDate) 
	ORDER BY SalesYear;
GO

EXEC getTotalSales



--TOP 10 SALES PERSON WHO HAVE MADE MOST SALES
create procedure top10SalesPerson
as
	select * from (
		SELECT TotalDue, concat(p.firstName,' ',p.MiddleName,' ', p.lastName) as FullName,
		DENSE_RANK() over(order by TotalDue desc) as RowNumber
		FROM 
		Sales.SalesPerson AS sp 
		inner join Sales.SalesOrderHeader AS soh on sp.BusinessEntityID = soh.SalesPersonID
		inner join Person.Person AS p on p.BusinessEntityID = sp.BusinessEntityID) as t
	where t.RowNumber <=10
go

exec top10SalesPerson;