using System;

namespace Donguler;

class program
{

    static void Main(string[] args)
    {
        //array 
        string[] kurslar = new string[] 
        {
            "Kurs-1",
            "Kurs-2",
            "Kurs-3",
            "Kurs-4",
            "Kurs-5"
        };

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("******For Bitti******");
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }


        Console.WriteLine("Footer");
    }

}