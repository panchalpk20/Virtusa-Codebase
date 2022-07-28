--get employees having Departmets
create procedure sp_getemp
as
begin
select * from EMployee where Did is not null
end
exec sp_getemp