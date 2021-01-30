using System;

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
            gameCampaign.BlackFriday(new Gamer { BlackFridayDate = new DateTime(2021, 01, 29) });
            gameCampaign.StudentCampaing(new Gamer { DateOfBirth = new DateTime(1998, 9, 25) });
            gameCampaign.PayCashSold(true);
        }
    }
}
