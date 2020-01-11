declare
id number(3);
empname char(10);
deptname char(10);
basicsalary char(10);
hra number(2);
ta number(2);
da number(2);
totalsalary number(6);
begin
id :=1;
while (id<6)
loop
	select employee.emp_id, employee.emp_name, department.dept_name, employee.basic_salary
	into id,empname, deptname, basicsalary
	from employee inner join department on
	employee.dept_id = department.dept_id where emp_id = id;
	if (basicsalary>10000) then
		hra := 20;
		ta := 10;
		da := 25;
		totalsalary := basicsalary + ((basicsalary*hra)/100) + ((basicsalary*ta)/100) + ((basicsalary*da)/100);
		insert into salaryslip values (id ,id , empname, deptname,basicsalary, hra,ta,da,totalsalary);
	else 
		hra := 10;
		ta := 5;
		da := 15;
		totalsalary := basicsalary + ((basicsalary*hra)/100) + ((basicsalary*ta)/100) + ((basicsalary*da)/100);
		insert into salaryslip values (id ,id , empname, deptname,basicsalary, hra,ta,da,totalsalary);
	end if;
id := id + 1;
end loop;
end;
/
