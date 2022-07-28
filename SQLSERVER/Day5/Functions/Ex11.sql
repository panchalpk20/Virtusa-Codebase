--scalar function
create function fn_add(@a int,@b int)
returns int
as
begin
declare @c int
set @c=@a+@b
return @c
end
--execute function
select dbo.fn_add(1,3) as OutPut
print dbo.fn_add(1,3)