select * from persons
--add new column
alter table persons add age varchar(20)
--drop column
alter table persons drop column age
--chage datatype of existing column
alter table persons alter column age int
