using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
            {
                Console.WriteLine("Kayıt Oluşturuldu");

            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. KayıtBaşarısız");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt Güncellendi");

        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt Silindi");

        }
    }
}
