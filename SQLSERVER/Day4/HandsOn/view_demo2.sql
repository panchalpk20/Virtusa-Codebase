create view View_Emp_HR
with Encryption
as
select Eid,Ename,Salary,Did from Employee where Did='D0002'
Go
select * from View_Emp_HR
sp_helptext View_EMp_HR