
--update
select * from emp
update emp set salary=12000 where empname='rajan'
update emp set salary=salary+1000  --(update all employees salary)
update emp set salary=15000,joindate=getdate() where empid=1
--delete
select * from emp1
delete from emp1 where salary is null
delete from emp1 where empname='joy'
delete from emp1 where empid=2
