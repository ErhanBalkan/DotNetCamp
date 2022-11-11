public class Result : IResult
{
    // Setter koymadık bu yüzden sadece Constructor ile set edilebilir...
    public bool Success {get;}
    public string Message {get;}

    // Eğer sadece mesaj parametresi girilirse mesajı set edecek
    // ama success parametresi de verirse diğer constructorun çalışması da gerek 
    // this(success) diyerek bu classın tek parametre vererek tek parametreli 
    // constructoruna parametre olarak success'i göndermiş olduk ve o constructor 
    // bu vesileyle çalışmış olacak ve success'i set edecek.
    public Result(bool success, string message):this(success)
    {
        Message = message;
    }
    public Result(bool success){
        Success = success;
    }
}