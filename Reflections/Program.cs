// DortIslem dortIslem = new DortIslem(2,3);
// dortIslem.Topla2();
// dortIslem.Topla(3,4);

// Çalışacağımız tipi belirtiyoruz
using System.Reflection;

var type = typeof(DortIslem);

// DortIslem dortIslem = new DortIslem(2,3);
// üstteki new ile activator olayı aynı şeydir.
// parametreli constructor için type,param1,param2 şeklinde belirtebiliriz.
// DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type);

// System.Console.WriteLine(dortIslem.Topla(4,5)); 

var instance = Activator.CreateInstance(type,4,5);
// metod bilgilerine ulaştık ve invoke ile çalıştırdık null parametre olmadığı için.
MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
// invoke'De tekrar parametre olarak instance vermemizin nedeni hangi instance'nin Topla2 parametresini
// çalıştıracağını bilmediği için. 
System.Console.WriteLine(methodInfo.Invoke(instance,null));
System.Console.WriteLine("-----------------------------");
// Bütün metodlarına ulaşmak
var methods = type.GetMethods();
foreach (var info in methods)
{
    System.Console.WriteLine("Metod adı : {0}", info.Name);
    // Metodların parametrelerine ulaşmak
    foreach (var parameterInfo in info.GetParameters())
    {
        System.Console.WriteLine("Parametre : {0}", parameterInfo.Name);
    }
    // Attribute'lerine ulaşmak
    foreach (var attribute in info.GetCustomAttributes())
    {
        System.Console.WriteLine("Attribute : {0}", attribute.GetType().Name);
    }
}
class DortIslem
{
    private int _sayi1;
    private int _sayi2;
    public DortIslem(int sayi1, int sayi2)
    {
        _sayi1 = sayi1;
        _sayi2 = sayi2;
    }
    public DortIslem(){}
    public int Topla(int sayi1, int sayi2){
        return sayi1 + sayi2;
    }
    public int Carp(int sayi1, int sayi2){
        return sayi1 * sayi2;
    }

    [MethodName("Çarpma")]
    public int Topla2(){
        return _sayi1 + _sayi2;
    }
    public int Carp2(){
        return _sayi1 * _sayi2;
    }
}

public class MethodNameAttribute : Attribute{
    public MethodNameAttribute(string name)
    {
        
    }
}