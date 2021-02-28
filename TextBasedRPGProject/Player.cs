using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Player
    {
        private char avatar;
        private string name;
        private int positionX;
        private int positionY;
        private int health;

        public Player()
        {
            avatar = '@';
            name = "N163LPH03N1X";
            positionX = Console.WindowWidth / 2;
            positionY = Console.WindowHeight / 2;
            health = 100;
        }
        public void Update()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    positionY++;
                        break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    positionY--;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    positionX--;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    positionX++;
                    break;
            }
        }
        public void Draw()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(avatar);
        }
    }
}
