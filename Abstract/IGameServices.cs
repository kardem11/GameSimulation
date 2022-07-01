using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    internal interface IGameServices
    {
        public void AddGame(Game game);
        public void Update(Game game);
        public void Delete(Game game);
    }
}
