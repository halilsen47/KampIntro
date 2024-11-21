using System;

namespace Donguler;

class program
{

    static void Main(string[] args)
    {
        //değer tip
        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;
        Console.WriteLine(sayi1);

        //referans tip
        int[] sayilar1 = { 10,20,30 };
        int[] sayilar2 = { 100, 200, 300 };

        sayilar1 = sayilar2;
        sayilar2[0] = 999;

        Console.WriteLine(sayilar1[0]);

    }

}