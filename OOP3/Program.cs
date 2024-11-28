using System;
using System.Collections.Generic;

namespace OOP3;

class Program
{
    static void Main(string[] args)
    {

        IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();

        IKrediManager tasıtKrediManager = new TasıtKrediManager();

        IKrediManager konutKrediManager = new KonutKrediManager();
        
        BasvuruManager basvuruManager = new BasvuruManager();
        //basvuruManager.BasvuruYap(ihtiyacKrediManager);
        
        List<IKrediManager>  krediler = new List<IKrediManager>(){ihtiyacKrediManager,tasıtKrediManager,konutKrediManager};

        basvuruManager.KrediOnBilgilendirmesiYap(krediler);

    }

}