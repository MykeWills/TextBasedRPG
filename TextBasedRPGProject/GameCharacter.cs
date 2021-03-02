using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    abstract class GameCharacter
    {
        private Map map;
        protected char avatar;
        protected string name;
        protected int x;
        protected int y;
        protected int health;

        public void SetMap(Map map)
        {
            this.map = map;
        }
        public void TryMove(int dx, int dy)
        {
            if(!map.IsWall(x + dx, y + dy))
            {
                x += dx;
                y += dy;
            }
        }
        public GameCharacter()
        {
            Console.WriteLine("Game Character");
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(avatar);
        }
    }
}
