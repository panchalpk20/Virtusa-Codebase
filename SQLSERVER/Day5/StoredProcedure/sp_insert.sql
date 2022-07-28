--add record to employee table using stored proecedure
alter procedure sp_add_emp(@eid int,@ename varchar(30),@sal int,@joinDate date)
as
begin
if exists(select * from Employee where Eid=@eid)
print 'Eid already Exist'
else
begin
insert into Employee(Eid,Ename,Salary,JoinDate) values(@eid,@ename,@sal,@joinDate)
end
end
exec sp_add_emp 1010,'Jack',12000,'2020/2/20'
exec sp_add_emp @eid=1012,@ename='Kevin',@sal=13000,@joinDate='05.2.2020'
select * from Employee
sp_help Employee