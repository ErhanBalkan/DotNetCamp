class ProductManager
{
    public void Add(Product product){
        System.Console.WriteLine(product.ProductName + " eklendi.");
    }
        public void Update(Product product){
        System.Console.WriteLine(product.ProductName + " güncellendi.");
    }
}