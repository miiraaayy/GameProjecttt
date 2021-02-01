using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
   public  interface IGameService
   {
        void Add(Game game);
        void Update(Game game);
        void Buy(Game game);
        void Delete(Game game);

   }
}
