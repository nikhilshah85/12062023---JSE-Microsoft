create database employeeManagement

use employeeManagement

create table employeeDetails
(
	empNo int primary key,
	empName varchar(20),
	empDesgiantion varchar(20),
	empSalary bigint,
	empIsPerment bit
	)

	insert into employeeDetails values(101,'Nikhil','Trainer',5000,1)
	insert into employeeDetails values(102,'Roshni','HR',6000,0)
	insert into employeeDetails values(103,'Hemali','Sales',7000,0)

	select * from employeeDetails