create table project(Pid char(5) primary key,Pname varchar(30) not null)
insert into project values('P0001','AbcBank')
drop table Project
alter table Employee add Pid char(5) foreign key references Project(Pid)
update Employee set Pid='P0001' where Eid in(1000,1002)
select e.Ename,d.Dname,p.Pname from Department d join Employee e on
d.Did=e.Did join Project p on e.pid=p.pid