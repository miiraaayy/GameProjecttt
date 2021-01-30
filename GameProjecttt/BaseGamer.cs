using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjecttt
{
    public abstract class BaseGamer : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt oldu.");
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }


        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt bilgilerin güncellendi.");
        }
    }
}
