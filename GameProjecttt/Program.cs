using System;
using System.Collections.Generic;

namespace GameProjecttt
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseGamer gamerCheck = new GamerManager(new MernisService());
            gamerCheck.Add(new Gamer { DateOfBirth = new DateTime(1998, 9, 25), FirstName = "Miray", LastName = "Kozlu", NationalityId = "1236544789" });
            IGameSaleService gamerSale = new GameSaleManager();
            gamerSale.Sold(new Gamer { FirstName = "Miray", LastName = "Kozlu", DateOfBirth = new DateTime(1998, 9, 25), Id = 1, NationalityId = "123657899" });
            IGameCampaign gameCampaign = new GameCampaign();
            IGameService gameService = new GameManager();
            gameCampaign.BlackFriday(new Gamer { BlackFridayDate = new DateTime(2021, 01, 29) } , new Game { GameId =1 , GameName = "Spy Hunter PSVITA"  ,GameType = "Yarış" , GamePrice = 130, GameStock = 5}  );
            gameCampaign.StudentCampaing(new Gamer { DateOfBirth = new DateTime(1998, 9, 25) } , new Game { GameId = 2, GameName = "NBA 2K21" ,GameType = "Spor" ,GamePrice = 195 , GameStock =3}  );
            gameCampaign.PayCashSold(true);
        }
    }
}
