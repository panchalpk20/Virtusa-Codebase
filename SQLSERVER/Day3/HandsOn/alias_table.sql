select * from Employee
--alias column names
select Ename as EmployeeName from Employee
select Ename 'EmployeeName' from Employee
select getdate()
--alias table name
select e.Ename from Employee e where e.Salary=12000