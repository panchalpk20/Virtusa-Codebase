create table product(pid int not null,pname varchar(20) not null unique,price int,stock int,entry_date date)
--set primary key
alter table product add constraint pid_pk primary key(pid)
sp_help product
insert into product(pid,pname) values(2,'abc')
insert into product(pid,pname) values(1,'xyz')
insert into product(pid,pname) values(3,'aaa')
select * from product
--set default constraint
alter table product add constraint default_date default getdate() for entry_date

--remove constraint
alter table product drop constraint pid_pk