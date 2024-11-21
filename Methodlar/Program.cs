using Methodlar;
using System;

namespace Metodlar
{

    class Program
    {

        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Acıklama = "Amasya Elması";
            
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Acıklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] 
            { 
                urun1,
                urun2 
            };

            //type-safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("-------------Metotlar---------------");

            //İnstance - Örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urunler[0]);
            sepetManager.Ekle(urunler[1]);

            sepetManager.Ekle2("Armut","Yeşil armut",12,10);
            sepetManager.Ekle2("Elma","Yeşil elma",12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır Karpuzu", 12,8);


        }

    }
}

//Dont Repeat Yourself
//Clean Code
//Best Practice
