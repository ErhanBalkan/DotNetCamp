public class MyList<T>
{
    T[] items;
    // Constructor
    public MyList()
    {
        items = new T[0];   
    }
    public void Add(T item){
        T[] tempArray =  items;
        /*
        İlk başta listemiz 0 elemanlı. Biz buna eleman ekleyeceğimiz zaman
        yeni bir referansını oluşturmamız gerekecek çünkü yer yok.
        items.Lenght+1 diyerek listenin eleman sayısını aldık ve 1 ekledik.
        Böylece 1 elemanlı bir liste olmuş oldu yeni referans olarak.
        Böylece her eleman ekleneceği zaman önceki elemanların sayısı üzerine
        1 ekleyecek ve 1 yer açacak.
        Yeni referans oluştuğu için önceki listeyi tempArray şeklinde hafızada tutuyoruz.
        daha sonra for döngüsü ile önceki listedeki elemanları yeni listemize alıyoruz ve döngüden
        sonra da yeni elemanı son kalan boş alana eklemiş oluyoruz.

        */
        items = new T[items.Length+1];
        for (int i = 0; i < tempArray.Length; i++)
        {
            items[i] = tempArray[i];
        }

        items[items.Length-1] = item;
    }
}