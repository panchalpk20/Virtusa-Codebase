select * from Sales.CreditCard
--get first 100 records
select top 100 * from Sales.CreditCard
select top 200 * from Sales.CreditCard where ExpYear=2006
select top 50 CardNumber from Sales.CreditCard where ExpYear=2005
select top 10 percent * from Sales.CreditCard
select top 1 percent * from Sales.CreditCard