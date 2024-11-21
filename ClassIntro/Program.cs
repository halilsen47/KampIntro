﻿using System;

namespace Donguler;

class program
{

    static void Main(string[] args)
    {
         

        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin Demiroğ";
        kurs1.IzlenmeOranı = 68;

        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "Java";
        kurs2.Egitmen = "Kerem Varış";
        kurs2.IzlenmeOranı = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOranı = 80;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "C++";
        kurs4.Egitmen = "Murat Kurtboğan";
        kurs4.IzlenmeOranı = 100;


        Kurs[] kurslar = new Kurs[]
        {
            kurs1, kurs2,kurs3,kurs4
        };
        //       var  
        foreach (Kurs kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
        }
 
    }

}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOranı { get; set; }


}