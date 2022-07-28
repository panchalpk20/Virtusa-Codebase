create table AuditSalary(AuditId int identity(100,1),Eid int foreign key references Employee(Eid) on delete cascade,
Old_Salary money,New_Salary money)
create trigger emp_update_trigger
on Employee
After Update
as
declare @eid int
declare @old_sal money
declare @new_sal money
select @eid=Eid,@new_sal=Salary from inserted
select @old_sal=Salary from deleted
insert into AuditSalary(Eid,Old_Salary,New_Salary) values(@eid,@old_sal,@new_sal)
Go
update Employee set Salary=Salary+2000 where Eid=1000

select * from Employee where Eid=1000
select * from AuditSalary