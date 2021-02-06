using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Esra";
            //musteri1.Soyadi = "Öksüz";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";

            // Gerçek - Tüzel

            GercekMuster musteri1 = new GercekMuster();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Esra";
            musteri1.Soyadi = "Oksuz";
            musteri1.TcNo = "222222";

            TuzelMusteri1 musteri2 = new TuzelMusteri1();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "999999";

            Musteri musteri3 = new GercekMuster();
            Musteri musteri4 = new TuzelMusteri1();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);



        }
    }
}
