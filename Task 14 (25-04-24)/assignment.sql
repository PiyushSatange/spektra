/*Assignment - 2*/
select * from Production.Product;

/*Assignment - 3*/
CREATE DATABASE Piyush 
ON Primary
(
	NAME = Piyush_dat,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Piyush_dat.mdf',
    SIZE = 10 MB,
    MAXSIZE = 50 MB,
    FILEGROWTH = 5 MB
)
LOG ON
(NAME = Piyush_log,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Piyush_log.ldf',
    SIZE = 5 MB,
    MAXSIZE = 25 MB,
    FILEGROWTH = 5 MB
);

/*Assignment - 4*/
create table Student(
	id int primary key,
	name varchar(20),
	address varchar(200),
	course varchar(50),
	emailId varchar(100)
);

/*Assignment - 5*/
insert into Student(id, name, address, course, emailId) values
	(1, 'Piyush', 'Bangalore', 'Computer Science', 'piyush@gmail.com'),
	(2, 'Yash', 'Pune', 'Information Technology', 'yash@gmail.com'),
	(3, 'Mayur', 'Mumbai', 'Mechanical', 'mayur@gmail.com'),
	(4, 'Atharv', 'Chennai', 'Civil', 'atharv@gmail.com'),
	(5, 'Deep', 'Hydrabad', 'Electronics', 'deep@gmail.com');

/*Assignment - 6*/
alter table Student add phoneNumber bigint;

update Student set phoneNumber = 9607772094 where id = 1;
update Student set phoneNumber = 9384756129 where id = 2;
update Student set phoneNumber = 1234567890 where id = 3;
update Student set phoneNumber = 9158732132 where id = 4;
update Student set phoneNumber = 9089786756, name = 'Om' where id = 5;

select name, address from Student;


