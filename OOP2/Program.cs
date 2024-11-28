﻿using System;

namespace OOP2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //!!!!!!!!!!!!!!!!!!!!!
            //Engin Demiroğ
            //Musteri musteri1 = new Musteri();

            //musteri1.Ad = "Engin";
            //musteri1.Soyad = "Demiroğ";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLİD - L 
            //!!!!!!!!!!!!!!!!!!!!!


            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.TcNo = "11111111111";
            musteri1.Id = 1;

            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            //instance
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);



        }
    }
}
