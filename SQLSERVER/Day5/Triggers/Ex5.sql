--delete trigger
alter trigger product_delete_trigger
on product
after delete
as
Rollback Transaction
print 'Access denied '
go
delete from product where Pid=1
select * from product