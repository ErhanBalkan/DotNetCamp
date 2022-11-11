-- SELECT -------------------------------------------------------------------------

-- Categories tablosunun bütün kolonları
--select * from Categories

-- Customers tablosunun ContactName,CompanyName ve City kolonları
--select ContactName,CompanyName,City from Customers

-- Gelen tabloda kolon adlarını değiştirme
--select ContactName Adi,CompanyName SirketAdi,City sehir from Customers

-- FİLTER (WHERE) -------------------------------------------------------------------------

-- Customers tablosundaki şehri London olan bütün kolonlar 
--select * from Customers where City = 'London'

-- Products tablosunun CategoryID'si 1 veya 3 olan veriler
--select * from Products where CategoryID = 1 or CategoryID = 3

-- Products tablosunun CategoryID'si 1 olan ve UnitPrice değeri 10'dan büyük veya eşit olan veriler
--select * from Products where CategoryID = 1 and UnitPrice >= 10

-- Products tablosunun CategoryID'si 1'den FARKLI olan veriler
--select * from Products where CategoryID <> 1 

-- SIRALAMA (ORDER BY) -------------------------------------------------------------------------

-- UnitPrice değerlerine göre küçükten büyüğe sıralar default asc(ascending) yani küçükten büyüğe veya a-z'dir.
-- tam tersi de desc'dir (descending).
--select * from Products order by UnitPrice asc 

-- Products tablosundaki CategoryID'si 1 olan verileri UnitPrice değerlerine göre büyükten küçüğe sıralı bir şekilde getir.
--select * from Products where CategoryID = 1 order by UnitPrice asc

-- ADET ALMA (COUNT) VE GRUPLAMA(GROUP BY) -------------------------------------------------------------------------

-- Products tablosundaki categoryID'si 2 olan verilerin sayısı
--select count(*) veriAdeti from Products where CategoryID = 2

-- CategoryID'ye göre gruplar ve bize hangi CategoryIDde kaç tane veri olduğunu yanında verir.
--select categoryID , count(*) from Products group by CategoryID

-- iki tabloyu birleştirdi ve Products tablosundaki CategoryID ile Categories tablosundaki CategoryID
-- alanları aynı olanları getirdi.
--select * from Products inner join Categories 
--on Products.CategoryID = Categories.CategoryID

-- Products tablosunda olup Order Details tablosunda olmayanları getir
--select * from Products p left join [Order Details] od
--on p.ProductID = od.ProductID

