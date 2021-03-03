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
            Render render = new Render();
            HUD hud = new HUD();
            while (true)
            {
                player.Update();
                enemy.Update();
                map.Update();


                map.Draw(render);
                enemy.Draw(render);
                player.Draw(render);
                hud.Draw();
                render.Display();
            }

        }
    }
}
