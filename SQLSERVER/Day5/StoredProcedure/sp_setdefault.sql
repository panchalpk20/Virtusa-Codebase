--set default value to procedure parameters
create procedure sp_Greet(@name varchar(20),@msg varchar(10)='Hi')
as
begin
print @name+' '+@msg
end
exec sp_Greet 'Sachin'
exec sp_Greet 'Rahul','Hello'