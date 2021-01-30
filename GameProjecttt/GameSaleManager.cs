using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
    public class GameSaleManager:IGameSaleService
    {
        public void Sold(Gamer gamer)
        {
            if (gamer.FirstName == "Miray" && gamer.LastName == "Kozlu" && gamer.NationalityId == "123657899" && gamer.Id == 1 && gamer.DateOfBirth == new DateTime(1998, 9, 25))
            {
                Console.WriteLine("Nakit veya Taksit ödeme yöntemini seçiniz.");
            }
            else
            {
                Console.WriteLine("Lütfen bilgileriniz kontrol ediniz.");
            }
        }
    }
}
