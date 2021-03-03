using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class HUD
    {
        private string output;

        public void Update(Player player)
        {
            output = "Player Position: " + player.Position;
        }
        public void Draw(Render render)
        {
            for(int c = 0; c < output.Length; c++)
            {

            }
        }
    }
}
