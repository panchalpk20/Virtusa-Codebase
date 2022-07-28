select * from Employee
create table Login(Username varchar(20),Pwd varchar(20),EmpId int foreign key references Employee(Eid))
--Username:Ename+EID
--Password:12345
alter trigger emp_trigger_insert
on Employee
After Insert
as
declare @uname varchar(20)
declare @pwd varchar(20)
declare @eid varchar(20)
declare @ename varchar(20)
select @eid=Eid,@ename=Ename from inserted
set @uname=@ename+@eid
set @pwd=12345
insert into Login values(@uname,@pwd,@eid)
Go
insert into Employee values(1022,'Faran',12000,getdate(),null)
select * from inserted