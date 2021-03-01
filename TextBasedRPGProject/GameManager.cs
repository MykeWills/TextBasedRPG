﻿using System;
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
            Enemy enemy = new Enemy();
            Player player = new Player();


            while (true)
            {
                player.Update(map);
                enemy.Update(map);
                map.Update();


                map.Draw();
                enemy.Draw();
                player.Draw();
            }

        }
    }
}
