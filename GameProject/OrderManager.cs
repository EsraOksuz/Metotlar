using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderCreatingService
    {
        public void CreateOrder(Player player, Campaign campaign)
        {
            Console.WriteLine("Mr." + player.FirstName + " your order created succesfully with %" + campaign.DiscountPercentage + "discount!");
        }
    }
}
