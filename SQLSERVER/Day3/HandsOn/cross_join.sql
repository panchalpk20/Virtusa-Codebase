--Display result set mapping employees to possible deparments
select   e.Ename,d.Dname from Employee e cross join Department d 
