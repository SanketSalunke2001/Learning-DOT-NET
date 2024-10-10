

select * from Employee
/*class 14 join*/

select * from Department

-- Q) Get the employee names with their department names ?
	-- by using join

	--1.inner join or join :- jo match hogi wahi aaigi
	select [Name],deptname from Employee join Department on Employee.Dept_Id =Department.DeptId

	--2.left join:-
	-- ab ismai ajit and simran tho aa jaiga lekin finance nahi aaiga
	select [Name],deptname from Employee left join Department on Employee.Dept_Id =Department.DeptId

	--3.Right join:-
	-- ab ismai ajit and simran nahi aainge lekin finance aaiga
	select [Name],deptname from Employee right join Department on Employee.Dept_Id =Department.DeptId

	--4.Full join :- sab kuch aaiga 
	select [Name],deptname from Employee full join Department on Employee.Dept_Id =Department.DeptId

	--------------------------------------------

	create table Table1
	(
	Id int
	)
	insert into Table1 values(1)
	
	
	select * from Table1
	select * from table1 A join Table1 b on a.Id=b.Id -- yaha pr two columns hai tho two columns hie aainge







