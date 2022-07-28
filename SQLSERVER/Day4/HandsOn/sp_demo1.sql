use TrainingDB
Go
--create procedure
create procedure sp_welcome
as
begin
print 'Welcome to SqlSQL Programming'
end
GO
--execute procedure
exec sp_welcome
execute sp_welcome