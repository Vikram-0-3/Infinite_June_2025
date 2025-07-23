
/*========================Code Challenge 5=====================================*/



--1.	Write a query to display your birthday(day of week)

select datename(weekday, '2003-01-06') as day_in_week



--2.	Write a query to display your age in days

select datediff(day, '2003-01-06', getdate()) as age_in_days


--3.	Write a query to display all employees information those who joined before 5 years in the current month


use SQL_Assignments

select * from emp

insert into emp values(7444, 'Vikram', 'Admin', 7839, '2019-07-01', 10000, null, 30)

select * from emp where month(hiredate) = month(getdate()) and year(hiredate) <= year(getdate()) - 5



--4.	Create table Employee with empno, ename, sal, doj columns or use your emp table and perform the following operations in a single transaction
--	a. First insert 3 rows 
--	b. Update the second row sal with 15% increment  
--  c. Delete first row.
--After completing above all actions, recall the deleted row without losing increment of second row.



use CodeChallenge

select * from employees

-- There is already employees table mam, but i dont want to use it so i'll create freshly

create table employee(empno int primary key, ename varchar(30), sal float,doj date)
select * from employee
insert into employee values(1, 'Vikram', 12000, '2024-01-06'),(2, 'Eakesh', 20000, '2024-02-06'),(3, 'Yokesh', 8000, '2025-03-06'),(4, 'Pradeep', 15000, '2023-10-06')

drop table employee

begin transaction
begin
	insert into employee values(5, 'Rajan', 30000, '2018-05-10'),(6, 'Vignesh', 40000, '2020-07-20'),(7, 'KK', 35000, '2021-11-01')
	update employee set sal = sal*1.15 where empno = 2
	declare @del_row table(empno int,ename varchar(30),sal float, doj date)
	insert into @del_row select top 1 * from employee
	delete from employee where empno = (select top 1 empno from employee)

	insert into employee (empno,ename,sal,doj)
	select empno, ename, sal, doj from @del_row
end
commit



--5.      Create a user defined function calculate Bonus for all employees of a  given dept using 	following conditions
--	a.     For Deptno 10 employees 15% of sal as bonus.
--	b.     For Deptno 20 employees  20% of sal as bonus
--	c      For Others employees 5%of sal as bonus


use SQL_Assignments

select * from emp

create or alter function bonus_calc(@deptno int, @sal float) returns float
as
begin
    declare @bonus float
    if @deptno = 10
        set @bonus = @sal * 0.15
    else if @deptno = 20
        set @bonus = @sal * 0.20
    else
        set @bonus = @sal * 0.05
    return @bonus
end


select empno, ename, sal, deptno, dbo.bonus_calc(deptno, sal) as bonus
from emp



--6. Create a procedure to update the salary of employee by 500 whose dept name is Sales and current salary is below 1500 (use emp table)


select * from emp

select * from departments


-- sorry mam, i have used testing instead of sales as there is no sales in my table also there is no time to insert it

create procedure sal_update
as
begin
    update e set e.sal = e.sal + 500 from emp e
    join departments d on e.deptno = d.deptno where d.dname = 'testing' and e.sal < 1500
end

exec sal_update





