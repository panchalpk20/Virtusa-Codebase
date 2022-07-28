select * from Sales.CreditCard
select * from Sales.CreditCard where ExpMonth between 2 and 5
select * from Sales.CreditCard where ExpYear between 2000 and 2005
select * from Sales.CreditCard where ModifiedDate between '1.1.2013' and '6.1.2013'
select * from Sales.CreditCard where ModifiedDate not between '1.1.2013' and '6.1.2013'
select * from Sales.CreditCard where ExpYear not between 2000 and 2005
select * from Sales.CreditCard where (ExpYear between 2000 and 2005) and ModifiedDate>'1.1.2013'
select * from Sales.CreditCard where (ExpYear between 2000 and 2005) and (ModifiedDate  between '1.1.2013' and '6.1.2013')
