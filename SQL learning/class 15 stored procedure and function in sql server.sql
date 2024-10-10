

/*------------------------Class 15 (Stored Procedure and function in sql server)-----------------------*/

-- Q) Diff betn SP vs Func
 /* 
    if we want to repeat query or work .
    Tho uss stored procedure ke andhar jitni query hongi wo automatic run ho jaingi jo task ke liyeh 
    humne banai hai uss hisab se
*/

-- how to create procedure ?
create procedure dbo.usp_GetEmployee
As 
Begin
select * from Employee	
End

--execute stored  procedure
exec usp_GetEmployee


-- to update or delete 

alter procedure usp_GetEmployee
As 
Begin
delete from Employee where id=1
select * from Employee	
End


--------------------------------------------------------

-- ab yaha par user se input lenge yani user decide karega ki konsa data chahiyeh
-- stored procedure with parameters


create procedure dbo.ups_GetEmployeeByCity
(
	@city varchar(300)
)
as
begin
select * from Employee where city=@city
end

exec ups_GetEmployeeByCity 'mumbai'



-- stored procedure with multiple condition. // UPSERT(update+insert)

create procedure usp_upsertemp123
(
	@Id int,
	@Name varchar(300),
	@City varchar(300),
	@Salary int	,
	@dept_id int
)

as
Begin
	--write code here
	if (select count(id) from Employee where id=@id)=1    

	begin
	update Employee set Name=@name ,city=@city,Salary=@salary,Dept_Id=@dept_id
	 where id=@id
	end



	else

	begin
	insert into Employee values(@id,@name,@city,@salary,@dept_id)
	end

End

select * from Employee
exec usp_upsertemp123 2,'sanket','Pune',45000,1 --// here first condition is matched so it will update it because 2 exists there and it is only one time








/*----------------Functions----------------- */






