using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Enemy : GameCharacter
    {
        Random random = new Random();
       
        public Enemy(Map map)
        {

            SetMap(map);
            avatar = 'E';
            name = "Slime";
            position.x = Console.WindowWidth / 4;
            position.y = Console.WindowHeight / 4;
            health = 1;
        }
        public void Update()
        {
            int rnd = random.Next(5);
            switch (rnd)
            {
                case 0:
                    TryMove(0, -1);
                    break;
                case 1:
                    TryMove(0, 1);
                    break;
                case 2:
                    TryMove(-1, 0);
                    break;
                case 3:
                    TryMove(1, 0);
                    break;
                case 4:
                    break;
            }
        }
      
    }
}
