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
            Map map = new Map();
            Enemy enemy = new Enemy(map);
            Player player = new Player(map);

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
