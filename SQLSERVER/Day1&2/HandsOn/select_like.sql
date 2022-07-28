select * from Person.Person
--person name starts with K
select * from Person.Person where FirstName like 'K%'
select FirstName from Person.Person where FirstName like 'K%'
select distinct FirstName from Person.Person where FirstName like 'K%'
--person name ends with n
select * from Person.Person where FirstName like '%n'
--person name starts with k and ends with n
select * from Person.Person where FirstName like 'k%n'
--person name have letter n
select * from Person.Person where FirstName like '%n%'
--person have letter a at 2nd position
select * from Person.Person where FirstName like '_a%'
--person name start a to d
select * from Person.Person where FirstName like '[a-d]%'
--person name not strat with a to d
select * from Person.Person where FirstName not like '[a-d]%'
select * from Person.Person where FirstName like '[^a-d]%'
--person name start  wiht a,e,h
select * from Person.Person where FirstName like '[aeh]%'