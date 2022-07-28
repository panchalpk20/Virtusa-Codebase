create table emp(empid int,empname varchar(20),salary int)
--add record to emp
insert into emp values(1,'Suren',12000)
select * from emp
insert into emp(empid,empname) values(1,'Rajan')
--add new column
alter table emp add joindate date
select * from emp
insert into emp values(2,'Joy',13000,'12.2.2020')
--adding multile records
insert into emp(empid,empname,salary,joindate) select '3','Karan',13000,getdate() union
 select '4','Charan',13000,getdate() union
  select '5','Dinesh',13000,getdate()
  create table emp1(empid int,empname varchar(20),salary int,joindate date)

  --copy records from one table to another table
  insert into emp1 select * from emp where salary=13000
  select * from emp1
  insert into emp1(empid,empname) select empid,empname from emp where salary=12000
  select * from emp