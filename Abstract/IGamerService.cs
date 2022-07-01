using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    internal interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Remove(Gamer gamer);
        public void Update(Gamer gamer);
    }
}
