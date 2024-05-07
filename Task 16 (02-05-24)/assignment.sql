-- Assignment 1
select pr.ProductID, pr.Name, max(pc.OrderQty) AS TotalTransactionQuantity,
dense_rank() over (order by max(pc.OrderQty) desc) as RankNo
from Production.Product as pr
inner join Purchasing.PurchaseOrderDetail as pc
on pr.ProductID = pc.ProductID
group by pr.ProductID, pr.Name
order by TotalTransactionQuantity desc;


-- Assignment 2
select concat(t1.FirstName, ' ', t1.LastName) as fullName, TotalSales, dense_rank() over(order by t2.totalsales desc) as ranking from person.person as t1
inner join 
(select s.salespersonID, sum(totaldue) as TotalSales from 
	sales.SalesOrderHeader s
	inner join
	person.person as p
	on s.SalesPersonID = p.BusinessEntityID group by s.SalesPersonID) as t2
on t1.BusinessEntityID = t2.SalesPersonID	

--Assignment 3
select concat(firstname, ' ', lastname) as fullName, JobTitle, VacationHours from 
Person.Person as p
inner join 
HumanResources.Employee as e
on p.BusinessEntityID = e.BusinessEntityID 
where VacationHours = 
(select max(VacationHours) from HumanResources.Employee);

--Assignment 4
select t2.SalesPersonID, concat(t1.FirstName,' ', t1.LastName) as fullName, t2.SalesYear, 
LAG(t2.TotalSales) over(partition by t2.salesPersonId order by t2.salesYear) as PrevYearSales, t2.TotalSales as CurrYearSales,  
t2.TotalSales-(LAG(t2.TotalSales) over(partition by t2.salesPersonID order by t2.salesYear)) as Difference,
case
        when t2.TotalSales - LAG(t2.TotalSales) over (partition by t2.SalesPersonID order by t2.SalesYear) > 0 then 'Performance is Good'
        when t2.TotalSales - LAG(t2.TotalSales) over (partition by t2.SalesPersonID order by t2.SalesYear) < 0 then 'Performance is not Good'
		when t2.TotalSales - LAG(t2.TotalSales) over (partition by t2.SalesPersonID order by t2.SalesYear) is null then 'Previous Data not Available'
        else 'Performance is Same'
end as Review
from Person.Person as t1
inner join (
select h.SalesPersonID, year(h.orderDate) as SalesYear, sum(TotalDue) as TotalSales from Sales.SalesOrderHeader  as h
inner join Person.Person as p
on h.SalesPersonID = p.BusinessEntityID
group by h.SalesPersonID, year(h.OrderDate)) as t2
on t1.BusinessEntityID = t2.SalesPersonID;


--Assignment 5
select  * from 
(select p.ProductID, color, Quantity from Production.ProductInventory p inner join Production.Product r on p.ProductID = r.ProductID) as t
pivot
(
	sum(quantity)
	for color
	in ([Black],[Blue],[Gray],[Multi],[Red],[Silver],[White],[Yellow])
)
as pivotTable

--Assignment 6
SELECT * FROM (
SELECT pp.ProductID, orderdate, TotalDue  
FROM Production.Product AS pp
INNER JOIN Sales.SalesOrderDetail as sod ON pp.ProductID = sod.ProductID 
INNER JOIN Sales.SalesOrderHeader soh ON sod.SalesOrderDetailID = soh.SalesOrderID ) as Temp
PIVOT
(
    sum(TotalDue)
    for orderdate
    in ([2011],[2012],[2013],[2014])
) AS pivotTable



drop table employee;
create table employee
( emp_ID int primary key
, emp_NAME varchar(50) not null
, DEPT_NAME varchar(50)
, SALARY int);

insert into employee values(101, 'Mohan', 'Admin', 4000);
insert into employee values(102, 'Rajkumar', 'HR', 3000);
insert into employee values(103, 'Akbar', 'IT', 4000);
insert into employee values(104, 'Dorvin', 'Finance', 6500);
insert into employee values(105, 'Rohit', 'HR', 3000);
insert into employee values(106, 'Rajesh',  'Finance', 5000);
insert into employee values(107, 'Preet', 'HR', 7000);
insert into employee values(108, 'Maryam', 'Admin', 4000);
insert into employee values(109, 'Sanjay', 'IT', 6500);
insert into employee values(110, 'Vasudha', 'IT', 7000);
insert into employee values(111, 'Melinda', 'IT', 8000);
insert into employee values(112, 'Komal', 'IT', 10000);
insert into employee values(113, 'Gautham', 'Admin', 2000);
insert into employee values(114, 'Manisha', 'HR', 3000);
insert into employee values(115, 'Chandni', 'IT', 4500);
insert into employee values(116, 'Satya', 'Finance', 6500);
insert into employee values(117, 'Adarsh', 'HR', 3500);
insert into employee values(118, 'Tejaswi', 'Finance', 5500);
insert into employee values(119, 'Cory', 'HR', 8000);
insert into employee values(120, 'Monica', 'Admin', 5000);
insert into employee values(121, 'Rosalin', 'IT', 6000);
insert into employee values(122, 'Ibrahim', 'IT', 8000);
insert into employee values(123, 'Vikram', 'IT', 8000);
insert into employee values(124, 'Dheeraj', 'IT', 11000);

select * from employee;

select * from employee e inner join (
	select DEPT_NAME, count(*) as empCount, min(salary) as MinSalary, max(salary) as maxSalary from employee group by DEPT_NAME) as t
on e.DEPT_NAME = t.DEPT_NAME and e.SALARY = t.maxSalary or e.SALARY = t.MinSalary;

SELECT * FROM HumanResources.EmployeePayHistory