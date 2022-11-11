SELECT p.ProductName urunAdi, SUM(od.Quantity * od.UnitPrice) kazanc FROM Products p
INNER JOIN [Order Details] od ON od.ProductID = p.ProductID
GROUP BY p.ProductName

-- Products tablosundaki ProductName alanları seçtik ve adını urunAdi koyduk.
-- Daha sonra sum metodu ile Order details tablosundaki Quantity ile UnitPrice değerlerini çarptık bunun sonucuna da Kazanc dedik.
-- Products tablosu ile Order Details tablosunu inner join ettik ProductID'ye göre. Yani iki tabloda productID değerleri eşleşen değerleri aldık.
-- Ürün adına göre grupladık. Group by'da her ürün adı için bir tablo oluşur aslında ve fiyat bilgisini de yanına her ürün adı için alabilmiş olduk.