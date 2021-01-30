using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
   public interface IGameCampaign
    {
        void StudentCampaing(Gamer gamer);
        void BlackFriday(Gamer gamer);
        bool PayCashSold(Gamer gamer);
        void PayCashSold(bool v);
    }
}
