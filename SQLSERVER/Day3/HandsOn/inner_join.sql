--Display employeeId,EmployeeName and DeptName
select e.Eid,e.Ename,e.Salary,d.Dname from employee e join department d on e.did=d.did
--Display EmployeeId,EMployeeName and DeptName from Salary>10000
select e.Eid,e.Ename,d.Dname from employee e join department d on e.did=d.did where e.Salary>16000 order by e.Salary>13000
--Join Using Group by
select d.Dname,count(e.Eid) as 'Total No of Employees' from Employee e join department d on e.did=d.did group by d.Dname
--Dispaly Employees working in HR Dept
select e.* from Employee e inner join Department d on e.did=d.did where d.dname='HR'
select * from Employee where Did=(Select Did from Department where Dname='HR')