using System;
using System.Collections.Generic;

namespace OOP3;

class Program
{
    //SOLİD - O - OPEN CLOSED METHOD eklenen bir kredi veya log servisi akışı bozmaz
    //(YENİ BİR KREDİ EKLEDİĞİNDE DE YENİ BİR LOG EKLEDİĞİNDE DE SİSTEM SIKINTISIZ ÇALIŞMALI)
    //ESNAF KREDİSİ VE SMS LOG SONRADAN EKLENDİ 
    static void Main(string[] args)
    {

        IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

        IKrediManager tasıtKrediManager = new TasıtKrediManager();

        IKrediManager konutKrediManager = new KonutKrediManager();
        
        ILoggerService databaseLoggerService = new DataBaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();


        List<ILoggerService> loggers = new List<ILoggerService>()
        {
            new DataBaseLoggerService(),
            new SmsLoggerService(),
        };

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKrediManager(),loggers);

        //SOLİD - O su esnaf kredisi ve sms log servis eklendi ama sistem bozulmadı
        //basvuruManager.BasvuruYap(new EsnafKrediManager(),new SmsLoggerService());

        List<IKrediManager>  krediler = new List<IKrediManager>(){ihtiyacKrediManager,tasıtKrediManager,konutKrediManager};

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }

}