
/*Class 12*/
-- Create Database
create database itexpertera2024

-- use our database
use itexpertera2024

-- create table
create table Employee
(
ID int,
Name varchar(300),
City varchar(100),
Salary int
)


-- Select command
select * from Employee
select Id,Name from Employee

-- Insert command
insert into Employee values (1,'Sanket','Pune',50000);
insert into Employee values (2,'Amit','Mumbai',87000);
insert into Employee values (3,'Ashraf','Dharashiv',90000);
insert into Employee values (4,'Aman','Mumbai',100000);
insert into Employee values (5,'Dipesh','Mumbai',100000);
-- update
update Employee set Name='Ishant',City='punjab' where Name='Ashraf';

--Delete
delete from Employee where Name='Aman' 

--Truncate // to delete whole table 
truncate table Employee

/*-----------------------------Class 13-----------------------------*/

-- to select from one particular condition
select * from Employee where city='mumbai'



-- and 
select * from Employee where city='latur' and Salary>2000


-- or
select * from Employee where city='latur' or Salary>2000


-- not equal to
select * from Employee where city <> 'Mumbai'


-- like
select * from Employee where name like 'A%' -- A% means start A se hoga piche kuch bhi ho
select * from Employee where name like '%f' -- agar last ka letter pata hai tho
select * from Employee where name like '%h%'  -- agar middle letter pata hai tho
select * from Employee where name like '_s%' -- agar second letter pata hai tho


--Group by
-- if I want to know in which city how many employees were living for that we use (group by) query

	/*Conditions of group by*/
-- group by ke sath where nahi lagate
-- group by ke sath having lagate hai
-- yaha pr select mai jo column hai ya aggregate function mai hai wahi group by mai lena padega
select city,COUNT(City) as No_of_cities from Employee group by city having count(city) > 1

/*group by on the basis of two columns*/  -- two coloumns mai (Sanket,Pune) ko ek(1) manega
select Name,city,COUNT(City) as No_of_cities from Employee group by city,Name having count(city) > 0



--Order by
select * from Employee order by Salary desc
select * from Employee order by city,Salary desc



-- Top keyword
select top 3 * from Employee
select top 3 * from Employee order by City



-- sum keyword
select sum(salary) from Employee


-- max & min & average keywords      // we cannot use other column with it
select max(salary) from Employee
select min(salary) from Employee 
select avg(salary) from Employee



-- what is null // null ka matlab kuch nhi nahi
-- empty ka matlab ek value hai jo khali hai
insert into Employee values(6,null,'',454875)
select * from Employee where name='null'; -- it will not show  us
select * from Employee where name is null;  -- it will show us
select * from Employee where name is not null;
select * from Employee where city='';



-- in keyword

--if i have to select between five cities
select * from Employee where city in ('Dharashiv','jamnagar','surat','mumbai','Pune')
select * from Employee where city not in ('Dharashiv','jamnagar','surat','mumbai','Pune')
-- Q) aisa record chahiyeh jo pune ya mumbai mai rehta ho
select * from Employee where city='pune' or city='mumbai';




-- Distinct 

--// if we want to check in which cities our employee are living or working

select distinct city from Employee  -- sare cities 1 bar aa jainge kyu hamne ek distinct city dekhni hai


 select * from Employee where (city='mumbai' and salary>500) or (city='pune' and Salary>5000)
  


  /*-----------------------------Class 14 (join query)-----------------------------*/

 create table Department
 (
 DeptId int,
 DeptName varchar(300)
 )

insert into Department values(1,'HR')
insert into Department values(2,'Finance')
insert into Department values(3,'Operation')
insert into Department values(4,'IT')
insert into Department values(5,'Admin')


select * from Employee
select * from Department


-- to add column in employee table

Alter table employee
add Dept_Id int

update Employee set Dept_id =5 where id=5
update Employee set name='Anjali',dept_id=1 where id=6 
insert into Employee values(8,'simran','goa',343454,null)

  -- Join Query -> when we need data from two or more table.



  


