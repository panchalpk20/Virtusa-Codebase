--insert trigger
create trigger product_insert_trigger
on product
after insert 
as
print 'Record Added At:'+cast(getdate() as varchar(20))
Go
insert into product values(1,'Keyboard',600,10)
insert into product values(2,'Mouse',700,5)