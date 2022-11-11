class Product
{
    // Primary key
    public int Id { get; set; }
    // Foreign key
    public int CategoryId { get; set; }
    public string? ProductName{ get; set; }
    public double UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}