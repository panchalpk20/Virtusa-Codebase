select * from Employee
update Employee set Salary=(select Salary from Employee where Eid=1007) where Eid=1000
Delete from Employee where Salary=(select Salary from Employee where Eid=1000) and Eid<>1000
--Delete Min Salary Employee
Delete from Employee where Salary=(Select Min(Salary) from Employee)