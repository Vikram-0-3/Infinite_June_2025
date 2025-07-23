

/*===========================Code Challenge 1===========================================*/


/*Create a book table with id as primary key and provide the appropriate data type to other attributes .isbn no should be unique for each book*/


Create table Books (id int Primary key, title varchar(50), author varchar(30), isbn_no varchar(15) Unique , publisheddate Datetime)

Select * from books

insert into books values(1, 'My first SQL Book','Mary parker', '981483029127', '2012-02-22 12:08:17' ),
(2, 'My second SQL Book','John mayer', '857300923713', '1972-07-03 09:22:45' ),
(3, 'My Third SQL Book','Cary Flint', '523120967812', '2015-10-18 14:05:44' )




/*Write a query to fetch the details of the books written by author whose name ends with er.*/

select * from books where author like '%er'

create table reviews (id int primary key, book_id int constraint f foreign key(book_id) references books(id), reviewer_name varchar(30), content varchar(50), rating int, published_date datetime )

select * from reviews

drop table reviews


insert into reviews values(1,1, 'John smith', 'My first review', 4, '2017-12-10 05:5:12' ),
(2,2, 'John smith', 'My second review', 5, '2017-10-13 15:05:12' ),
(3,2, 'Alice walker', 'Another review', 1, '2017-10-22 23:47:10' )




/*Display the Title ,Author and ReviewerName for all the books from the above table*/

select b.title, b.author, r.reviewer_name
from books b left join reviews r on b.id = r.book_id




/*Display the reviewer name who reviewed more than one book*/

select reviewer_name from reviews
group by reviewer_name
having count(book_id) > 1


create table customers(id int primary key, name varchar(50), age int, address varchar(100), salary decimal(8,2))

drop table customers

select * from customers

insert into customers values(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00), 
(5, 'hardik', 27, 'bhopal', 8500.00), 
(6, 'komal', 22, 'mp', 4500.00),
(7, 'muffy', 24, 'indore', 10000.00)




/*Display the Name for the customer from above customer table who live in same address which has character o anywhere in address*/

select name from customers where address like '%o%'

create table orders(oid int, date datetime, customer_id int constraint f foreign key(customer_id) references customers(id), amount int)

drop table orders

select * from orders

insert into orders values(102, '2009-10-08 00:00:00', 3, 3000), 
(100, '2009-10-08 00:00:00', 3, 1500), 
(101, '2009-11-20 00:00:00', 2, 1560), 
(103, '2008-05-20 00:00:00', 4, 2060)




/*Write a query to display the Date,Total no of customer placed order on same Date*/

select date, count(distinct customer_id) as totalcustomers from orders 
group by date




/*Display the Names of the Employee in lower case, whose salary is null*/


create table employees(id int primary key, name varchar(50), age int, address varchar(100), salary decimal(8,2))
insert into employees values(1, 'ramesh', 32, 'ahmedabad', 2000.00),
(2, 'khilan', 25, 'delhi', 1500.00),
(3, 'kaushik', 23, 'kota', 2000.00),
(4, 'chaitali', 25, 'mumbai', 6500.00), 
(5, 'hardik', 27, 'bhopal', 8500.00)

insert into employees(id, name, age, address)values(6, 'komal', 22, 'mp'),
(7, 'muffy', 24, 'indore')

select * from employees

select lower(name) as NullSalary_Employees from employees where salary is null




/*Write a sql server query to display the Gender,Total no of male and female from the above
relation*/

create table student(registerno int, name varchar(30),age int,qualification varchar(10),mobileno varchar(12),mail_id varchar(50),location varchar(20),gender varchar(10))

select * from student

insert into student values (2, 'sai', 22, 'b.e', 9952836777, 'sai@gmail.com', 'chennai', 'm'),
(3, 'kumar', 20, 'bsc', 7890125648, 'kumar@gmail.com', 'madurai', 'm'),
(4, 'selvi', 22, 'b.tech', 8904567342, 'selvi@gmail.com', 'selam', 'f'),
(5, 'nisha', 25, 'm.e', 7834672310, 'nisha@gmail.com', 'theni', 'f'),
(6, 'saisaran', 21, 'b.a', 7890345678, 'saran@gmail.com', 'madurai', 'f'),
(7, 'tom', 23, 'bca', 8901234675, 'tom@gmail.com', 'pune', 'm')



select gender, count(*) as totalcount from student 
group by gender

/*========================================Code challenge 1 End======================================================*/
