using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
    public class GameCampaign : IGameCampaign
    {
        public void BlackFriday(Gamer gamer)
        {
            if (gamer.BlackFridayDate == new DateTime(2021, 01, 29))
            {
                Console.WriteLine("BlackFriday Başlamıştır.");

            }
            else
            {
                Console.WriteLine("İndirimin günü geçmiştir.");
            }

        }

        public bool PayCashSold(Gamer gamer)
        {
            if (true)
            {
                return true;
                Console.WriteLine("Nakit ödemenizden dolayı %10 indirim uygulanmıştır.");

            }
            else
            {
                Console.WriteLine("Taksitli ödediğiniz için indirim uygulanamaz.");
            }

        }

        public void PayCashSold(bool v)
        {
            v = true;
        }

        public void StudentCampaing(Gamer gamer)
        {
            if (gamer.DateOfBirth == new DateTime(1998, 09, 25))
            {
                Console.WriteLine("%30 öğrenci indirimi uygulanıyor.");
            }
            else
            {
                Console.WriteLine("Malesef indirimden yararlanamazsınız.");
            }
        }
    }
}
