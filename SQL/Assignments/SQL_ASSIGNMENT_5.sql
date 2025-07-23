/*1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

   a) HRA as 10% of Salary
   b) DA as 20% of Salary
   c) PF as 8% of Salary
   d) IT as 5% of Salary
   e) Deductions as sum of PF and IT
   f) Gross Salary as sum of Salary, HRA, DA
   g) Net Salary as Gross Salary - Deductions

Print the payslip neatly with all details*/



select * from employees


select * from emp


create or alter proc payslip @employeeno int
as
begin
    declare
        @name varchar(50),
        @salary decimal(8,2),
        @hra decimal(8,2),
        @da decimal(8,2),
        @pf decimal(8,2),
        @it decimal(8,2),
        @gross decimal(8,2),
        @net decimal(18,2)

    select @name = ename, @salary = salary
    from employees
    where empno = @employeeno

    set @hra = @salary * 0.10
    set @da  = @salary * 0.20
    set @pf  = @salary * 0.08
    set @it  = @salary * 0.05

    set @gross = @salary + @hra + @da
    set @net = @gross - (@pf + @it)

    print 'payslip for ' + @name
    print 'salary        : rs. ' + cast(@salary as varchar)
    print 'hra (10%)     : rs. ' + cast(@hra as varchar)
    print 'da  (20%)     : rs. ' + cast(@da as varchar)
    print 'gross salary  : rs. ' + cast(@gross as varchar)
    print 'pf (8%)       : rs. ' + cast(@pf as varchar)
    print 'it (5%)       : rs. ' + cast(@it as varchar)
    print 'net salary    : rs. ' + cast(@net as varchar)
end


exec payslip @employeeno = 7001






/*2.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc

Note: Create holiday table with (holiday_date,Holiday_name). Store at least 4 holiday details. try to match and stop manipulation*/

create table holidays(holiday_date date, holiday_name varchar(50))

insert into holidays values('2025-07-23', 'Independence Day'),('2025-11-01', 'Diwali'),('2025-01-26', 'Republic Day'),('2025-10-02', 'Gandhi Jayanti')

select * from holidays

drop table holidays

create or alter trigger restrict_holiday_trg
on employees
after insert, update, delete
as
begin
    declare @today date = cast(getdate() as date)
    declare @holiday_name varchar(50)

    select @holiday_name = holiday_name from holidays where holiday_date = @today

    if @holiday_name is not null
    begin
        rollback
        raiserror('Due to %s you cannot manipulate data', 16, 1, @holiday_name)
    end
end


select * from employees

insert into employees values (3300, 'Vikram rajan', 'Ops', 50000, 10)



