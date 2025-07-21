/*===========================================Assignment 1=====================================================

A small IT firm designing business software for its clients wants to store and manage its data.
It has identified following entities for which, it will maintain data.
Clients Employees
Departments
Projects
EmpProjectTasks *
* This will hold data of employees working on projects.
You are required to create the tables using the information provided below. Once tables are ready, fill in the given data in each table.
NOTE: Submit the CREATE TABLE, INSERT and SELECT commands as answer to this assignment.
The tables below describe attributes for each entity.*/

/*=================CREATION & SELECTION OF TABLES*====================*/

create table clients(client_id numeric(4) primary key,Cname varchar(40) not null, 
address varchar(30), email varchar(30) unique, phone numeric(10), business varchar(30) not null)


create table employees(empno numeric(4) primary key, ename varchar(20) not null, 
job varchar(15), salary decimal(15,4) check (salary > 0 ), 
deptno numeric(2) constraint f foreign key references departments(deptno) )

create table departments(deptno numeric(2) primary key, dname varchar(20) not null , loc varchar(20))


create table projects(project_id numeric(3) primary key, Descr varchar(30) not null, start_date date, planned_enddate date, actual_enddate date, check(actual_enddate > planned_enddate ), budget numeric(10) check(budget > 0), client_id numeric(4) constraint f1 foreign key references clients(client_id) )


create table empprojecttasks (project_id numeric(3) references projects(project_id), empno numeric(4) references employees(empno),start_date date, end_date date,
task varchar(25) not null, status varchar(15) not null, primary key (project_id, empno) )


select * from clients

select * from employees

select * from departments

select * from projects

select * from empprojecttasks

/*=================INSERTION INTO TABLES====================*/



insert into clients values(1001, 'acme utilities', 'noida', 'contact@acmeutil.com', 9567880032, 'manufacturing'),
(1002, 'trackon consultants', 'mumbai', 'consult@trackon.com', 8734210090, 'consultant'),
(1003, 'moneysaver distributors', 'kolkata', 'save@moneysaver.com', 7799886655, 'reseller'),
(1004, 'lawful corp', 'chennai', 'justice@lawful.com', 9210342219, 'professional')




insert into departments values(10, 'design', 'pune'),
(20, 'development', 'pune'),
(30, 'testing', 'mumbai'),
(40, 'document', 'mumbai')



insert into employees values(7001, 'sandeep', 'analyst', 25000, 10),
(7002, 'rajesh', 'designer', 30000, 10),
(7003, 'madhav', 'developer', 40000, 20),
(7004, 'manoj', 'developer', 40000, 20),
(7005, 'abhay', 'designer', 35000, 10),
(7006, 'uma', 'tester', 30000, 30),
(7007, 'gita', 'tech. writer', 30000, 40),
(7008, 'priya', 'tester', 35000, 30),
(7009, 'nutan', 'developer', 45000, 20),
(7010, 'smita', 'analyst', 20000, 10),
(7011, 'anand', 'project mgr', 65000, 10)



insert into projects values(401, 'inventory', '01-apr-11', '01-oct-11', '31-oct-11', 150000, 1001),
(402, 'accounting', '01-aug-11', '01-jan-12', null, 500000, 1002),
(403, 'payroll','01-oct-11','31-dec-11', null, 75000, 1003),
(404, 'contact mgmt','01-nov-11','31-dec-11', null, 50000, 1004)


insert into empprojecttasks values(401, 7001, '01-apr-11', '20-apr-11', 'system analysis', 'completed'),
(401, 7002, '21-apr-11', '30-may-11', 'system design', 'completed'),
(401, 7003, '01-jun-11', '15-jul-11', 'coding', 'completed'),
(401, 7004, '18-jul-11', '01-sep-11', 'coding', 'completed'),
(401, 7006, '03-sep-11', '15-sep-11', 'testing', 'completed'),
(401, 7009, '18-sep-11', '05-oct-11', 'code change', 'completed'),
(401, 7008, '06-oct-11', '16-oct-11', 'testing', 'completed'),
(401, 7007, '06-oct-11', '22-oct-11', 'documentation', 'completed'),
(401, 7011, '22-oct-11', '31-oct-11', 'sign off', 'completed'),
(402, 7010, '01-aug-11', '20-aug-11', 'system analysis', 'completed'),
(402, 7002, '22-aug-11', '30-sep-11', 'system design', 'completed'),
(402, 7004, '01-oct-11', null, 'coding', 'in progress')





/*===========================================Assignment 1=====================================================*/



create table dept(deptno int primary key, dname varchar(30), loc varchar(30))

select * from dept

insert into dept values(10, 'accounting', 'new york'),
(20, 'research', 'dallas'),
(30, 'sales', 'chicago'),
(40, 'operations', 'boston')


create table emp(empno int primary key, ename varchar(30), job varchar(20), mgr_id int, hiredate date, sal int, comm int, deptno int constraint f3 foreign key references dept(deptno))

select * from emp

truncate table emp

insert into emp values(7369, 'smith', 'clerk', 7902, '1980-12-17', 800, null, 20),
(7499, 'allen', 'salesman', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'ward', 'salesman', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'jones', 'manager', 7839, '1981-04-02', 2975, null, 20),
(7654, 'martin', 'salesman', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'blake', 'manager', 7839, '1981-05-01', 2850, null, 30),
(7782, 'clark', 'manager', 7839, '1981-06-09', 2450, null, 10),
(7788, 'scott', 'analyst', 7566, '1987-04-19', 3000, null, 20),
(7839, 'king', 'president', null, '1981-11-17', 5000, null, 10),
(7844, 'turner', 'salesman', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'adams', 'clerk', 7788, '1987-05-23', 1100, null, 20),
(7900, 'james', 'clerk', 7698, '1981-12-03', 950, null, 30),
(7902, 'ford', 'analyst', 7566, '1981-12-03', 3000, null, 20),
(7934, 'miller', 'clerk', 7782, '1982-01-23', 1300, null, 10)



--query 1

select * from emp where ename like 'a%'

--query 2

select * from emp where mgr_id is null

--query 3

select ename, empno, sal from emp where sal between 1200 and 1400

--query 4

--before view 
select empno , ename from emp e left join
dept d on e.deptno = d.deptno where d.dname = 'Research'

--after view
update emp
set sal = sal * 1.1 where deptno = (select deptno from dept where dname = 'research')

--query 5

select count(job) as Clerks_in_Work from emp where job = 'clerk'

--query 6

select job, count(empno) as Employyes_in_job, avg(sal) Average_sal_of_job from emp
group by job

--query 7

select min(sal) as lowest_salary, max(sal) as highest_salary from emp


--query 8

select * from dept where deptno not in (select deptno from emp)


--query 9

select ename, sal from emp where job = 'analyst' and sal > 1200 and deptno = 20
order by ename


--query 10

select dname, d.deptno, sum(e.sal) as total_salary from dept d
left join emp e on d.deptno = e.deptno
group by d.dname, d.deptno


--query 11

select ename, sal from emp where ename in ('miller', 'smith')


--query 12

select * from emp where ename like '[a,m]%'



--query 13

select ename, sal * 12 as Annual_salary from emp where ename = 'SMITH'


--query 14

select ename, sal from emp where sal not between 1500 and 2850


--query 15

select mgr_id, count(*) as mgrreport_count from emp where mgr_id is not null
group by mgr_id 
having count(*) > 2




