using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILogerService logerService)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager();       // böyle olunca sadece kont kredisi kabul eder
            krediManager.Hesapla();
            logerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
