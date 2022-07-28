select * into emp from Employee
create view View_Emp_IT
with schemabinding
as
select Eid,Ename from dbo.Employee where Did='D0001'
Go
select * from View_Emp_IT
--drop table emp
--drop view view1
drop table Employee
sp_depends View_Emp_IT