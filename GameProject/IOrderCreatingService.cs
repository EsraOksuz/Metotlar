using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderCreatingService
    {
        void CreateOrder(Player palyer, Campaign campaign);
    }
}
