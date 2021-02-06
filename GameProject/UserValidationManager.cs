using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if (player.BirthYear == 1996 && player.FirstName == "Esra" && player.LastName == "Öksüz" && player.TCNO ==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
