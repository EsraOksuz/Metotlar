--select 


select ContactName Adi,CompanyName,City Sehir from Customers


select * from Customers where City ='London'


select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select  * from Products order by ProductName

select  * from Products order by CategoryId,ProductName

select  * from Products where categoryId =1 order by UnitPrice asc ---ascending artan  defaultu asc   desc ---- descendin azalan


select count(*) Adet from Products  where CategoryID=1



select categoryId,count(*) from Products group by CategoryID



select categoryId,count(*) from Products group by CategoryID having count(*)<10

select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Products  inner join Categories on Products.CategoryID=Categories.CategoryID


--DTO  data transformation object 

select * from  Products p left join [Order Details] od on p.ProductID =od.ProductID

select * from  Customers c left join Orders o on c.CustomerID =o.CustomerID where o.CustomerID is null