using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board
{
    class Controller
    {
        private Player P1, P2;
        private Board Game;

        public Controller()
        {
            P1 = new Player("a");
            P2 = new Player("b");
            Game = new Board(3, 4, 6);
        }

        //play
        public void PlayGame()
        {
            Game.PrintGame();
            while (true)
            {
                Console.Write(P1.GetName() + "turn ");
                P1.PickBalls(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P1.GetName() + "loses");
                    Console.WriteLine(P2.GetName() + "Wins");
                    break;
                }
                Console.Write(P1.GetName() + "turn ");
                P2.PickBalls(Game);
                Game.PrintGame();
                if (Game.IsGameOver())
                {
                    Console.WriteLine(P2.GetName() + " Loses");
                    Console.WriteLine(P1.GetName() + " Wins");
                    break;
                }
            }
        }

    }
}
