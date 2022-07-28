create view emp_view
as
select Eid,Ename,Salary,JoinDate from Employee
GO
select * from emp_view
select Eid,Ename From emp_view
Select Eid,Ename from emp_view where Salary>14000
insert into emp_view values(1010,'Varun',12000,getdate())
select * from Employee
alter view emp_view
as
select Eid,Ename,Salary from Employee
GO
sp_help emp_view
sp_helptext emp_view