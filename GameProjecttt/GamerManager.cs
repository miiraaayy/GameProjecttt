using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
   public  class GamerManager:BaseGamer
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.GamerCheckControl(gamer))
            {
                base.Add(gamer);
                base.Update(gamer);

            }
            else
            {
                base.Delete(gamer);
            }

        }
    }
}
