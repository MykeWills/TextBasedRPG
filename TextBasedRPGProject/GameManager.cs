using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class GameManager
    {
       
        public void RunGame()
        {
            Console.WriteLine("Running the game now");

            Map map = new Map();
            Enemy enemy = new Enemy();
            Player player = new Player();


            while (true)
            {
                player.Update();
                enemy.Update();
                map.Update();


                map.Draw();
                enemy.Draw();
                player.Draw();
            }

        }
    }
}
