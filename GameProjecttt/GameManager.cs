using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProjecttt
{
    public class GameManager :IGameService
    {
        
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi" + " " + game);
        }

        public void Buy(Game game)
        {
            Console.WriteLine("Oyun Satıldı" + " " + game);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi" + " " + game);
        }

        public void Update(Game game)
        {

            Console.WriteLine("Oyun Güncellendi" + " " + game);
        }
    }
}
