using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjetDemo
{
    interface IGamerManager
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
