internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        // customerManager.SendMessage();
        // customerManager.ShowAlert();
        // Void olan ve parametre almayan fonksiyonlara delegelik yapar.

        Matematik matematik = new Matematik();

        MyDelegate myDelegate = customerManager.SendMessage;
        myDelegate += customerManager.ShowAlert;
        myDelegate -= customerManager.SendMessage;

        MyDelegate2 myDelegate2 = customerManager.SendMessage2;
        myDelegate2 += customerManager.ShowAlert2;

        MyDelegate3 myDelegate3 = matematik.Topla;
        myDelegate3 += matematik.Carp;
        //delegelerde return type var ise en son verilen return'u döner.
        
        myDelegate();
        myDelegate2("Hello");
        int sonuc = myDelegate3(2,3);

        System.Console.WriteLine("sonuc : " + sonuc);
    }
}

public delegate void MyDelegate();
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);

public class CustomerManager
{
    public void SendMessage(){
        System.Console.WriteLine("Hello!");
    }
    public void ShowAlert(){
        System.Console.WriteLine("Be careful!");
    }
    public void SendMessage2(string message){
        System.Console.WriteLine(message);
    }
    public void ShowAlert2(string alert){
        System.Console.WriteLine(alert);
    }
}

public class Matematik{
    public int Topla(int sayi1, int sayi2){
        return sayi1 + sayi2;
    }
    public int Carp(int sayi1, int sayi2){
        return sayi1 * sayi2;
    }
}