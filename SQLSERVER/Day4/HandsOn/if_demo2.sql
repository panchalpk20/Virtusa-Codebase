declare @m1 int
declare @m2 int,@m3 int
select @m1=89,@m2=88,@m3=71
declare @result float
set @result=@m1+@m2+@m3
declare @avg float
set @avg=cast((@m1+@m2+@m3)/3.0 as float)
if @avg>=70
print 'Result:Distinction '+convert(varchar(20),@avg)+'%'
else if @avg>=60 and @avg<70
print 'Result:FirstClass'
else
print 'Result:SecondClass'