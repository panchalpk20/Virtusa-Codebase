--Get Ename using Eid
alter procedure sp_GetSalById(@eid int)
as
begin
declare @sal int
if exists(select Salary from Employee where Eid=@eid)
begin
select @sal=Salary from Employee where Eid=@eid
return @sal
end
else
begin
print 'Invalid Id'
set @sal=0
return @sal
end
end

declare @sal int
exec @sal=sp_GetSalById 1000
print @sal
