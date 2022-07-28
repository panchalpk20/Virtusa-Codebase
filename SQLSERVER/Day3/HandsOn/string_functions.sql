SELECT CHARINDEX('f','wonderful')
	GO
SELECT LEFT('ABCE',2)
SELECT RIGHT('ABCD',2)
SELECT Name AS DepartmentName, LEFT(Name, 5) AS 'Name Using LEFT()' 
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO
	SELECT Name AS DepartmentName, riGHT(Name, 5) AS 'Name Using LEFT()' 
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO

	--LEN
	SELECT  Name AS DepartmentName, LEN(Name) AS 'Dept. Name Length' 
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO

	SELECT  LOWER(Name) AS 'Department Name In Lower Case'
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO
	SELECT  upper(Name) AS 'Department Name In Lower Case'
	FROM HumanResources.Department 
	ORDER BY DepartmentID
	GO

	DECLARE @TrainingName CHAR(50) = '  SQL SERVER 2008 TRAINING'

	SELECT @TrainingName AS 'Without LTRIM()'
	
	SELECT LTRIM(@TrainingName) AS 'After LTRIM()'
	GO

	DECLARE @TrainingName CHAR(50) = 'SQL SERVER 2008 TRAINING  '

	SELECT @TrainingName AS 'Without RTRIM()'
	SELECT LEN(@TrainingName) AS 'Length Without RTRIM()'
	
	SELECT RTRIM(@TrainingName) AS 'After RTRIM()'
	SELECT LEN(RTRIM(@TrainingName)) AS 'Length After RTRIM()'
	GO