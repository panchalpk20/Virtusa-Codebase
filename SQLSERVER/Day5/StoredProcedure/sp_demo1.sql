alter procedure GetAge(@dob date)
as
begin
declare @age int
select @age=DATEDIFF(yy,@dob,getdate())
print @age
end
exec GetAge '1990/1/1'