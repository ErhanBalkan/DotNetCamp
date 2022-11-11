class Program
{
    static void Main(String[] args){
        
        ProductManager productManager = new ProductManager(new EfProductDal());

        /*
        foreach (Product product in productManager.GetAll())
        {
            System.Console.WriteLine(product.ProductName);
        }
        */
        
        /*
        foreach (Product product in productManager.GetByUnitPrice(40,100))
        {
            System.Console.WriteLine(product.ProductName);
        }
        */

        // DTO
        var result = productManager.GetProductDetails();
        if (result.Success == true)
        {
            foreach (var p in result.Data)
            {
                System.Console.WriteLine(p.ProductName +" / " + p.CategoryName);
            }
        }else{
            System.Console.WriteLine(result.Message);
        }


        // Category

        // CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // foreach (Category category in categoryManager.GetAll())
        // {
        //     System.Console.WriteLine(category.CategoryName);
        // }
    }
}