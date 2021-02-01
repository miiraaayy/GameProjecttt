using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
   public interface IGameCampaign
    {
        void StudentCampaing(Gamer gamer , Game game);
        void BlackFriday(Gamer gamer , Game game);
        bool PayCashSold(Gamer gamer , Game game);
        void PayCashSold(bool v);
    }
}
