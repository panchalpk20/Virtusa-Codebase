select * from Sales.CreditCard 
select * from Sales.CreditCard where ExpMonth in(2,5,8)
select * from Sales.CreditCard where ExpYear in(2005,2008)
select * from Sales.CreditCard where CardType in('Distinguish','SuperiorCard')
select * from Sales.CreditCard where ExpMonth not in(2,5)
select * from Sales.CreditCard where ExpYear in(2005,2008) and ExpMonth in (11,2)