use AdventureWorks2019
go
select * from Person.Person
select FirstName,LastName from Person.Person
select * from Production.Product
select Name,ProductNumber from Production.Product
select ReorderPoint from Production.Product
select Distinct ReorderPoint from Production.Product
select distinct persontype,title from person.person