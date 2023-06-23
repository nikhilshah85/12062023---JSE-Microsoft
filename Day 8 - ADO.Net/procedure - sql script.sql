
--Get Employee By Id
create procedure proc_getEmpById(@empNo int)
as
begin
	select * from employeeDetails where empNo = @empNo
end

--Get All Employees
create procedure proc_GetAllEmployees
as
begin
	select * from employeeDetails
end

--Insert Employee
create procedure proc_AddNewEmployee(@empNo int out, @empName varchar(20),@empDesignation varchar(20),@empSalary int,@empIsPermenant bit)
as
begin
	declare @newEmpNo int = 0;
	set @newEmpNo = (select max(empno) + 1 from  employeeDetails)
	insert into employeeDetails values(@newEmpNo,@empName, @empDesignation, @empSalary, @empIsPermenant)
end

--Delete employee
create procedure proc_deleteEmp(@empNo int)
as
begin
	delete from employeeDetails where empNo = @empNo
end

--update employee
create procedure proc_updateEmployee(@empNo int,@newName varchar(20),@newDesignation varchar(20),@newSalary int,@empIsPermenant bit)
as
begin
	update employeeDetails set empName = @newName, empDesgiantion = @newDesignation,empSalary = @newSalary, empIsPerment = @empIsPermenant
		where empNo = @empNo
end

















