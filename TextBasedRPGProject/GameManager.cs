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



            Player player = new Player();




            while (true)
            {
                player.Update();



                player.Draw();
            }

        }
    }
}
