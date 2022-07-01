using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concretes
{
    internal class SaleManager : ISaleService
    {
        public void GameSale(Gamer Gamer, Game game, Offer offer)
        {
            Console.WriteLine(Gamer.Name+ game.GameName+ offer.OfferRate+ "with twenty percent discount");
        }
    }
}
