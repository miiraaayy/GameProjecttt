using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
    public class GameCampaign : GameManager ,  IGameCampaign
    {
        public void BlackFriday(Gamer gamer,Game game)
        {
            if (gamer.BlackFridayDate == new DateTime(2021, 01, 29))
            {
                Console.WriteLine("BlackFriday Başlamıştır.");
                Console.WriteLine(" Bu oyun Black Friday indirimine girmiştir." + " " + game.GameId +" " + game.GameName + " " +game.GameType +" " + game.GamePrice+ " "+ game.GameStock);

                

            }
            else
            {
                Console.WriteLine("İndirimin günü geçmiştir.");
               
            }

        }

        public bool PayCashSold(Gamer gamer, Game game)
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

        public void StudentCampaing(Gamer gamer, Game game)
        {
            if (gamer.DateOfBirth == new DateTime(1998, 09, 25))
            {
                Console.WriteLine("%30 öğrenci indirimi uygulanıyor.");
                Console.WriteLine(" Bu oyun öğrenci  indirimindedir." +" " + game.GameId + " " + game.GameName + " " + game.GameType + " " + game.GamePrice + " " + game.GameStock);

            }
            else
            {
                Console.WriteLine("Malesef indirimden yararlanamazsınız.");
                
            }
        }
    }
}
