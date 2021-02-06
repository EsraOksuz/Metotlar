using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya oluşturuldu");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");

        }
    }
}
