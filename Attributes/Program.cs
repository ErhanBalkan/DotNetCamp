CustomerDal customerDal = new CustomerDal();
Customer customer = new Customer{Id=1,LastName="Balkan",Age=23};
customerDal.Add(customer);


[ToTable("Customers")]
[ToTable("TblCustomers")]
// AllowMultiple = true demiştik burada kullandık bunun anlamı örnek olarak kullanım amacımız
// Bu class bir tablo anlamını vermekti tablo adını da parametre olarak veriyoruz
// hangi tabloyu bulursa o olmuş olacak. 
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string FirstName { get; set; }    
    public string LastName { get; set; }
    public int Age { get; set; }    
}

// [AttributeUsage(AttributeTargets.All)] bu attribute ister class'a ister metoda ister property'e her şeye kullanılabilir anlamını verir.
// [AttributeUsage(AttributeTargets.Class)] 
[AttributeUsage(AttributeTargets.Property)] 
// [AttributeUsage(AttributeTargets.Method)] 
// Her şeyde değil de belirtilenlerde kullanılabilir olması için pipe kullanılır;
// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor)]

class RequiredPropertyAttribute : Attribute
{
    /*
    Attribute oluştururken isminin sonuna Attribute eklenir ve Attribute sınıfından miras alır.
    */
}
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
// Çoklu kullanımı destekler örneği yukarda kullanıldı
class ToTableAttribute : Attribute
{
    // Attribute parametre alabilir.
    private string _tableName;
    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}

class CustomerDal
{
    /*
    Örneğin bir metot var ve projede çoğu yerde kullanılıyor onu değiştiremiyoruz ama yenisini yazdık
    bundan sonra yenisi kullanılsın istiyoruz Obsolete hazır bir attribute'dir parametreye mesaj gireriz ve 
    metot kullanıldığında bize uyarı verir.
    */
    [Obsolete("Bu eski bir metottur lütfen yeni AddNew metodunu kullan!")]
    public void Add(Customer customer){
        System.Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
    }    

    public void AddNew(Customer customer){

    }
}

