using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_GameSales
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer); 
        void Delete(Gamer gamer); 
    }
}