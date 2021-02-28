using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    abstract class GameCharacter
    {
        protected char avatar;
        protected string name;
        protected int positionX;
        protected int positionY;
        protected int health;

        public GameCharacter()
        {
            Console.WriteLine("Game Character");
        }
        public void Draw()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(avatar);
        }
    }
}
