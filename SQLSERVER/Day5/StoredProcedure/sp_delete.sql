--delete employee record using procedure
create procedure sp_delete_emp(@eid int)
as
begin
if (select count(*) from Employee where Eid=@eid)=1
begin
delete from EMployee where Eid=@eid
end
else
print 'Invalid ID'
end
exec sp_delete_emp 1090
exec sp_delete_emp 1012