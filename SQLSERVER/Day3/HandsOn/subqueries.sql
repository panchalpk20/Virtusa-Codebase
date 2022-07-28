--display employee who are working in hr
select * from Employee
select Ename from Employee where Did=(select Did from Department where Dname='HR')
update employee set salary=13000 where Eid=1001
select Max(Salary) from Employee
select * from Employee where Salary=(Select Max(Salary) from Employee)
--display 2nd highest employee details
select * from Employee where Salary=(Select Max(Salary) from Employee where salary<(select Max(Salary) from Employee))