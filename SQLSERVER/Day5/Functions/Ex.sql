create function fn_GetExp(@jd date)
returns int
as
begin
declare @exp int
set @exp=DATEDIFF(mm,@jd,getdate())
return @exp
end
print dbo.fn_GetExp('2020/2/20')
select dbo.fn_GetExp('2020/3/12')
select Eid,Ename,dbo.fn_GetExp(JoinDate) as 'Exp in Months' from Employee
select * from Employee
update employee set JoinDate=DateAdd(yy,-1,JoinDate) from EMployee