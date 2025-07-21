/*=====================================Assignment 3================================================

SET II  (Using the same tables as Assignment 2)*/


select * from dept

select * from emp



--1. Retrieve a list of MANAGERS. 

select m.empno as manager_id, m.ename as manager_name, e.empno as employee_id, e.ename as employee_name from emp e
join emp m on e.mgr_id = m.empno



--2. Find out the names and salaries of all employees earning more than 1000 per month. 

select ename as Employee, sal as Salary from emp where sal > 1000




--3. Display the names and salaries of all employees except JAMES. 

select ename, sal from emp where not ename = 'james' 



--4. Find out the details of employees whose names begin with ‘S’.

select * from emp where ename like 'S%'



--5. Find out the names of all employees that have ‘A’ anywhere in their name. 

select ename as Employee_name from emp where ename like '%A%'



--6. Find out the names of all employees that have ‘L’ as their third character in their name.

select ename as Employee_name from emp where ename like '__L%'



--7. Compute daily salary of JONES. 

select ename as Employee_name , sal / 30 as Daily_salary from emp where ename = 'jones'




--8. Calculate the total monthly salary of all employees. 

select sum(sal) as All_Employees_Monthly_salary from emp



--9. Print the average annual salary . 

select avg(sal * 12) as Average_annual_salary from emp



--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 

select ename, job, sal, deptno from emp where deptno = 30 and not job = 'salesman'



--11. List unique departments of the EMP table.


select distinct deptno from emp



--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.

select ename as Employee, sal as Monthly_salary from emp where sal > 1500 and deptno in (10, 30)



--13. Display the name, job, and salary of all the employees whose job is MANAGER or  ANALYST and their salary is not equal to 1000, 3000, or 5000. 

select ename as Employee, job, sal as Employee_salary from emp where job in ('Manager', 'Analyst') and sal not in (1000,3000,5000)



--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.

select ename, sal, (sal + sal * 0.1) as Commission from emp



--15. Display the name of all employees who have two Ls in their name and are in  department 30 or their manager is 7782

select ename as Employee_name from emp where ename like '%L%L%' and (deptno = 30 or mgr_id = 7782)



--16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees. 

select ename as Employee_name from emp where datediff(year, hiredate, getdate()) > 30 and datediff(year, hiredate, getdate()) < 40



--17. Retrieve the names of departments in ascending order and their employees in descending order. 

select d.dname as department_name, e.ename as employee_name from dept d
join emp e on d.deptno = e.deptno
order by d.dname, e.ename desc


--18. Find out experience of MILLER.

select ename, datediff(year, hiredate, getdate()) as experience_years from emp where ename = 'miller'




/*=================================Assignment 4==================================*/


--1.	Write a T-SQL Program to find the factorial of a given number.

declare @n int = 5
declare @fact bigint = 1
declare @i int = 1

while @i <= @n
begin
    set @fact = @fact * @i
    set @i = @i + 1
end

select @n as number, @fact as factorial


--2.	Create a stored procedure to generate multiplication table that accepts a number and generates up to a given number. 

create or alter proc generate_multiplication_table @number int, @limit int
as
begin
    declare @i int = 1
    print 'multiplication table for ' + cast(@number as varchar) + ' up to ' + cast(@limit as varchar) + ':'

    while @i <= @limit
    begin
        print cast(@number as varchar) + ' x ' + cast(@i as varchar) + ' = ' + cast(@number * @i as varchar)
        set @i = @i + 1
    end
end



exec generate_multiplication_table @number = 7, @limit = 10



--	question 3

create table student(sid int primary key, sname varchar(50))

create table marks(mid int primary key, sid int constraint fs foreign key references student(sid),score int)


insert into student values (1, 'Jack'), (2, 'Rithvik'), (3, 'Jaspreeth'), (4, 'Praveen'), (5, 'Bisa'), (6, 'Suraj')

select * from student

insert into marks values(1, 1, 23), (2, 6, 95), (3, 4, 98), (4, 2, 17), (5, 3, 53), (6, 5, 13)

select * from marks
	

create function dbo.fn_get_status(@score int) returns varchar(10)
as
begin
    declare @status varchar(10);

    if @score >= 50
        set @status = 'pass';
    else
        set @status = 'fail';
    return @status
end


select s.sid, s.sname, m.score, dbo.fn_get_status(m.score) as status from student s
join marks m on s.sid = m.sid





