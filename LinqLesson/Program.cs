using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        List<Category> categories = new List<Category>(){
            new Category{CategoryId = 1,CategoryName = "Bilgisayar"},
            new Category{CategoryId = 2,CategoryName = "Telefon"},
        };
        List<Product> products = new List<Product>(){
            new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitsInStock=5},
            new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=18000,UnitsInStock=3},
            new Product{ProductId=3,CategoryId=1,ProductName="HP Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=18000,UnitsInStock=2},
            new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitsInStock=15},
            new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=8000,UnitsInStock=0},
        };

        void AnyQuery(){
            // Any => var mı yok mu onun sonucunu bize bool olarak döner.
            bool result = products.Any(p => p.ProductName == "Acer Laptop");
            System.Console.WriteLine(result);
        }
        
        void FindQuery(){
            // Bir ürünün detayına gitmek için vs. kullanılır genelde. Bize döneceği tür neyi bulursa odur. Bulamazsa null döner.
            var result = products.Find(p => p.ProductId == 3);
            System.Console.WriteLine(result.ProductName);
        }

        void FindAllQuery(){
            // Adında top geçen ürünleri liste şeklinde dönecek.
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var item in result)
            {
                System.Console.WriteLine(item.ProductName);
            }
        }

        void WhereAndOrderByQueries(){
            // FindAll ile aynı işlevi görür Liste yerine IEnumerable döner yani bunun üzerinden başka sorgular yazabiliriz. 
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice).ThenBy(p=> p.ProductName);
            // Fiyata göre sıralayacak azdan çoka ya da a-z, daha sonra da isimlerine göre sıralayacak bunu thenby ile yaptık.
            // descending versiyonları çoktan aza ya da z-a şeklindedir.
            foreach (var item in result)
            {
                System.Console.WriteLine(item.ProductName);
            }
        }

        // Linq farklı syntax
        void DifferentUsageLinq(){
            var result =  from p in products
                          where p.UnitPrice > 6000
                          orderby p.UnitPrice
                          select p;
            foreach (var item in result)
            {
                System.Console.WriteLine(item.ProductName);
            }  
        }

        // -------------------------- JOIN VE DTO -----------------------------------

/*
    Yeni bir class oluştururuz ve burada product'ta hangi verileri kullanacaksak property olarak belirtiriz CategoryName verdik ama Product class'ında
    CategoryId şeklinde belirtmiştik işte burada join kullanırız bir de Category classımız var Product ve Category'i join edip ilişkilendireceğiz.
    Ve bunlar yeni classımız olan ProductDto'da birleşmiş olacak. Biz product bilgilerini p'den alıyoruz ama mesela CategoryName'i c'den aldık.
    on p.CategoryId equals c.CategoryId dediğimizde products listesindeki her bir elemanın CategoryId'sini categories listesindeki her elemanın CategoryId'si
    ile eşit olanları ilişkilendirir.  
*/
        void JoinAndDto(){
            var result =  from p in products
                          join c in categories
                          on p.CategoryId equals c.CategoryId
                          select new ProductDto{ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName=p.ProductName, UnitPrice = p.UnitPrice};
            foreach (var productDto in result)
            {
                System.Console.WriteLine(productDto.ProductName + " - " + productDto.CategoryName);
            }
        }

        JoinAndDto();
        
        

    }
}