create view view_Emp_Dept
as
select e.Eid,e.Ename,d.Dname from employee e join Department d on e.Did=d.Did
Go
select * from view_Emp_Dept
select Eid,Dname from view_Emp_Dept