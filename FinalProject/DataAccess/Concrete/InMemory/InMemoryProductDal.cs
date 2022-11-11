using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class InMemoryProductDal : IProductDal
{
    List<Product> _products;
    public InMemoryProductDal()
    {
        // Bu ürünler Oracle, sql server vb. veritabanından geliyormuş gibi simüle ediyoruz.
        _products = new List<Product>{
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
            new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
        };
    }
    public void Add(Product product){
        _products.Add(product);
    }
    public void Delete(Product product){
        // LINQ = Language Integrated Query
        // LINQ OLMASAYDI AŞAĞIDAKİ GİBİ DÖNGÜYLE YAPACAKTIK.
        // Product productToDelete;
        // foreach (var p in _products)
        // {
        //     if (product.ProductId == p.ProductId)
        //     {
        //         productToDelete = p;
        //     }
        // }
        // _products.Remove(productToDelete);

        Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        // Genelde ID olan aramalarda SingleOrDefault kullanılır.2 tane aynı id olursa hata verir.
        _products.Remove(productToDelete);
    }
    public void Update(Product product){
        // Gönderdiğim ürün IDsine sahip olan listedeki bul
        Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        productToUpdate.ProductName = product.ProductName;
        productToUpdate.CategoryId = product.CategoryId;
        productToUpdate.UnitPrice = product.UnitPrice;
        productToUpdate.UnitsInStock = product.UnitsInStock;
    }

    public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Product Get(Expression<Func<Product, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll(){
        return _products;
    }

    public List<Product> GetAllByCategory(int CategoryId){
        return _products.Where(p => p.CategoryId == CategoryId).ToList();
        // where => Bu koşul içindeki şarta uyan bütün elemanları yeni liste haline getirir ve döndürür.
    }

    public List<ProductDetailDto> GetProductDetails(){
        throw new NotImplementedException();
    }

}