using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Abstract
{
    internal interface ISaleService
    {
        public void GameSale(Gamer Gamer, Game game, Offer offer);
    }
}
