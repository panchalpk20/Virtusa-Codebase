--left outer join
--display employees who are assingned to dept and not assinged to any dept with theri deptname
select e.Eid,e.Ename,d.Dname from Employee e left outer join Department d on e.did=d.did
--right outer join
--display deparments are assingned to employees and are not assigned to any employees
select e.Ename,d.Dname from Employee e right outer join Department d on d.did=e.did
--full outer join
select e.Ename,d.Dname from Employee e full outer join Department d on d.did=e.did