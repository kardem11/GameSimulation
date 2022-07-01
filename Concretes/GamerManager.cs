using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concretes
{
    internal class GamerManager : IGamerService

    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Lastname + "Added");
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Lastname + "Removed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " " + gamer.Lastname + " --Information Updated");
        }
    }
}
