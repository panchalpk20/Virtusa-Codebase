select  * from Employee
select avg(Salary) 'Avg Salary' from Employee
select count(*) from Employee where Did='D0001'
select Min(Joindate) as Senior from Employee

select Max(Joindate) as Junior from Employee

select count(*) from employee where salary=(Select Min(Salary) from Employee)
select sum(Salary) as TotalSalary from EMployee