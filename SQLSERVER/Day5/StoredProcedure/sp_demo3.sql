--Display employee using DeptID
alter procedure sp_getDeptEmp(@Did varchar(10))
as
begin
select e.Eid,e.Ename,d.Dname from employee e join department d on e.did=d.did where e.did=@Did
end
exec sp_getDeptEmp @Did='D0001'