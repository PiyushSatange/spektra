--Assignment 1
CREATE TABLE STUDENTS(
	STUDID INT NOT NULL,
	STUDNAME VARCHAR(50) NOT NULL,
	STUDAGE INT NOT NULL CHECK (STUDAGE >= 18), 
	STUDADDRESS VARCHAR(200) NOT NULL
);

INSERT INTO STUDENTS VALUES (1, 'PIYUSH', 16, 'BANGALORE');

--Assignment 2
CREATE TABLE SALES(
	SalesID int not null,
	CustomerId int not null,
	CustomerName varchar(50) not null,
	Location  varchar(50) not null,
	Commission int not null,
	TotalSales int not null,
	CONSTRAINT Check_Commission CHECK(
	(Location = 'london' AND commission > 1000) OR 
	(Location = 'US' AND commission < 1000)
	)
);

insert into sales values (1, 1, 'piyush', 'us', 2000, 50000);

--Assignment 3
select P.ProductID, P.Name
from Production.Product as p
inner join 
Production.ProductReview as r
on p.ProductID = r.ProductID
where r.Rating = (select MAX(Rating) FROM Production.ProductReview);


--Assignment 4
SELECT T1.CustomerID, T1.TotalDue, T1.OrderDate FROM SALES.SalesOrderHeader AS T1 INNER JOIN 
(SELECT C.CUSTOMERID, MAX(TOTALDUE) AS MAXTOTAL 
FROM SALES.Customer AS C
INNER JOIN 
SALES.SalesOrderHeader AS H
ON C.CustomerID = H.CustomerID  GROUP BY C.CustomerID) AS T2
ON T1.CustomerID = T2.CustomerID AND 
T1.TotalDue = T2.MAXTOTAL;

--Assignment 5
select  t1.EmployeeID, t2.fullName, t1.OrderDate, t1.VendorID, t2.maxDue 
from Purchasing.PurchaseOrderHeader as t1 
inner join
	(
	select p2.EmployeeID,CONCAT(p1.FirstName,' ', p1.LastName) as fullName, p2.maxDue 
	from Person.Person as p1 
	inner join 
		(
		select EmployeeID, max(TotalDue) as maxDue 
		from Purchasing.PurchaseOrderHeader 
		group by  EmployeeID
		) as p2
		on p1.BusinessEntityID = p2.EmployeeID
	) as t2 
	on t1.EmployeeID = t2.EmployeeID and t2.maxDue = t1.TotalDue;

create procedure getProductdetails @pid int output as 
begin
select sum(p.Weight) from Production.Product as p where p.ProductID = 995;
end;
select * from Production.Product;
exec getProductdetails 995;

create procedure showAllRecords
as 
select * from person.person;
go

exec showAllRecords;

create procedure showAllIds
as
select BusinessEntityID from person.Person;
go

execute showAllIds;

create procedure findFirstName @name varchar(50)
as
select * from person.person where FirstName = @name;
go

exec findFirstName @name = 'ken';

create procedure findByfirstNameAndLastName @firstName varchar(255), @lastName varchar(255)
as
select * from Person.Person where FirstName = @firstName and LastName = @lastName;
go

exec findByfirstNameAndLastName 'ken', 'myer';

create procedure getAllByPersonType @type varchar(50), @personCount int output
as
select @personCount = count(*) from person.person where PersonType = @type;
go

declare @totalCount int
exec getAllByPersonType 'em', @totalCount output;
--if(@totalCount is null)
--	print 'it is null'
--else
--	print 'it is not null'
print @totalCount