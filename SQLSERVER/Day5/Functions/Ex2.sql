--Inline function
create function fn_EmpByDept(@did varchar(20))
returns table
as
return select * from Employee where Did=@did

select * from fn_EmpByDept('D0001')
select Eid,Ename from fn_EmpByDept('D0002')
select Eid,Ename from fn_EmpByDept('D0002') where Salary>12000