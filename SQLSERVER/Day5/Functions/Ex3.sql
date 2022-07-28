--Return Department Name of the Employee using Function
create function fn_GetDeptById(@eid int)
returns varchar(20)
as
begin
declare @dname varchar(20)
select @dname=d.dname from employee e join department d on e.Did=d.Did where e.Eid=@eid
return @dname
end
print dbo.fn_GetDeptById(1000)
select Ename,dbo.fn_GetDeptById(Eid) as DeptName from Employee

--Create fuction to retun joinDate of Employee using Eid