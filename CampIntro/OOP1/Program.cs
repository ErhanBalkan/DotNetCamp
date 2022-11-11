Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2; // Örneğin mobilyaya karşılık geliyor gibi düşün
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

// Bu şekilde de yazılabiliyor.
Product product2 = new Product {
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    ProductName = "Kalem",
    UnitPrice = 35
};

ProductManager productManager = new ProductManager();
productManager.Add(product1);
