--create table with constraints
create table Department(Did char(5) primary key,Dname varchar(30) unique not null)
create table Employee(Eid int primary key,
Ename varchar(30) not null,
Salary money check(Salary>10000),
JoinDate Date default getdate() check(JoinDate<=getdate()),
Did char(5) foreign key references Department(Did)
)
insert into Department values('D0001','IT')
insert into Department values('D0002','HR')
insert into Employee(Eid,Ename,Salary,Did) values(1000,'Rohan',12000,'D0001')
select * from Employee
insert into Employee values(1001,'Karan',12000,'11.2.2020','D0002')
insert into Employee values(1002,'Suren',12000,'11.2.2020','D0002')
update Employee set Salary=10000 where Eid=1002
insert into Employee(Eid,Ename,Salary) values(1003,'Rohan',12000)
update Employee set Did='D0001' where Did is null