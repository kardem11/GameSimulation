using GameSimulation.Concretes;
using GameSimulation.Entities;

namespace GameSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager Gamermanager = new GamerManager();
            Gamermanager.Update(gamer: new Gamer
            {
                Name = "Yaren",
                Lastname = "Özkılıç",
                NationallityNo = "2365212333",
                DateOfBirth = 1990,
            });

            GameManager gameManager = new GameManager();
            gameManager.AddGame(Game: new Game { GameId = 230, GameName = "Fish" });
            
            Console.WriteLine("   With twenty percent discount");
        }


           
            
        

        
             
             

            
        
            
            
            
            
            
            
            
    }
}
    