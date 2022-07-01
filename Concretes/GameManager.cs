using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concretes
{
    internal class GameManager : IGameServices
    {
        public void AddGame(Game Game)
        {
            Console.WriteLine(Game.GameName + "          --Game Added");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameId + "      Game Updated");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameId + "      Game Deleted");
        }

        public static implicit operator GameManager(GamerManager v)
        {
            throw new NotImplementedException();
        }
    }
}

        

    

