using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player { Id = 1, BirthYear = 1996, FirstName = "Esra", LastName = "Öksüz", TCNO = 12345 });


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(new Campaign { Id = 3, CampaignName = "Gamers Month", DiscountPercentage = 50 });

            OrderManager orderManager = new OrderManager();
            orderManager.CreateOrder(new Player { Id = 1, BirthYear = 1996, FirstName = "Esra", LastName = "Öksüz", TCNO = 12345 },
                new Campaign {Id=5,DiscountPercentage =30, CampaignName = "ValentinesDayDiscount" });


            Console.ReadLine();
        }
    }
}
