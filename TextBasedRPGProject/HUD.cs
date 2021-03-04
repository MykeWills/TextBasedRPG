using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class HUD
    {
        private string pOutput;
        private string eOutput;

        public void Update(Player player, Enemy enemy)
        {
            pOutput = "Player: " + player.Position;
            eOutput = "Enemy: " + enemy.Position;
        }
        public void Draw(Render render)
        {
            render.Write(pOutput, new Coord2D(0, 0));
            render.Write(eOutput, new Coord2D(0, 1));
        }
    }
}
