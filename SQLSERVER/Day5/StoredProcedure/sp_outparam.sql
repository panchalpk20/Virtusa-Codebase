--stored procedures using outparametes
create procedure sp_GetEmpById(@eid int,@ename varchar(20) out)
as
begin
select @ename=ename from employee where Eid=@eid
end


declare @ename varchar(20)
exec sp_GetEmpById 1000,@ename output
print @ename