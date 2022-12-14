public class Program
{    
    private static void Main(string[] args)
    {
        Product harddisk = new Product(50);
        harddisk.ProductName = "Hard Dısk";

        Product gsm = new Product(50);
        gsm.ProductName = "GSM";
        gsm.StockControlEvent += Gsm_StockControlEvent;

        for (int i = 0; i < 10; i++)
        {
            harddisk.Sell(10);
            gsm.Sell(10);
            Console.ReadLine();
        }
    }

    private static void Gsm_StockControlEvent()
    {
        Console.WriteLine("Gsm about to finish!!!");
    }
}



public delegate void StockControl();

public class Product{
    private int _stock;
    public Product(int stock)
    {
        _stock = stock;
    }
    public event StockControl StockControlEvent;
    public string ProductName { get; set; }
    public int Stock { 
        get {return _stock;}
        set{
            _stock = value;
            if (value <= 15 && StockControlEvent!=null)
            {
                StockControlEvent();
            }
        }
     }

    public void Sell(int amount){
        _stock -= amount;
        System.Console.WriteLine("{1} Stock amount : {0}",Stock,ProductName);

    }
}
