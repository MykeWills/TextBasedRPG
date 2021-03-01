using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Player : GameCharacter
    {
        public Player()
        {
            avatar = '@';
            name = "N163LPH03N1X";
            positionX = Console.WindowWidth / 2;
            positionY = Console.WindowHeight / 2;
            health = 100;
        }
        public void Update(Map map)
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (!map.IsWall(positionX, positionY + 1)) positionY++;
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (!map.IsWall(positionX, positionY - 1)) positionY--;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (!map.IsWall(positionX - 1, positionY)) positionX--;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (!map.IsWall(positionX + 1, positionY)) positionX++;
                    break;
            }
        }
     
    }
}
