select * from Employee
select DATEADD(yy,1,JoinDate) as NextYear from Employee
select Year(JoinDate) as 'Join Year' from Employee

select '1'+'1' as 'Sum'
select CAST('1' as int)+CAST('1' as int) as Sum
select CONVERT(int,'1')+CONVERT(int,'1') as Sum
declare @a int
declare @b int
declare @result int
set @result=@a+@b
print 'Addtion '+Cast(@result as varchar(10))
go

	DECLARE @TotalYear int
	SET @TotalYear = 100

--	Below line will give error "Must declare the scalar variable "@TotalYear"."	
--	PRINT('Total Years: ' + @TotalYear)
	
	PRINT('Total Years Using CONVERT: ' + CONVERT(VARCHAR(10),@TotalYear))
	PRINT('Total Years Using CAST: ' + CAST(@TotalYear AS VARCHAR(10)))
	SELECT CONVERT(VARCHAR,GETDATE(),100) AS 'Current Date'
	GO
	SELECT CONVERT(VARCHAR,GETDATE()) AS 'Current Date'
	GO
	Select GetDate()

	SELECT CONVERT(VARCHAR,GETDATE(),105) AS 'Current Date'
	GO
	
	SELECT CONVERT(VARCHAR,GETDATE(),106) AS 'Current Date'
	GO
	
	SELECT CONVERT(VARCHAR,GETDATE(),107) AS 'Current Date'
	GO