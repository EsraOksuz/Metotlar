using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya sulusu";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır sulusu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            
            //type-safe
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("-----------Metotlar---------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);   //encapsulation
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 20);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 10, 60);
            sepetManager.Ekle2("Kavun", "Sarı Kavun", 18, 3);

            Console.ReadLine();
        
        }
    }
}
