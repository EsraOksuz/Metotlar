using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}
