print @@servername
print @@version
print @@error

--local variables

declare @name varchar(20)
set @name='Sachin'
print 'Hello '+@name

declare @a int
declare @b int
--set @a=10
--set @b=20
select @a=10,@b=20
declare @c int
set @c=@a+@b
print 'Addition: '+cast(@c as varchar(20))

declare @age int
declare @dob date
set @dob='1990/2/20'
set @age=DATEDIFF(yy,@dob,getdate())
print 'Current Age: '+convert(varchar,@age)



