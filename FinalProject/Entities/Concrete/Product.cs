
public class Product:IEntity
{
    public int ProductId { get; set; }    
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public short UnitsInStock { get; set; }
    // short int'in bir küçüğüdür veritabanında smallint
    public decimal UnitPrice { get; set; }    
}