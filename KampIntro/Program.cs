using System;

namespace KampIntro;

class program
{

    static void Main(string[] args) {

        //type safety
        //Do not repeat yourself
        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOranı = 1.45;
        bool sistemeGirişYapmışMı = true;
        double dolarDun = 7.35;
        double dolarBugun = 7.35;

        if (dolarDun > dolarBugun)
        {
            
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else
        {
            Console.WriteLine("Eşittir Butonu");
        }



        if (sistemeGirişYapmışMı == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else 
        {
            Console.WriteLine("Giriş yap butonu");
            
        }
        
        Console.WriteLine(kategoriEtiketi);

    }

}