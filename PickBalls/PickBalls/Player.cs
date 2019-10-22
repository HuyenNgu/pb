using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board
{
    class Player
    {
        private string Name;//khai báo biến 
        public Player(string name)
        {
            this.Name = name;
        }

        //player pick balls
        public void PickBalls(Board game)
        {
            Console.Write("which group do you choose? ");
            int group = int.Parse(Console.ReadLine());
            Console.Write("How many balls will you pick? ");
            int balls = int.Parse(Console.ReadLine());
            game.PickBall(group, balls);
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
