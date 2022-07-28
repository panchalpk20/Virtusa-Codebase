use TrainingDB
go
create table Person(p_id int,p_name varchar(30))
--rename table column names
sp_rename 'Person.p_id','pid'
select * from Person
sp_rename 'Person.p_name','pname'
--rename table name
sp_rename 'Person','Persons'
select * from Persons