using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    abstract class GameCharacter
    {
        protected struct Point2D
        {
            public int x;
            public int y;
        }
        private Map map;
        protected char avatar;
        protected string name;
        protected Point2D position;
        protected int health;

        public void SetMap(Map map)
        {
            this.map = map;
        }
        public void TryMove(int dx, int dy)
        {
            if(!map.IsWall(position.x + dx, position.y + dy))
            {
                position.x += dx;
                position.y += dy;
            }
        }
        public GameCharacter()
        {
            Console.WriteLine("Game Character");
        }
        public void Draw()
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.Write(avatar);
        }
    }
}
