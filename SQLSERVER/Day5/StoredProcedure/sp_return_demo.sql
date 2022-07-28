--return value from procedure
create procedure sp_mul(@a int,@b int)
as
begin
declare @c int
set @c=@a*@b
return @c
end

--exec procedure
declare @result int
exec @result=sp_mul 12,20
print @result