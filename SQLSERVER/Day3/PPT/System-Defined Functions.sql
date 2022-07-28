

-- =============================================
--	AGGREGATE FUNCTIONS
--	Aggregate Function Aggregate functions (sometimes referred to set functions) 
--	allow you to summarize a column of output. SQL Server provides six general 
--	aggregate functions.
-- =============================================

	AVG(expression)
--	Returns the average (mean) of all the values, or only the DISTINCT values, 
--	in the expression. You can use AVG with numeric- columns only. Null values 
--	are ignored.

--	Example:
--	Using AVG() on single columns in the SELECT statement	
	SELECT 'Standard Cost of Products' = AVG(StandardCost) 
	FROM Production.Product
	GO
	
--	Using AVG() on multiple columns in same SELECT statement	
	SELECT 
		'Standard Cost of Products' = AVG(StandardCost), 
		'Standard List Price of Products' = AVG(ListPrice) 
	FROM Production.Product
	GO


	COUNT(expression)
--	Returns the number of non-null values in the expression. When DISTINCT is 
--	specified, COUNT finds the number of unique non-null values. You can use 
--	COUNT with both numeric and character columns. Null values are ignored.

--	Example:
	SELECT COUNT(EmployeeID) AS 'Total Employees' 
	FROM HumanResources.Employee
	GO
	
	SELECT COUNT(EmployeeID), COUNT(BirthDate) 
	FROM HumanResources.Employee
	GO
	
	
	COUNT(*)
--	Returns the number of rows. COUNT(*) takes no parameters and can‘t be 
--	used with DISTINCT. All rows are counted, even those with NULL values.

--	Example:
	SELECT COUNT(*) 
	FROM HumanResources.Employee
	GO


	MAX(expression)
--	Returns the maximum value in the expression. You can use MAX with 
--	numeric, character, and datetime columns but with bit columns. 
--	With character columns, MAX finds the highest value in the collecting 
--	sequence. MAX ignores any null values. DISTINCT is available for 
--	ANSI compatibility, but it‘s not meaningful with MAX.

--	Example:
	SELECT MAX(StandardCost)
	FROM Production.Product
	GO


	MIN(expression)
--	Returns the minimum value in the expression. You can use MIN with 
--	numeric, character, and datetime columns, but not with bit columns. 
--	With character columns, MIN finds the value that is lowest in the 
--	sort sequence. MIN ignores any null values. 

--	Example:
	SELECT MIN(StandardCost)
	FROM Production.Product
	GO
	
	
	SUM(expression)
--	Returns the sum of all the values, or only the DISTINCT values, in 
--	the expression. You can use SUM with numeric column only. 
--	Null values are ignored.
	SELECT SUM(TotalDue)
	FROM Sales.SalesOrderHeader
	GO
	
-- =============================================
--	DATE AND TIME FUNCTIONS
--	These scalar functions perform an operation on a date and time 
--	input value and return either a string, numeric, or date time value. 
--	All these functions use the Datepart argument which has given below.
-- =============================================

--	DATEPART		ABBREVIATIONS
--	year			yy, yyyy
--	quarter			qq, q
--	month			mm, m
--	dayofyear		dy, y
--	day				dd, d
--	week			wk, ww
--	weekday			dw
--	hour			hh
--	minute			mi, n
--	second			ss, s
--	millisecond		ms

--	The various Date and Time functions are given below:
	
	
	DATEADD 
--	Returns a new datetime value based on adding an interval to the specified date. 

--	Syntax 
--	DATEADD(datepart, number, date)

--	Example 
	SELECT 'New Date' = DATEADD(DD,3,'2011/01/06')
	GO
	SELECT 'New Month' = DATEADD(MM,3,'2011/01/06')
	GO
	SELECT 'New Year' = DATEADD(YY,3,'2011/01/06')
	GO
	DATEDIFF
--	Returns the number of date and time boundaries crossed between two 
--	specified dates. 

--	Syntax 
--	DATEDIFF (datepart, startdate, enddate)	

--	Example 
	SELECT DATEDIFF(DAY, '2010/01/01', '2011/01/15') AS No_of_Days
	GO
	SELECT DATEDIFF(MONTH, '2011/01/01', '2011/03/15') AS No_of_Months
	GO
	
	SELECT DATEDIFF(YEAR, '2011/01/01', '2015/01/15') AS No_of_Years
	GO
	
	
	DATENAME 
--	Returns a character string representing the specified depart of the 
--	specified data. 

--	Syntax 
--	DATENAME(datepart, date) 

--	Example 
	SELECT DATENAME(DW, GETDATE()) AS Day
	GO


	DATEPART 
--	Returns an integer representing the specified department of the specified 
--	date. 

--	Syntax 
--	DATEPART(datepart, date) 

--	Example 
	SELECT DATEPART(DAY, '2011/01/01') AS Year
	
	
	DAY
--	Returns an integer representing the day datepart of the specified date.
--	This function is equivalent to DATEPART(dd, date). 

--	Syntax 
--	DAY(date)

--	Example
	SELECT DAY('2011/01/15') AS 'Day Number'
	GO


	MONTH 
--	Returns an integer that represents the month part of a specified date. 
--	This function is equivalent to DATEPART(mm,date).

--	Syntax 
--	MONTH(date)

--	Example
	SELECT MONTH('2011/01/15') AS 'Month Number'
	GO
	
	
	YEAR 
--	Returns an integer that represents the year part of a specified date. 
--	This function is equivalent to DATEPART(yy,date).

--	Syntax
--	YEAR(date)

--	Example
	SELECT YEAR('2011/01/15') AS 'Year Number'
	GO
	
	
	GETDATE()
--	Returns the current date and time of the server machine.

--	Syntax
--	GETDATE()

--	Example
	SELECT GETDATE() AS 'Current Date/Time'
	GO


	CAST and CONVERT
--	Explicitly converts an expression of one data type to another. 
--	CAST and CONVERT provide similar functionality.	

--	Syntax
--	Using CAST: 
--	CAST(expression AS data_type) 

--	Using CONVERT: 
--	CONVERT (data_type[length)], expression [,style])

	DECLARE @TotalYear int
	SET @TotalYear = 100

--	Below line will give error "Must declare the scalar variable "@TotalYear"."	
--	PRINT('Total Years: ' + @TotalYear)
	
	PRINT('Total Years Using CONVERT: ' + CONVERT(VARCHAR(10),@TotalYear))
	PRINT('Total Years Using CAST: ' + CAST(@TotalYear AS VARCHAR(10)))
	
--	Format current date using CONVERT() function
	SELECT CONVERT(VARCHAR,GETDATE(),105) AS 'Current Date'
	GO
	
	SELECT CONVERT(VARCHAR,GETDATE(),106) AS 'Current Date'
	GO
	
	SELECT CONVERT(VARCHAR,GETDATE(),107) AS 'Current Date'
	GO
-- =============================================
--	STRING FUNCTIONS
--	These scalar functions perform an operation on a string input value 
--	and return a sting or numeric value.
-- =============================================

	CHARINDEX  
--	Returns the starting position of the specified expression in a character string. 

--	Syntax 
--	CHARINDEX(expression1, expression2 [, start_location]) 

--	Example 
	SELECT CHARINDEX('ful','wonderful')
	GO
	

	LEFT 
--	Returns the part of a character string starting at a specified number of character 
--	from the left. 

--	Syntax 
--	LEFT(character_expression, integer_expression)

--	Example
	USE AdventureWorks2019
	GO 
	
	SELECT Name AS DepartmentName, LEFT(Name, 5) AS 'Name Using LEFT()' 
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO
	
	
	RIGHT 
--	Returns the part of a character string starting at a specified number of character 
--	from the right. 

--	Syntax 
--	RIGHT(character_expression, integer_expression)

--	Example
	USE AdventureWorks
	GO 
	
	SELECT Name AS DepartmentName, RIGHT(Name, 7) AS 'Name Using RIGHT()' 
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO
	
	
	LEN 
--	Return the number of characters, rather than the number of bytes, of the given 
--	string expression, excluding trailing blanks. 

--	Syntax 
--	LEN(string_expression)

--	Example
	USE AdventureWorks
	GO 
	
	SELECT  Name AS DepartmentName, LEN(Name) AS 'Dept. Name Length' 
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO
	
	
	LOWER 
--	Returns a character expression after converting character data to lowercase. 

--	Syntax 
--	LOWER(character_expression)

--	Example
	USE AdventureWorks
	GO 
	
	SELECT  LOWER(Name) AS 'Department Name In Lower Case'
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO
	
	
	UPPER 
--	Returns a character expression after converting character data to uppercase. 

--	Syntax 
--	UPPER(character_expression)

--	Example
	USE AdventureWorks
	GO 
	
	SELECT  UPPER(Name) AS 'Department Name In Upper Case'
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO


	LTRIM 
--	Return a character expression after removing leading blanks. 

--	Syntax 
--	LTRIM(character_expression)	

--	Example
	DECLARE @TrainingName CHAR(50) = '  SQL SERVER 2008 TRAINING'

	SELECT @TrainingName AS 'Without LTRIM()'
	
	SELECT RTRIM(LTRIM(@TrainingName)) AS 'After LTRIM()'
	GO
	
	
	RTRIM 
--	Return a character expression after removing trailing blanks. 

--	Syntax 
--	RTRIM(character_expression)	

--	Example
	DECLARE @TrainingName CHAR(50) = 'SQL SERVER 2008 TRAINING  '

	SELECT @TrainingName AS 'Without RTRIM()'
	SELECT LEN(@TrainingName) AS 'Length Without RTRIM()'
	
	SELECT RTRIM(@TrainingName) AS 'After RTRIM()'
	SELECT LEN(RTRIM(@TrainingName)) AS 'Length After RTRIM()'
	GO
	

	REVERSE  
--	Returns the reverse of a character expression. 

--	Syntax 
--	REVERSE(character_expression)

--	Example
	SELECT DISTINCT REVERSE(FirstName) AS FirstName
	FROM Person.Contact
	ORDER BY FirstName 
	GO
	

	REPLACE 
--	Replaces all occurrences of the second given string expression in the first 
--	string expression with a third expression. 

--	Syntax 
--	REPLACE('string_expressionl','string _expression2','string_expression3')

--	Example: 
--	This example replaces the string cde in abcdefghi with xxx 
	SELECT REPLACE('abscdefghicad','cde','xxx')
	GO
	
	
	SPACE  
--	Returns a string of repeated spaces 

--	Syntax 
--	SPACE(integer_expression ) 

--	Example:
	SELECT RTRIM(FirstName) + ',' + SPACE(2) + LTRIM(LastName) 
	FROM Person.Contact 
	ORDER BY FirstName, LastName
	GO
	
	
	SUBSTRING
--	Returns part of a character, binary, text, or image expression. 

--	Syntax 
--	SUBSTRING(expression, start, length) 

--	Example:
	SELECT LastName + SPACE(2) + SUBSTRING(FirstName, 1, 2) 
	FROM Person.Contact 
	ORDER BY LastName
	GO
	

	
	

	REPLICATE  
--	Repeats a character expression a specified number of times. 

--	Syntax 
--	REPLICATE(character_expression, integer_expression)

--	Example
	SELECT REPLICATE(FirstName, 2) 
	FROM Person.Contact 
	ORDER BY FirstName
	GO




	

